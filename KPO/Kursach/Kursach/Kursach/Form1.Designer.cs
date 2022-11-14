namespace Kursach
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
            this.timer_Movement = new System.Windows.Forms.Timer(this.components);
            this.WorldFrame = new System.Windows.Forms.Panel();
            this.pb_Ball = new System.Windows.Forms.PictureBox();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.pb_Enemy = new System.Windows.Forms.PictureBox();
            this.WorldFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_Movement
            // 
            this.timer_Movement.Enabled = true;
            this.timer_Movement.Interval = 50;
            // 
            // WorldFrame
            // 
            this.WorldFrame.Controls.Add(this.pb_Enemy);
            this.WorldFrame.Controls.Add(this.pb_Player);
            this.WorldFrame.Controls.Add(this.pb_Ball);
            this.WorldFrame.Location = new System.Drawing.Point(0, 0);
            this.WorldFrame.Name = "WorldFrame";
            this.WorldFrame.Size = new System.Drawing.Size(803, 453);
            this.WorldFrame.TabIndex = 0;
            // 
            // pb_Ball
            // 
            this.pb_Ball.BackColor = System.Drawing.Color.Blue;
            this.pb_Ball.Location = new System.Drawing.Point(386, 180);
            this.pb_Ball.Name = "pb_Ball";
            this.pb_Ball.Size = new System.Drawing.Size(19, 20);
            this.pb_Ball.TabIndex = 0;
            this.pb_Ball.TabStop = false;
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Red;
            this.pb_Player.Location = new System.Drawing.Point(12, 178);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(17, 79);
            this.pb_Player.TabIndex = 1;
            this.pb_Player.TabStop = false;
            // 
            // pb_Enemy
            // 
            this.pb_Enemy.BackColor = System.Drawing.Color.Black;
            this.pb_Enemy.Location = new System.Drawing.Point(770, 178);
            this.pb_Enemy.Name = "pb_Enemy";
            this.pb_Enemy.Size = new System.Drawing.Size(18, 79);
            this.pb_Enemy.TabIndex = 2;
            this.pb_Enemy.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WorldFrame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WorldFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Enemy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_Movement;
        private Panel WorldFrame;
        private PictureBox pb_Ball;
        private PictureBox pb_Enemy;
        private PictureBox pb_Player;
    }
}