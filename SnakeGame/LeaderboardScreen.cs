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
            this.Shown += LeaderboardScreen_Shown;
        }

        private void LeaderboardScreen_Shown(object sender, EventArgs e)
        {
            userConfirmedClosing = false; // reset userConfirmedClosing flag
        }

        private void LeaderboardScreen_Load(object sender, EventArgs e)
        {

            string leaderboardText = Program.database.GetLeaderboard();
            Lblbl.Text = leaderboardText;

        }

        private void ReturntoTSbtn_Click(object sender, EventArgs e)
        {
            //Elrejtük a "LeaderboardScreen" formot és mutatjuk a "StartScreen" formot.
            Program.startscreen.Show();
            userConfirmedClosing = true;
            this.Hide();

        }

        private void LeaderboardScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !userConfirmedClosing)
            {
                e.Cancel = true;

                using (var dialog = new CloseScreen())
                {
                    this.FormClosing -= LeaderboardScreen_FormClosing; // remove event handler
                    var result = dialog.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        userConfirmedClosing = true;
                        Application.Exit();
                    }
                    else if (result == DialogResult.No)
                    {
                        userConfirmedClosing = false;
                    }
                    this.FormClosing += LeaderboardScreen_FormClosing; // re-add event handler
                }
            }
        }


    }
}
