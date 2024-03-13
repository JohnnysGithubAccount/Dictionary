using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Markup;
using System.IO.IsolatedStorage;

namespace Dictionary
{
    public class WordsLoader
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\UsingSpace\Programing Languages Learning\C# Programming\HCMUTE Projects\DataStructureAndAlgorithm\Dictionary\DictionaryApplication.mdf"";Integrated Security=True;Connect Timeout=30";
        private string csvPath = @"D:\UsingSpace\Programing Languages Learning\C# Programming\HCMUTE Projects\DataStructureAndAlgorithm\Dictionary\Database\english Dictionary.csv";
        private string tableName = "entries";

        public static Hashtable data;
        public static List<WordInfo> infos;
        public static List<string> wordTypesForComboBox;

        static WordsLoader()
        {
            data = new Hashtable();
            infos = new List<WordInfo>();
            wordTypesForComboBox = new List<string>();
        }
        public WordsLoader()
        {

        }

        public class WordInfo
        {
            public string Spelling { set; get; }
            public string WordType { set; get; }
            public string Definition { set; get; }

            public override string ToString()
            {
                return $"{WordType}{Environment.NewLine}{Definition}{Environment.NewLine}";
            }
        }

        public void loadDatabaseFromCsv()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                using (SqlCommand cmd = connect.CreateCommand())
                {
                    string query = $"DELETE FROM {tableName}";
                    cmd.CommandText = query;

                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand cmd = connect.CreateCommand())
                {
                    string insertQuery = $"INSERT INTO {tableName} (word, wordtype, definition) VALUES (@word, @wordtype, @definition)";

                    cmd.CommandText = insertQuery;

                    using (StreamReader reader = new StreamReader(csvPath))
                    {
                        string line;
                        
                        while ((line = reader.ReadLine()) != null)
                        {
                            try
                            {
                                string[] values = line.Split(',');
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@word", values[0]);
                                cmd.Parameters.AddWithValue("@wordtype", values[1]);
                                cmd.Parameters.AddWithValue("@definition", values[2]);

                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                continue;
                            }

                        }
                    }
                }
            }
            MessageBox.Show(
                "Successfully added data from csv file to sql database",
                "Information Message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void loadData()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string query = $"SELECT * FROM {tableName}";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string word = reader.GetString(0);
                            string wordType = reader.GetString(1);
                            string definition = reader.GetString(2).Trim('"');

                            if (data.ContainsKey(word))
                            {
                                List<WordInfo> values = (List<WordInfo>)data[word];
                                values.Add(new WordInfo { WordType = wordType, Definition = definition, Spelling = word });
                                data[word] = values;
                            }
                            else
                            {
                                List<WordInfo> values = new List<WordInfo> { new WordInfo { WordType = wordType, Definition = definition, Spelling = word } };
                                data.Add(word, values);
                            }

                            wordTypesForComboBox.Add(wordType);
                        }
                    }
                }
            }
        }

        public void loadDefinitionOf(string wordInput)
        {
            infos = (List<WordInfo>)data[wordInput];

            data[wordInput] = infos;
        }
    }
}
