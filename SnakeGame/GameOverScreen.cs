﻿using System;
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

        public GameOverScreen()
        {

            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(GameOverScreen_FormClosing);

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            Program.database.Save(Program.gamescreen.PlayerName,Program.gamescreen.highScore,Program.gamescreen.Finallevel,DateTime.Now);

            this.Close();
        }

        private void PlayAgainbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.gamescreen.Show();
            Program.gamescreen.RestartGame();

        }

        private void ReturntoTSbtn_Click(object sender, EventArgs e)
        {

            //Bezárjuk a "GameOverScreen" formot és mutatjuk a "StartScreen" formot.
            this.Close();
            Program.gamescreen.Close();
            Program.startscreen.Show();

        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {

            FinalScorelbl.Text = "Final Score: " + Program.gamescreen.highScore;
            FinalLevellbl.Text = "Final Level: " + Program.gamescreen.Finallevel;

        }

        private void GameOverScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }

    }
}
