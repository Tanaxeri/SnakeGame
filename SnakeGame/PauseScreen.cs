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
        private bool userConfirmedClosing;
        public PauseScreen()
        {
            InitializeComponent();
            this.Shown += PauseScreen_Shown;
        }

        private void PauseScreen_Shown(object sender, EventArgs e)
        {
            userConfirmedClosing = false; // reset userConfirmedClosing flag
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            userConfirmedClosing = true;
            this.Close();
            Program.gamescreen.GameTimer.Start();

        }

        private void Restartbtn_Click(object sender, EventArgs e)
        {
           
            Program.gamescreen.RestartGame();
            userConfirmedClosing = true;
            this.Close();            

        }

        private void ReturntoTSbtn_Click(object sender, EventArgs e)
        {

            //Bezárjuk a "PauseScreen" formot és mutatjuk a "StartScreen" formot.
            Program.gamescreen.Hide();
            Program.startscreen.Show();
            userConfirmedClosing = true;
            this.Close();

        }

        private void PauseScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing && !userConfirmedClosing)
            {
                e.Cancel = true;

                using (var dialog = new CloseScreen())
                {
                    this.FormClosing -= PauseScreen_FormClosing; // remove event handler
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
                    this.FormClosing += PauseScreen_FormClosing; // re-add event handler
                }
            }

        }

    }
}
