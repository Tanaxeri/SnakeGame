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
        public StartScreen()
        {
            InitializeComponent();
            this.FormClosing += StartScreen_FormClosing;
        }

        private void Leaderboardbtn_Click(object sender, EventArgs e)
        {
            //Bezárjuk a "StartScreen" formot és mutatjuk a "LeaderboardScreen" formot.
            this.Close();
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
                    this.Close();
                }
            }

        }

        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Megjelenít egy üzenetet ami megkérdi, hogy beakarja-e zárni
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                e.Cancel = false;

            }
            else if (result == DialogResult.No)
            {

                e.Cancel = true;

            }

        }

    }
}
