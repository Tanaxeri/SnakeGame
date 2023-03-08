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
    public partial class LeaderboardScreen : Form
    {

        private bool userConfirmedClosing = false;

        public LeaderboardScreen()
        {
            InitializeComponent();
            this.FormClosing += LeaderboardScreen_FormClosing;
        }

        private void LeaderboardScreen_Load(object sender, EventArgs e)
        {

            string leaderboardText = Program.database.GetLeaderboard();
            Lblbl.Text = leaderboardText;

        }

        private void ReturntoTSbtn_Click(object sender, EventArgs e)
        {
            //bezárjuk a "LeaderboardScreen" formot és mutatjuk a "StartScreen" formot.
            userConfirmedClosing = true;
            this.Hide();
            Program.startscreen.Show();

        }

        private void LeaderboardScreen_FormClosing(object sender, FormClosingEventArgs e)
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
