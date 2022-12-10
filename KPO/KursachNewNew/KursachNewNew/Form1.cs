using System.ComponentModel.Design.Serialization;
using System.Drawing.Drawing2D;
using System.Text;

namespace KursachNewNew
{
    public partial class Form1 : Form
    {

        bool goleftUp; // some initialization
        bool goleftDown;
        bool gorightUp;
        bool gorightDown;
        bool isGameOver;
        bool SpringDown;

        int score;
        int ballx;
        int bally;
        int playerSpeed;
        int b = 0;
        int i = 0;
        Random rnd =new Random(); //random function
        public Form1()
        {
            InitializeComponent();

            PlaceBall();
        }

        private void setupGame()
        {

            i = 0;
            score = 0;
            ballx = 0;
            bally = 0;
            playerSpeed = 12;
            txtScore.Text = "Score: " + score;
            label_Time.Text = "Time:";
            Trigger.Location = new Point(517, 0);
            BrickForSpring.Location = new Point(490, 357);
            timer_Sec.Enabled = false;
            isGameOver = false;
            BrickForSpring.Visible = false;
            gameTimer.Start();

            //foreach(Control x in this.Controls) //paint our blocks
            //{
            //    if (x is PictureBox && (string)x.Tag == "blocks")
            //    {
            //        x.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //    }
            //}
        }

        private void gameOver(string message) // game over event
        {
            isGameOver = true;
            gameTimer.Stop();
            timer_Sec.Stop();
            txtScore.Text = "Score: " + score + " " + message;
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score:" + score; // score counter
            if (goleftUp == true) //left player go up
            {
                while (playerLeft.Top >= 690)
                {
                    playerLeft.Top--;
                }
                //playerLeft.Top = 700;
            }
            if (goleftUp == false) // left player go down
            {
                while (playerLeft.Top <= 710)
                {
                    playerLeft.Top++;
                }
                //playerLeft.Top = 720 ;
            }
            if (gorightUp == true) // right player go up
            {
                playerRight.Top = 690;
            }
            if (gorightUp == false) // right player go down
            {
                playerRight.Top = 710;
            }
            ball.Left += ballx;
            ball.Top += bally;

            if (ball.Left < 52 || ball.Left > 562) // bounce with left and right corner
            {
                ballx = -ballx;
            }
            if (ball.Top < 0) //bounce with top corner
            {
                bally = -bally;
            }
            if (ball.Bounds.IntersectsWith(playerLeft.Bounds)) // interact with Left Player
            {
                bally = rnd.Next(5, 12) * -1;

                if (ballx < 0)
                {
                    ballx = rnd.Next(5, 12) * -1;
                }
                else
                {
                    ballx = rnd.Next(5, 12);
                }
            }
            if (ball.Bounds.IntersectsWith(playerRight.Bounds)) // interact with Right Player
            {
                bally = rnd.Next(5, 12) * -1;

                if (ballx < 0)
                {
                    ballx = rnd.Next(5, 12) * -1;
                }
                else
                {
                    ballx = rnd.Next(5, 12);
                }
            }
            if (ball.Bounds.IntersectsWith(Spring.Bounds))// interact with spring
            {
                timer_Sec.Enabled = true;
                bally = rnd.Next(5, 12) * -1;

                if (ballx < 0)
                {
                    ballx = rnd.Next(5, 12) * -1;
                }
                else
                {
                    ballx = rnd.Next(5, 12);
                }
            }
            foreach (Control x in this.Controls) //bounce for wall
            {
                if (x is PictureBox && (string)x.Tag == "wall")

                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        ballx = -ballx;//change direction
                    }
                }
            }
            if (ball.Bounds.IntersectsWith(wallforspring.Bounds))
            {
                ballx = -ballx;//change direction
            }    
            if (ball.Bounds.IntersectsWith(BrickForSpring.Bounds))
            {
                ballx = -ballx;//change direction
            }
            foreach (Control x in this.Controls)// bounce with blocks
            {
                if (x is PictureBox && (string)x.Tag == "blocks" | (string)x.Tag == "wall")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        b += 1;

                        if (b == 10)
                        {
                            ballx = -ballx;
                            b = 0;
                        }
                    }
                }
            }

            if (SpringDown == true)
            {
                Spring.Height = 80; Spring.Top = 675; //stretching the spring
            }
            if (SpringDown == false)
            {
                Spring.Height = 50; Spring.Top = 700;//contraction the spring
            }

            foreach (Control x in this.Controls)// bounce with blocks
            {
                if (x is PictureBox && (string)x.Tag == "blocks" | (string)x.Tag == "wall")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;
                        bally = -bally;
                    }
                }
            }
            if (ball.Bounds.IntersectsWith(Trigger.Bounds)) //trigger for closing wall
            {
                EventTickForSpring.Enabled = true;
            }
            if (ball.Top > 740)//dead zone
            {
                gameOver("You Lose, press enter to play again");
                Form2 newform = new Form2(score.ToString());
                newform.Show();
            }
        }
        private void PlaceBall()
        {
            ball.Left =551;
            ball.Top =665;
            setupGame();
        }
        
        private void Timer_Sec(object sender, EventArgs e)
        {
            i++;
            
            label_Time.Text = "Time: " + i.ToString();
        }
        private void tick(object sender, EventArgs e)// close wall for spring
        {
            BrickForSpring.Visible = true;
            BrickForSpring.Location = new Point(529, 0);
            Trigger.Location = new Point(570, 0);
            Trigger.Visible = false;
           
            EventTickForSpring.Enabled=false;
        }

        private void keyisdown(object sender, KeyEventArgs e)//key is down reconciliator
        {
            if(e.KeyCode == Keys.Z)
            {
                goleftUp = true;
                
            }
            if(e.KeyCode == Keys.C)
            {
                gorightUp = true;
            }
            if(e.KeyCode== Keys.Space)
            {
                SpringDown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)// key is up reconciliator
        {
            if (e.KeyCode == Keys.Z)
            {
                goleftUp = false;
            }
            if (e.KeyCode == Keys.C)
            {
                gorightUp = false;
            }
            if( e.KeyCode == Keys.Space)
            {
                SpringDown = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver ==true)
            {
                PlaceBall();
            }
            if(e.KeyCode == Keys.R)
            {
                PlaceBall();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        
    }
}