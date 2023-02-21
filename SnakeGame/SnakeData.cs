using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class SnakeData
    {

        string playerName;
        int score;
        int level;

        public string PlayerName { get => playerName; set => playerName = value; }
        public int Score { get => score; set => score = value; }
        public int Level { get => level; set => level = value; }

        public SnakeData(string playerName, int score, int level)
        {
            PlayerName = playerName;
            Score = score;
            Level = level;
        }
    }
}
