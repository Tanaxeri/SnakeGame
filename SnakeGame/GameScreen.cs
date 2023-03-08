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

namespace SnakeGame
{
    public partial class GameScreen : Form
    {

        private bool userConfirmedClosing = false;


        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        private Circle obstacle = new Circle();

        int maxWidth;
        int maxHeight;

        public string PlayerName { get; set; }
        int score;
        int level;
        public int highScore;
        public int Finallevel;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;

        public GameScreen()
        {
            InitializeComponent();
            this.FormClosing += GameScreen_FormClosing;
            new Settings();

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
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                // Növeli a szintet és akadályokat add.
                if (score >= 10 && rand.Next(100) < level * 10)
                {
                    // Lehív egy adályt.
                    obstacle.X = rand.Next(2, maxWidth);
                    obstacle.Y = rand.Next(2, maxHeight);
                }

                // Megnézi hogy ütközik-e a Snake az akadállyal.
                if (Snake[0].X == obstacle.X && Snake[0].Y == obstacle.Y)
                {
                    GameOver();
                }

                // Megnöveli a szintet minden 10 pontnál
                if (score % 10 == 0 && score > 0 && score % 10 == level * 10)
                {
                    level = score;
                    Levellbl.Text = "Level " + level;
                }
                if (i > 0)
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            gamezone.Invalidate();
        }

        public void RestartGame()
        {
            maxWidth = gamezone.Width / Settings.Width - 1;
            maxHeight = gamezone.Height / Settings.Height - 1;
            Snake.Clear();
            score = 0;
            level = 1;
            Scorelbl.Text = "Score: " + score;
            Levellbl.Text = "Level " + level;

            // Add 4 circles to represent the head and 3 body parts
            for (int i = 0; i < 4; i++)
            {
                Circle circle = new Circle { X = 10 - i, Y = 5 };
                Snake.Add(circle);
            }

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            obstacle = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            GameTimer.Start();
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
                    if (dialog.ShowDialog() == DialogResult.Yes)
                    {
                        userConfirmedClosing = true;
                        Application.Exit();
                    }
                    if(dialog.ShowDialog() == DialogResult.No)
                    {

                        userConfirmedClosing = false;
                        e.Cancel = true;
                        GameTimer.Start();

                    }
                }
            }

        }

    }
}
