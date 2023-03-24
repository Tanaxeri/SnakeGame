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

        private bool userConfirmedClosing;

        public StartScreen()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.VisibleChanged += StartScreen_VisibleChanged;
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

            CenterToScreen();

        }

        private void StartScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                userConfirmedClosing = false; // reset userConfirmedClosing flag
            }
        }

        private void Leaderboardbtn_Click(object sender, EventArgs e)
        {
            //Bezárjuk a "StartScreen" formot és mutatjuk az  'új' "LeaderboardScreen" formot.
            var leaderboardscreen = new LeaderboardScreen();
            leaderboardscreen.Show();
            userConfirmedClosing = true;
            this.Close();          

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
                    userConfirmedClosing = true;
                    this.Close();                

                }
            }

        }

        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !userConfirmedClosing)
            {
                e.Cancel = true;

                using (var dialog = new CloseScreen())
                {
                    dialog.FormClosed += (s, args) => {
                        userConfirmedClosing = false; // reset flag after dialog is closed
                    };
                    this.FormClosing -= StartScreen_FormClosing; // remove event handler
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
                    this.FormClosing += StartScreen_FormClosing; // re-add event handler
                }
            }
        }
       
    }
}
