using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlappyBirdWinForms
{
    public partial class StartBild : Form
    {
        public StartBild()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpielFenster gameScreen = new SpielFenster();
            gameScreen.Show();

            StartBild startBild = new StartBild();
            startBild.Visible = false;
            
        }

    }
}
