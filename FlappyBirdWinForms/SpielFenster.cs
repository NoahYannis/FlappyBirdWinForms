using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlappyBirdWinForms
{
    public partial class SpielFenster : Form
    {

        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        Random random = new Random();


        public SpielFenster()
        {
            InitializeComponent();
        }


        private void gameTimerEvent(object sender, EventArgs e)
        {
            pbFlappyBird.Top += gravity;
            pbPipeBottom.Left -= pipeSpeed;
            pbPipeTop.Left -= pipeSpeed;
            lblScoreText.Text = "Score: " + score.ToString();

            if (pbPipeBottom.Left < -150)
            {
                pbPipeBottom.Left = 800;
                pbPipeBottom.Top = random.Next(350, 480);
                pbPipeBottom.Height = pbPipeBottom.Top;
                score++;
            }
            if (pbPipeTop.Left < -150)
            {
                pbPipeTop.Left = 800;
                pbPipeTop.Top = 0;
                pbPipeTop.Height = random.Next(80, 200); 
            }

            if (pbFlappyBird.Bounds.IntersectsWith(pbPipeTop.Bounds) ||
                pbFlappyBird.Bounds.IntersectsWith(pbPipeBottom.Bounds) ||
                pbFlappyBird.Bounds.IntersectsWith(pbGround.Bounds) || pbFlappyBird.Top < -25)
            {
                endGame();
            }
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            lblScoreText.Text += " [GAME OVER]";
            lblScoreText.ForeColor = Color.Red;
        }
    }
}
