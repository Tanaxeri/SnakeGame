using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    internal static class Program
    {

        static public StartScreen startscreen = null;
        static public GameScreen gamescreen = null;
        static public GameOverScreen gameoverscreen = null;
        static public LeaderboardScreen leaderboardscreen = null;
        static public PauseScreen pausescreen = null;
        static public Database database = null;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            database = new Database("localhost", "root", "", "snakegamedb");
            pausescreen = new PauseScreen();
            gameoverscreen = new GameOverScreen();
            gamescreen = new GameScreen();
            leaderboardscreen = new LeaderboardScreen();
            startscreen = new StartScreen();

            startscreen.Show();

            Application.Run();
        }
    }
}
