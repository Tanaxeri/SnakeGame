using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.VisualBasic.FileIO;
using System.Reflection.Emit;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

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
                using (var reader = new StreamReader(forras))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {

                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        Delimiter = ",",
                        HasHeaderRecord = true,
                        IgnoreBlankLines = true,
                        BadDataFound = context =>
                        {
                            MessageBox.Show($"Error parsing data: {context.RawRecord}");
                        }
                    };
                    var records = csv.GetRecords<dynamic>();
                    foreach (var record in records)
                    {
                        try
                        {
                            int id;
                            if (!int.TryParse((string)record.ID, out id))
                            {
                                throw new Exception("Invalid score value");
                            }
                            string playerName = (string)record.PlayerName;
                            int score;
                            if (!int.TryParse((string)record.Score, out score))
                            {
                                throw new Exception("Invalid score value");
                            }
                            int level;
                            if (!int.TryParse((string)record.Level, out level))
                            {
                                throw new Exception("Invalid score value");
                            }
                            DateTime date = DateTime.ParseExact((string)record.Date, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                            if (id <= 0 || score < 0 || level < 0 || date > DateTime.Now)
                            {
                                throw new Exception("Invalid data"); // throw an exception for invalid data
                            }

                            snake.Add(new Snake(id, playerName, score, level, date));
                        }
                        catch (Exception ex)
                        {
                            // handle the exception here, e.g. by logging it or displaying a message to the user
                            MessageBox.Show($"Error parsing data: {ex.Message}");
                        }
                    }

                    var topScores = snake.OrderByDescending(s => s.Score).Take(10);

                    string dataContent = string.Join("\n", topScores.Select(s => $"Playername: {s.Playername}, Score: {s.Score}, Level: {s.Level}"));
                    DataContent = dataContent;
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
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
                DateTime timestamp = DateTime.Now;
                int id = File.ReadAllLines(filename).Length + 1;
                Snake newSnake = new Snake(id, playerName, score, level, timestamp);

                // Write the data to the file and add the newSnake object to the list
                using (var writer = new StreamWriter(filename, true))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecord(newSnake);
                    Snake.Add(newSnake);
                }

                var topScores = Snake.OrderByDescending(s => s.Score).Take(10);

                string dataContent = string.Join("\n", topScores.Select(s => $"Playername: {s.Playername}, Score: {s.Score}, Level: {s.Level}"));
                DataContent = dataContent;
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
