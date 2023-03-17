using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Drawing.Imaging;
using System.Reflection.Emit;

namespace SnakeGame
{
    public partial class GameScreen : Form
    {

        private bool userConfirmedClosing;

        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        private List<Circle> obstacles = new List<Circle>();

        int maxWidth;
        int maxHeight;

        public string PlayerName { get; set; }
        int score;
        int level;
        public int highScore;
        public int Finallevel;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;

        public bool hasMoved;

        public GameScreen()
        {
            InitializeComponent();
            new Settings();
            this.VisibleChanged += GameScreen_VisibleChanged;

        }

        private void GameScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                userConfirmedClosing = false; // reset userConfirmedClosing flag
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left && Settings.directions != "right" || e.KeyCode == Keys.A && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left" || e.KeyCode == Keys.D && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down" || e.KeyCode == Keys.W && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up" || e.KeyCode == Keys.S && Settings.directions != "up")
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Escape)
            {

                GameTimer.Stop();
                Program.pausescreen.ShowDialog();

            }

        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = false;
            }

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // irányok beállítása.
            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            // írányok vége.
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }
                    if (Snake[i].X < 0 || Snake[i].X > maxWidth || Snake[i].Y < 0 || Snake[i].Y > maxHeight)
                    {
                        GameOver();
                    }

                    if (hasMoved)
                    {
                        for (int j = 1; j < Snake.Count; j++)
                        {
                            if (Snake[0].X == Snake[j].X && Snake[0].Y == Snake[j].Y)
                            {
                                GameOver();
                            }
                        }
                    }

                    hasMoved = true;

                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }
                }

                if (i > 0)
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            // Ellenőrzi, hogy a 'Snake' ütközik-e valamelyik akadállyal.
            foreach (var obs in obstacles)
            {
                if (obs != null && Snake[0].X == obs.X && Snake[0].Y == obs.Y)
                {
                    GameOver();
                }
            }

            if (score % 5 == 0 && score > 0 && score > level * 5)
            {
                level++;
                Levellbl.Text = "Level " + level;

                // Létrehoz új akadályokat, ha a pontszám 10 vagy ha a pontszám 10 többszöröse.
                if (score == 5 || score % 5 == 0)
                {
                    CreateObstacle();
                }
                if (score == 10 || score % 10 == 0)
                {
                    CreateObstacle();
                    CreateObstacle();
                }
            }

            gamezone.Invalidate();
        }

        // Segítő metódus az akadályok készítésére.
        private void CreateObstacle()
        {
            // Adjon egy új akadályt az osztályhoz.
            obstacles.Add(new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) });
        }
        public void RestartGame()
        {
            maxWidth = gamezone.Width / Settings.Width - 1;
            maxHeight = gamezone.Height / Settings.Height - 1;
            Snake.Clear();
            obstacles.Clear();
            score = 0;
            level = 1;
            Scorelbl.Text = "Score: " + score;
            Levellbl.Text = "Level " + level;

            int middleX = maxWidth / 2;
            int middleY = maxHeight / 2;

            // Hozzáad 4 kört a fej és 3 testrész ábrázolására
            for (int i = 0; i < 4; i++)
            {
                Circle circle = new Circle { X = middleX - i, Y = middleY };
                Snake.Add(circle);
            }

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            CreateObstacle();

            GameTimer.Start();
            hasMoved = false;
        }

        private void UpdateGameGraphics(object sender, PaintEventArgs e)
        {

            Graphics canvas = e.Graphics;
            Brush snakeColour;
            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.DarkGreen;
                }
                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }
            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            food.X * Settings.Width,
            food.Y * Settings.Height,
            Settings.Width, Settings.Height
            ));
            for( int i = 0; i < obstacles.Count; i++) 
            { 
                canvas.FillEllipse(Brushes.Yellow, new Rectangle
                (
                obstacles[i].X * Settings.Width,
                obstacles[i].Y * Settings.Height,
                Settings.Width, Settings.Height
                ));
            }


        }

        private void EatFood()
        {
            score += 1;
            Scorelbl.Text = "Score: " + score;
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(body);
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }
        private void GameOver()
        {

           GameTimer.Stop();
           GameTimer.Dispose();
           highScore = score;
           Finallevel = level;
           Program.gameoverscreen.ShowDialog();

        }

        private void GameScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            GameTimer.Stop();
            GameTimer.Dispose();

            if (e.CloseReason == CloseReason.UserClosing && !userConfirmedClosing)
            {
                e.Cancel = true;

                using (var dialog = new CloseScreen())
                {
                    dialog.FormClosed += (s, args) => {
                        userConfirmedClosing = false; // reset flag after dialog is closed
                    };
                    this.FormClosing -= GameScreen_FormClosing; // remove event handler
                    var result = dialog.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        userConfirmedClosing = true;
                        Application.Exit();
                    }
                    else if (result == DialogResult.No)
                    {
                        userConfirmedClosing = false;
                        GameTimer.Start();
                    }
                    this.FormClosing += GameScreen_FormClosing; // re-add event handler
                }
            }

        }

    }
}
