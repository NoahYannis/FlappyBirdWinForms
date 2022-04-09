
namespace FlappyBirdWinForms
{
    partial class StartBild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStartbild = new System.Windows.Forms.Label();
            this.btnSpielen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStartbild
            // 
            this.lblStartbild.BackColor = System.Drawing.Color.Transparent;
            this.lblStartbild.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartbild.Location = new System.Drawing.Point(134, 145);
            this.lblStartbild.Name = "lblStartbild";
            this.lblStartbild.Size = new System.Drawing.Size(467, 51);
            this.lblStartbild.TabIndex = 0;
            this.lblStartbild.Text = "Flappy Bird von Noah Guderjahn :)";
            // 
            // btnSpielen
            // 
            this.btnSpielen.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSpielen.Location = new System.Drawing.Point(215, 288);
            this.btnSpielen.Name = "btnSpielen";
            this.btnSpielen.Size = new System.Drawing.Size(227, 82);
            this.btnSpielen.TabIndex = 1;
            this.btnSpielen.Text = "Spielen";
            this.btnSpielen.UseVisualStyleBackColor = true;
            this.btnSpielen.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartBild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBirdWinForms.Properties.Resources.ground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 511);
            this.Controls.Add(this.btnSpielen);
            this.Controls.Add(this.lblStartbild);
            this.DoubleBuffered = true;
            this.Name = "StartBild";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStartbild;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSpielen;
    }
}