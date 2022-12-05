namespace KursachNewNew
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtScore = new System.Windows.Forms.Label();
            this.playerLeft = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerRight = new System.Windows.Forms.PictureBox();
            this.wallforspring = new System.Windows.Forms.PictureBox();
            this.Spring = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.BrickForSpring = new System.Windows.Forms.PictureBox();
            this.Trigger = new System.Windows.Forms.PictureBox();
            this.EventTickForSpring = new System.Windows.Forms.Timer(this.components);
            this.timer_Sec = new System.Windows.Forms.Timer(this.components);
            this.label_Time = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallforspring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrickForSpring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trigger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Location = new System.Drawing.Point(146, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(48, 15);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score: 0";
            // 
            // playerLeft
            // 
            this.playerLeft.BackColor = System.Drawing.Color.Black;
            this.playerLeft.Location = new System.Drawing.Point(44, 720);
            this.playerLeft.Name = "playerLeft";
            this.playerLeft.Size = new System.Drawing.Size(150, 28);
            this.playerLeft.TabIndex = 1;
            this.playerLeft.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ball.Location = new System.Drawing.Point(558, 663);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(17, 18);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Lime;
            this.pictureBox3.Location = new System.Drawing.Point(104, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 31);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "blocks";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Lime;
            this.pictureBox8.Location = new System.Drawing.Point(340, 153);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(93, 31);
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "blocks";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Lime;
            this.pictureBox13.Location = new System.Drawing.Point(203, 330);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(93, 31);
            this.pictureBox13.TabIndex = 15;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "blocks";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // playerRight
            // 
            this.playerRight.BackColor = System.Drawing.Color.Black;
            this.playerRight.Location = new System.Drawing.Point(324, 720);
            this.playerRight.Name = "playerRight";
            this.playerRight.Size = new System.Drawing.Size(150, 28);
            this.playerRight.TabIndex = 18;
            this.playerRight.TabStop = false;
            // 
            // wallforspring
            // 
            this.wallforspring.BackColor = System.Drawing.Color.Red;
            this.wallforspring.Location = new System.Drawing.Point(537, 124);
            this.wallforspring.Name = "wallforspring";
            this.wallforspring.Size = new System.Drawing.Size(15, 637);
            this.wallforspring.TabIndex = 19;
            this.wallforspring.TabStop = false;
            this.wallforspring.Tag = "wall";
            // 
            // Spring
            // 
            this.Spring.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Spring.BackgroundImage")));
            this.Spring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Spring.Location = new System.Drawing.Point(558, 699);
            this.Spring.Name = "Spring";
            this.Spring.Size = new System.Drawing.Size(25, 50);
            this.Spring.TabIndex = 20;
            this.Spring.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Location = new System.Drawing.Point(78, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 234);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "blocks";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Lime;
            this.pictureBox2.Location = new System.Drawing.Point(340, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 87);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "blocks";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Red;
            this.pictureBox4.Location = new System.Drawing.Point(426, 156);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 23);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "wall";
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Red;
            this.pictureBox5.Location = new System.Drawing.Point(338, 156);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 23);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "wall";
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Red;
            this.pictureBox6.Location = new System.Drawing.Point(289, 334);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 24);
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "wall";
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Red;
            this.pictureBox7.Location = new System.Drawing.Point(200, 332);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 26);
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "wall";
            this.pictureBox7.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Red;
            this.pictureBox9.Location = new System.Drawing.Point(190, 117);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(10, 27);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "wall";
            this.pictureBox9.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Red;
            this.pictureBox10.Location = new System.Drawing.Point(72, 118);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(10, 228);
            this.pictureBox10.TabIndex = 28;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "wall";
            this.pictureBox10.Visible = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Red;
            this.pictureBox11.Location = new System.Drawing.Point(103, 119);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(10, 226);
            this.pictureBox11.TabIndex = 29;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "wall";
            this.pictureBox11.Visible = false;
            // 
            // BrickForSpring
            // 
            this.BrickForSpring.BackColor = System.Drawing.Color.Lime;
            this.BrickForSpring.Location = new System.Drawing.Point(490, 357);
            this.BrickForSpring.Name = "BrickForSpring";
            this.BrickForSpring.Size = new System.Drawing.Size(15, 128);
            this.BrickForSpring.TabIndex = 30;
            this.BrickForSpring.TabStop = false;
            this.BrickForSpring.Tag = "wall";
            this.BrickForSpring.Visible = false;
            // 
            // Trigger
            // 
            this.Trigger.Location = new System.Drawing.Point(523, 0);
            this.Trigger.Name = "Trigger";
            this.Trigger.Size = new System.Drawing.Size(11, 128);
            this.Trigger.TabIndex = 31;
            this.Trigger.TabStop = false;
            // 
            // EventTickForSpring
            // 
            this.EventTickForSpring.Interval = 1000;
            this.EventTickForSpring.Tick += new System.EventHandler(this.tick);
            // 
            // timer_Sec
            // 
            this.timer_Sec.Interval = 1000;
            this.timer_Sec.Tick += new System.EventHandler(this.Timer_Sec);
            // 
            // label_Time
            // 
            this.label_Time.Location = new System.Drawing.Point(333, 9);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(100, 23);
            this.label_Time.TabIndex = 0;
            this.label_Time.Text = "Time 00:00";
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Red;
            this.pictureBox12.Location = new System.Drawing.Point(338, 179);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(10, 88);
            this.pictureBox12.TabIndex = 32;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "wall";
            this.pictureBox12.Visible = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Red;
            this.pictureBox14.Location = new System.Drawing.Point(358, 179);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(10, 88);
            this.pictureBox14.TabIndex = 33;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "wall";
            this.pictureBox14.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.Trigger);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.BrickForSpring);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Spring);
            this.Controls.Add(this.wallforspring);
            this.Controls.Add(this.playerRight);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.playerLeft);
            this.Controls.Add(this.txtScore);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PinBall";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.playerLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallforspring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrickForSpring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trigger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtScore;
        private PictureBox playerLeft;
        private PictureBox ball;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private PictureBox pictureBox13;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox playerRight;
        private PictureBox wallforspring;
        private PictureBox Spring;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox BrickForSpring;
        private PictureBox Trigger;
        private System.Windows.Forms.Timer EventTickForSpring;
        private System.Windows.Forms.Timer timer_Sec;
        private Label label_Time;
        private PictureBox pictureBox12;
        private PictureBox pictureBox14;
    }
}