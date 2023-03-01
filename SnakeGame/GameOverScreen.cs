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
    public partial class GameOverScreen : Form
    {
        public GameOverScreen()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(GameOverScreen_FormClosing);
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

           

        }

        private void PlayAgainbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.gamescreen.RestartGame();

        }

        private void ReturntoTSbtn_Click(object sender, EventArgs e)
        {

            //Elrejtjük a "GameOverScreen" formot és mutatjuk a "StartScreen" formot.
            this.Hide();
            Program.gamescreen.Hide();
            Program.startscreen.Show();

        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {

            FinalScorelbl.Text = "Final Score: " + Program.gamescreen.highScore;
            //FinalLevellbl.Text = "Final Level: " + ;

        }

        private void GameOverScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }

    }
}
