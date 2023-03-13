using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SnakeGame
{
    public partial class GameOverScreen : Form
    {

        private bool userConfirmedClosing;

        public GameOverScreen()
        {
            InitializeComponent();
            this.VisibleChanged += GameOverScreen_VisibleChanged;
        }

        private void GameOverScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                userConfirmedClosing = false; // reset userConfirmedClosing flag
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

            Program.database.Save(Program.gamescreen.PlayerName,Program.gamescreen.highScore,Program.gamescreen.Finallevel,DateTime.Now);
            var startscreen = new StartScreen();
            startscreen.Show();
            userConfirmedClosing = true;
            Program.gamescreen.Close();       
            this.Close();

        }

        private void PlayAgainbtn_Click(object sender, EventArgs e)
        {

            Program.gamescreen.RestartGame();
            userConfirmedClosing = true;
            this.Close();

        }

        private void ReturntoTSbtn_Click(object sender, EventArgs e)
        {

            //Bezárjuk a "GameOverScreen" formot és mutatjuk a "StartScreen" formot.
            var startscreen = new StartScreen();
            startscreen.Show();
            userConfirmedClosing = true;
            Program.gamescreen.Hide();
            this.Close();

        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {

            FinalScorelbl.Text = "Final Score: " + Program.gamescreen.highScore;
            FinalLevellbl.Text = "Final Level: " + Program.gamescreen.Finallevel;

        }

        private void GameOverScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing && !userConfirmedClosing)
            {
                e.Cancel = true;

                using (var dialog = new CloseScreen())
                {
                    dialog.FormClosed += (s, args) => {
                        userConfirmedClosing = false; // reset flag after dialog is closed
                    };
                    this.FormClosing -= GameOverScreen_FormClosing; // remove event handler
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
                    this.FormClosing += GameOverScreen_FormClosing; // re-add event handler
                }
            }

        }

    }
}
