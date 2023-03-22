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
        static public Data data = null;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startscreen = new StartScreen();                                
            gamescreen = new GameScreen();
            gameoverscreen = new GameOverScreen();            
            leaderboardscreen = new LeaderboardScreen();
            pausescreen = new PauseScreen();
            database = new Database("localhost", "root", "", "snakegamedb");
            data = new Data("snakegamedb.csv");

            startscreen.Show();

            Application.Run();
        }
    }
}
