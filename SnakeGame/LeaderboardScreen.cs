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
            this.Close();
            Program.startscreen.Show();

        }

        private void LeaderboardScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

                //Megjelenít egy üzenetet ami megkérdi, hogy beakarja-e zárni
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    e.Cancel = false;

                }
                else if(result == DialogResult.No)
                {

                    e.Cancel = true;

                }  

        }

    }
}
