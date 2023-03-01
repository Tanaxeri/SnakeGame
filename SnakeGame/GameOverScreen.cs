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
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

           

        }

        private void PlayAgainbtn_Click(object sender, EventArgs e)
        {

            Program.gamescreen.RestartGame();

        }

        private void ReturntoTSbtn_Click(object sender, EventArgs e)
        {

            //bezárjuk a "GameOverScreen" formot és mutatjuk a "StartScreen" formot.
            this.Close();
            Program.startscreen.Show();

        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {

            FinalScorelbl.Text = "Final Score: " + Program.gamescreen.highScore;
            //FinalLevellbl.Text = "Final Level: " + ;

        }
    }
}
