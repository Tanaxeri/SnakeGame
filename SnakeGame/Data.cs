using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.VisualBasic.FileIO;
using System.Reflection.Emit;

namespace SnakeGame
{
    internal class Data
    {

        List<Snake> snake = new List<Snake>();
        internal List<Snake> Snake { get => snake; set => snake = value; }

        private string dataContent;

        public string DataContent { get => dataContent; set => dataContent = value; }

        public Data(string forras)
        {
            try
            {
                using (TextFieldParser parser = new TextFieldParser(forras))
                {
                    // Set the delimiter of the CSV file
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    // Skip the header row
                    parser.ReadLine();

                    while (!parser.EndOfData)
                    {
                        // Read each line as an array of fields
                        string[] fields = parser.ReadFields();

                        // Parse the fields as needed
                        int ID;
                        if (!int.TryParse(fields[0], out ID))
                        {
                            MessageBox.Show("Id Hiba");// handle the error here, e.g. by logging it or displaying a message to the user
                            continue; // skip this line and continue with the next line
                        }

                        string PlayerName = fields[1];

                        int Score;
                        if (!int.TryParse(fields[2], out Score))
                        {
                            MessageBox.Show("Score Hiba");// handle the error here, e.g. by logging it or displaying a message to the user
                            continue; // skip this line and continue with the next line
                        }

                        int Level;
                        if (!int.TryParse(fields[3], out Level))
                        {
                            MessageBox.Show("Level Hiba");// handle the error here, e.g. by logging it or displaying a message to the user
                            continue; // skip this line and continue with the next line
                        }

                        DateTime Date;
                        if (!DateTime.TryParseExact(fields[4], "yyyy.MM.dd", null, DateTimeStyles.None, out Date))
                        {
                            MessageBox.Show("Date Hiba");// handle the error here, e.g. by logging it or displaying a message to the user
                            continue; // skip this line and continue with the next line
                        }

                        snake.Add(new Snake(ID, PlayerName, Score, Level, Date));
                        
                    }

                    string dataContent = "";
                    foreach (Snake s in snake)
                    {
                        dataContent += s.Playername + "," + s.Score + "," + s.Level + "\n";
                    }
                    DataContent = dataContent;

                }
                
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message + "\n\nA program leáll!");
                Environment.Exit(0);
            }
        }

        public void Mentes(string playerName, int score, int level)
        {
            string filename = "snakegamedb.csv";
            string backupFilename = "Backup_" + DateTime.Now.ToString("yyyy.MM.dd") + ".csv";

            try
            {
                // Make a backup of the original file
                File.Copy(filename, backupFilename, true);

                // Generate the data to be saved
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                int id = File.ReadAllLines(filename).Length + 1;
                string dataLine = $"{id},{playerName},{score},{level},{timestamp}";

                // Open the file in a FileStream
                using (FileStream fs = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.None))
                {
                    // Write the data to the file
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(dataLine);
                    }
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
