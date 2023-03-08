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
    public partial class PauseScreen : Form
    {
        private bool userConfirmedClosing = false;
        public PauseScreen()
        {
            InitializeComponent();
            this.FormClosing += PauseScreen_FormClosing;
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {

            this.Close();
            Program.gamescreen.GameTimer.Start();

        }

        private void Restartbtn_Click(object sender, EventArgs e)
        {

            userConfirmedClosing = true;
            this.Close();
            Program.gamescreen.Show();
            Program.gamescreen.RestartGame();

        }

        private void ReturntoTSbtn_Click(object sender, EventArgs e)
        {

            //Bezárjuk a "PauseScreen" formot és mutatjuk a "StartScreen" formot.
            userConfirmedClosing = true;
            this.Close();
            Program.gamescreen.Hide();
            Program.startscreen.Show();

        }

        private void PauseScreen_FormClosing(object sender, FormClosingEventArgs e)
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
                    if (dialog.ShowDialog() == DialogResult.No)
                    {

                        userConfirmedClosing = false;
                        e.Cancel = true;

                    }
                }
            }

        }

    }
}
