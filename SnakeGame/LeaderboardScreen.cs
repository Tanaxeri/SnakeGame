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
            this.FormClosing += new FormClosingEventHandler(LeaderboardScreen_FormClosing);
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

            Application.Exit();

        }

    }
}
