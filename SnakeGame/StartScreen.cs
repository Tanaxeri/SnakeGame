using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(StartScreen_FormClosing);
        }

        private void Leaderboardbtn_Click(object sender, EventArgs e)
        {
            //Elrejtük a "StartScreen" formot és mutatjuk a "LeaderboardScreen" formot.
            this.Hide();
            Program.leaderboardscreen.Show();

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void Playbtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Program.gamescreen.Show();

        }

        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }

    }
}
