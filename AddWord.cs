using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Dictionary.WordsLoader;

namespace Dictionary
{
    public partial class AddWord : Form
    {
        public string spelling, wordClass, definition;
        public DataGridViewRow row;
        public static bool isFinished = false;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\UsingSpace\Programing Languages Learning\C# Programming\HCMUTE Projects\DataStructureAndAlgorithm\Dictionary\DictionaryApplication.mdf"";Integrated Security=True;Connect Timeout=30";


        private void AddWord_Load(object sender, EventArgs e)
        {
            string isDisplay = "display";
            if (addBtn.Text == "Add")
            {
                AddNewWord(isDisplay);
            }
            else if (addBtn.Text == "Update")
            {
                UpdateWord(isDisplay);
            }
            else if (addBtn.Text == "Delete")
            {
                DeleteWord(isDisplay);
            }
        }

        public AddWord(string spellingInput = "", string wordClassInput = "",
            string definitionInput = "", string addBtnText = "", DataGridViewRow rowInput = null)
        {
            InitializeComponent();

            spelling = spellingInput;
            wordClass = wordClassInput;
            definition = definitionInput;
            addBtn.Text = addBtnText;
            row = rowInput;

        }

        private void addSpelling_TextChanged(object sender, EventArgs e)
        {

        }

        public void AddNewWord(string display)
        {
            if (display == "click")
            {
                if (addSpelling.Text == ""
                    || addWordClass.Text == ""
                    || addDefinition.Text == "")
                {
                    MessageBox.Show(
                        "Please fill in all the blanks",
                        "Error Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        string insert = "INSERT INTO entries (word, wordtype, definition) VALUES " +
                            "(@word, @wordtype, @definition)";

                        using (SqlCommand command = new SqlCommand(insert, connect))
                        {
                            command.Parameters.AddWithValue("@word", addSpelling.Text);
                            command.Parameters.AddWithValue("@wordtype", addWordClass.Text);
                            command.Parameters.AddWithValue("@definition", addDefinition.Text);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show(
                            "Added successfully",
                            "Error Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                string word = addSpelling.Text;
                string wordType = addWordClass.Text;
                string definition = addDefinition.Text;

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

                isFinished = true;
            }
            else if (display == "display")
            {
                return;
            }
        }

        public bool isClicked = false;
        private void addBtn_Click(object sender, EventArgs e)
        {
            isClicked = true;
        }

        public void UpdateWord(string display)
        {

            string savedWordClass = "";
            string savedDefinition = "";

            if (display == "display")
            {
                addSpelling.Text = row.Cells[0].Value.ToString();
                addWordClass.Text = row.Cells[1].Value.ToString();
                addDefinition.Text = row.Cells[2].Value.ToString();


                savedWordClass = addWordClass.Text;
                savedDefinition = addDefinition.Text;
            }
            else if (display == "click")
            {
                List<WordInfo> values = (List<WordInfo>)data[addSpelling.Text];
                int index = values.FindIndex(x => x.Definition == addDefinition.Text && x.WordType == addWordClass.Text);

                if (index >= 0)
                {
                    values[index].WordType = savedWordClass;
                    values[index].Definition = savedDefinition;
                }

                //update in the database
                isFinished = true;
            }
        }

        public void DeleteWord(string display)
        {
            string savedWordClass = "";
            string savedDefinition = "";

            if (display == "display")
            {
                addSpelling.Text = row.Cells[0].Value.ToString();
                addWordClass.Text = row.Cells[1].Value.ToString();
                addDefinition.Text = row.Cells[2].Value.ToString();


                savedWordClass = addWordClass.Text;
                savedDefinition = addDefinition.Text;
            }
            else if (display == "click")
            {
                List<WordInfo> values = (List<WordInfo>)data[addSpelling.Text];
                WordInfo objectToRemove = values.FirstOrDefault(items => items.Definition == savedDefinition && items.WordType == savedWordClass);

                if (objectToRemove != null)
                {
                    values.Remove(objectToRemove);
                }

                if (!data.ContainsKey(addSpelling.Text))
                {
                    //Remove from the trie

                }

                //remove from the database

                isFinished = false;
            }
            
        }
    }
}
