using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    internal class Database
    {

        private MySqlConnection sqlconnection;
        private MySqlCommand sqlcommand;
        private string errorMessage = null;

        public Database(string host, string user, string password, string database)
        {

            MySqlConnectionStringBuilder stringbuilder = new MySqlConnectionStringBuilder();
            stringbuilder.Server = host;
            stringbuilder.UserID = user;
            stringbuilder.Password = password;
            stringbuilder.Database = database;
            sqlconnection = new MySqlConnection(stringbuilder.ConnectionString);
            sqlcommand = sqlconnection.CreateCommand();

        }
        //Írunk 2 metódust hogy nyissa és zárja az adatbázishoz való csatlakozást és ha hiba van akkor jelezze.
        private bool databaseOpen()
        {

            try
            {

                if (sqlconnection.State != System.Data.ConnectionState.Open)
                {

                    sqlconnection.Open();

                }

            }
            catch (MySqlException ex)
            {

                errorMessage = ex.Message;
                return false;

            }

            return true;
        }
        private bool databaseClose()
        {

            try
            {

                if (sqlconnection.State != System.Data.ConnectionState.Closed)
                {

                    sqlconnection.Close();

                }

            }
            catch (MySqlException ex)
            {

                errorMessage = ex.Message;
                return false;

            }

            return true;
        }

        public string GetLeaderboard()
        {
            //felveszünk egy string típusú változót.
            string leaderboard = "";
            //Lefutattjuk hogy az adatbázisból vegye ki a top 10, játékos nevét, eredményét és hogy melyik szintet érte el.
            sqlcommand = new MySqlCommand("SELECT PlayerName, Score, Level FROM playerscores ORDER BY Score DESC LIMIT 10", sqlconnection);
            //ellenőrizzük hogy nyitva van-e a kapcsolat és ha igen akkor lefut.
            if (databaseOpen())
            {

                using (MySqlDataReader reader = sqlcommand.ExecuteReader())
                {
                    //formáljuk az adatot string ként
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("---------------------------------------");
                    while (reader.Read())
                    {

                        sb.AppendLine(string.Format("{0}: Score={1}, Level={2}", reader["PlayerName"], reader["Score"], reader["Level"]));

                    }
                    reader.Close();
                    leaderboard = sb.ToString();
                }


            }
            else
            {

                MessageBox.Show(errorMessage);

            }
            //bezárjuk a kapcsolatot.
            databaseClose();

            return leaderboard;
        }

        public bool Save()
        {

            if(databaseOpen()) 
            {
               string playerName = Program.gamescreen.PlayerName;
               int score = Program.gamescreen.highScore;
               DateTime datePlayed = DateTime.Now;
               sqlcommand = new MySqlCommand("INSERT INTO playerscores (PlayerName, Score, Date) VALUES (@PlayerName, @Score, @DatePlayed)");
               sqlcommand.Parameters.Clear();
               sqlcommand.Parameters.AddWithValue("@PlayerName", playerName);
               sqlcommand.Parameters.AddWithValue("@Score", score);
               sqlcommand.Parameters.AddWithValue("@DatePlayed", datePlayed);
               

            }
            else
            {

                MessageBox.Show(errorMessage);
                return false;

            }
            //bezárjuk a kapcsolatot.
            databaseClose();

            return true;
        }

    }
}
