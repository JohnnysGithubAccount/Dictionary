using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public class WordSearcher
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\UsingSpace\Programing Languages Learning\C# Programming\HCMUTE Projects\DataStructureAndAlgorithm\Dictionary\DictionaryApplication.mdf"";Integrated Security=True;Connect Timeout=30";
        private string tableName = "entries";

        public static Trie data;
        public static List<string> listData;
        public WordSearcher()
        {
        }

        static WordSearcher()
        {
            data = new Trie();
            listData = new List<string>();
        }
        public void LoadData()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string query = $"SELECT word FROM {tableName}";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string spelling = reader.GetString(0);
                            data.Insert(spelling);
                        }
                        //reader.Close();
                    }
                    //cmd.Dispose();
                }
                //connect.Close();
            }
        }

        public void UpdateAutoCompleteions(string prefix, int numSuggest = 5)
        {
            listData = data.GetListStartWith(prefix);
            if (numSuggest > 0)
            {
                try
                {
                    listData = listData.GetRange(0, numSuggest);
                }
                catch (Exception ex)
                {
                    return;
                }
            } 
            else if (numSuggest == 0)
            {
                return;
            }
        }
    }
}
