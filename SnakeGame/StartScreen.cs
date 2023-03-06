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
        }

        private void Leaderboardbtn_Click(object sender, EventArgs e)
        {
            //Elrejtjük a "StartScreen" formot és mutatjuk a "LeaderboardScreen" formot.
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
                    if (string.IsNullOrEmpty(playerName) || !Regex.IsMatch(playerName, "^[a-zA-Z0-9]*$"))
                    {
                        MessageBox.Show("A játékos névbe csak számok és betűk lehetnek! (Player name can only contain numbers and letters!)", "Hiba!");
                        return;
                    }

                    Program.gamescreen.PlayerName = playerName;
                    Program.gamescreen.Show();
                    Program.gamescreen.RestartGame();
                    this.Hide();
                }
            }

        }

    }
}
