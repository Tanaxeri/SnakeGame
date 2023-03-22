using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Snake
    {

        protected int id;
        protected string playername;
        protected int score;
        protected int level;
        protected DateTime date;

        public int Id { get => id; set => id = value; }
        public string Playername { get => playername; set => playername = value; }
        public int Score { get => score; set => score = value; }
        public int Level { get => level; set => level = value; }
        public DateTime Date { get => date; set => date = value; }

        public Snake(int id, string playername, int score, int level, DateTime date)
        {
            this.id = id;
            this.playername = playername;
            this.score = score;
            this.level = level;
            this.date = date;
        }


    }
}
