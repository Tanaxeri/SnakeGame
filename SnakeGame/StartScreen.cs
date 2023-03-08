using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class StartScreen : Form
    {

        private bool userConfirmedClosing = false;

        public StartScreen()
        {
            InitializeComponent();
            this.FormClosing += StartScreen_FormClosing;
        }

        private void Leaderboardbtn_Click(object sender, EventArgs e)
        {
            //Elrejtük a "StartScreen" formot és mutatjuk a "LeaderboardScreen" formot.
            userConfirmedClosing = true;
            this.Hide();
            Program.leaderboardscreen.Show();

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void Playbtn_Click(object sender, EventArgs e)
        {
            using (var dialog = new NameDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var playerName = dialog.PlayerName;

                    Program.gamescreen.PlayerName = playerName;
                    Program.gamescreen.Show();
                    Program.gamescreen.RestartGame();
                    userConfirmedClosing = true;
                    this.Hide();
                }
            }

        }

        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing && !userConfirmedClosing)
            {
                e.Cancel = true;

                using (var dialog = new CloseScreen())
                {
                    if (dialog.ShowDialog() == DialogResult.Yes)
                    {
                        userConfirmedClosing = true;
                        Application.Exit();
                    }
                }
            }

        }

    }
}
