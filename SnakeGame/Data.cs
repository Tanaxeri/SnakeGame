using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace SnakeGame
{
    internal class Data
    {

        List<Snake> snake = new List<Snake>();

        internal List<Snake> Snake { get => snake; set => snake = value; }

        public Data(string forras)
        {

            try
            {

                using (StreamReader sr = new StreamReader(forras))
                {

                    while (!sr.EndOfStream)
                    {

                        int ID = int.Parse(sr.ReadLine());
                        string PlayerName = sr.ReadLine();
                        int Score = int.Parse(sr.ReadLine());
                        int Level = int.Parse(sr.ReadLine());
                        DateTime Date = DateTime.Parse(DateTime.Now.ToString("yyyyMMddHHmm"));
                        string[] sor = sr.ReadLine().Split(';');
                        string ujSor = string.Empty;
                        while ((ujSor = sr.ReadLine()) != "" && ujSor != null)
                        {

                            sor = ujSor.Split(';');

                        }
                        snake.Add(new Snake(ID, PlayerName, Score, Level, Date));

                    }

                }

            }
            catch (IOException ex)
            {

                MessageBox.Show(ex.Message + "\n\nA program leáll!");
                Environment.Exit(0);

            }

        }

        public void Mentes()
        {
            string original = "snakegamedb.csv";
            string output = "Backup_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";
            try
            {
                File.Copy(original, output, true);
                using (StreamWriter sw = new StreamWriter(original))
                {
                    


                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message + "\nA mentés sikertelen!");
                return;
            }
            MessageBox.Show("Az adatok mentése sikeres!");
        }

    }
}
