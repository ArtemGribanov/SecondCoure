using System.ComponentModel.Design.Serialization;

namespace KursachNewNew
{
    public partial class Form1 : Form
    {

        bool goleftUp;
        bool goleftDown;
        bool gorightUp;
        bool gorightDown;
        bool isGameOver;

        int score;
        int ballx;
        int bally;
        int playerSpeed;

        Random rnd =new Random();
        public Form1()
        {
            InitializeComponent();

            setupGame();
        }

        private void setupGame()
        {
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 12;
            txtScore.Text = "Score: " + score;

            gameTimer.Start();

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    x.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
            }
        }

        private void gameOver(string message)
        {
            isGameOver = true;
            gameTimer.Stop();

            txtScore.Text = "Score: " + score + " " + message;
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score:" + score;
            if (goleftUp == true )
            {
                while(playerLeft.Top >= 700)
                {
                    playerLeft.Top--;
                }
                    //playerLeft.Top = 700;
            }
            if (goleftUp == false )
            {
                while (playerLeft.Top <= 720)
                {
                    playerLeft.Top++;
                }
                //playerLeft.Top = 720 ;
            }
            if (gorightUp == true)
            {
                playerRight.Top = 700;
            }
            if (gorightUp == false)
            {
                playerRight.Top = 720;
            }
            ball.Left += ballx;
            ball.Top += bally;

            if (ball.Left < 0 || ball.Left > 566)
            {
                ballx = -ballx;
            }
            if (ball.Top < 0)
            {
                bally = -bally;
            }
            if (ball.Bounds.IntersectsWith(playerLeft.Bounds))
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
            if (ball.Bounds.IntersectsWith(playerRight.Bounds))
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
            if (ball.Bounds.IntersectsWith(Spring.Bounds))
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
            if (ball.Bounds.IntersectsWith(wall.Bounds))
            {
                ballx = -ballx;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;

                        bally = -bally;

                        
                    }

                }
            }

            

            if(ball.Top > 740)
            {
                gameOver("You Lose");
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Z)
            {
                goleftUp = true;
                
            }
            if(e.KeyCode == Keys.C)
            {
                gorightUp = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                goleftUp = false;
            }
            if (e.KeyCode == Keys.C)
            {
                gorightUp = false;
            }
        }
    }
}