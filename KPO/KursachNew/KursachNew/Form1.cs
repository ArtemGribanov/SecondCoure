using System.Runtime;
using System.Windows.Forms;

namespace KursachNew
{
    public partial class Form1 : Form
    {
        private int ballWight =20;
        private int ballHeight=20; 
        private int ballPosX = 0;
        private int ballPosY = 0;
        private int moveStepX = 4; 
        private int moveStepY = 4;
        public Form1()
        {
            InitializeComponent();
            Size = new Size(600,800);
            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint,
                true
                );

            this.UpdateStyles();
        }

        private void PaintCircle(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.BackColor);
            e.Graphics.FillEllipse(Brushes.Red,
                ballPosX,ballPosY,
                ballWight,ballHeight);
            e.Graphics.DrawEllipse(Pens.Black,
                ballPosX, ballPosY,
                ballWight, ballHeight);
        }

        private void MoveBall(object sender, EventArgs e)
        {
            ballPosX += moveStepX;
            if(ballPosX < 0||ballPosX + ballWight > this.ClientSize.Width)
            {
                moveStepX = -moveStepX;
            }
            ballPosY += moveStepY;
            if (ballPosY< 0 || ballPosY + ballHeight > this.ClientSize.Height)
            {
                moveStepY = -moveStepY;
            }
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Form2 newForm = new Form2();
                newForm.Show();
            
        }
    }
}