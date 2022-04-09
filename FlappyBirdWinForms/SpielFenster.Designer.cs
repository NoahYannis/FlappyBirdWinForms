
namespace FlappyBirdWinForms
{
    partial class SpielFenster
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
            this.pbFlappyBird = new System.Windows.Forms.PictureBox();
            this.pbPipeBottom = new System.Windows.Forms.PictureBox();
            this.pbPipeTop = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.lblScoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFlappyBird
            // 
            this.pbFlappyBird.Image = global::FlappyBirdWinForms.Properties.Resources.bird;
            this.pbFlappyBird.Location = new System.Drawing.Point(148, 244);
            this.pbFlappyBird.Name = "pbFlappyBird";
            this.pbFlappyBird.Size = new System.Drawing.Size(62, 52);
            this.pbFlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlappyBird.TabIndex = 0;
            this.pbFlappyBird.TabStop = false;
            // 
            // pbPipeBottom
            // 
            this.pbPipeBottom.Image = global::FlappyBirdWinForms.Properties.Resources.pipe;
            this.pbPipeBottom.Location = new System.Drawing.Point(399, 451);
            this.pbPipeBottom.Name = "pbPipeBottom";
            this.pbPipeBottom.Size = new System.Drawing.Size(125, 138);
            this.pbPipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipeBottom.TabIndex = 1;
            this.pbPipeBottom.TabStop = false;
            // 
            // pbPipeTop
            // 
            this.pbPipeTop.Image = global::FlappyBirdWinForms.Properties.Resources.pipedown;
            this.pbPipeTop.Location = new System.Drawing.Point(399, -2);
            this.pbPipeTop.Name = "pbPipeTop";
            this.pbPipeTop.Size = new System.Drawing.Size(125, 156);
            this.pbPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipeTop.TabIndex = 2;
            this.pbPipeTop.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.Image = global::FlappyBirdWinForms.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(-21, 585);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(697, 75);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 3;
            this.pbGround.TabStop = false;
            // 
            // lblScoreText
            // 
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.BackColor = System.Drawing.Color.Moccasin;
            this.lblScoreText.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScoreText.Location = new System.Drawing.Point(12, 608);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(102, 29);
            this.lblScoreText.TabIndex = 4;
            this.lblScoreText.Text = " Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(646, 640);
            this.Controls.Add(this.pbFlappyBird);
            this.Controls.Add(this.lblScoreText);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbPipeBottom);
            this.Controls.Add(this.pbPipeTop);
            this.Name = "Form1";
            this.Text = "Flappy Bird WinForms";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFlappyBird;
        private System.Windows.Forms.PictureBox pbPipeBottom;
        private System.Windows.Forms.PictureBox pbPipeTop;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

