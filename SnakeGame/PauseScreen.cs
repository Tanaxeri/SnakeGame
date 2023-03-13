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
            this.VisibleChanged += PauseScreen_VisibleChanged;
        }

        private void PauseScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                userConfirmedClosing = false; // reset userConfirmedClosing flag
            }
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {

            Program.gamescreen.GameTimer.Start();
            userConfirmedClosing = true;
            this.Close();            

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
            var startscreen = new StartScreen();            
            startscreen.Show();
            userConfirmedClosing = true;
            Program.gamescreen.Hide();
            this.Close();

        }

        private void PauseScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing && !userConfirmedClosing)
            {
                e.Cancel = true;

                using (var dialog = new CloseScreen())
                {
                    dialog.FormClosed += (s, args) => {
                        userConfirmedClosing = false; // reset flag after dialog is closed
                    };
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
