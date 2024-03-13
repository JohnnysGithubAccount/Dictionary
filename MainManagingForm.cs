using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class MainManagingForm : Form
    {
        private WordSearcher searcher;
        private WordsLoader loader;
        public List<List<WordsLoader.WordInfo>> listWordInfos;
        List<WordsLoader.WordInfo> flattenList;
        public MainManagingForm()
        {
            InitializeComponent();

            searcher = new WordSearcher();
            searcher.LoadData();

            loader = new WordsLoader();
            loader.loadData();

            listWordInfos = new List<List<WordsLoader.WordInfo>>();
            flattenList = new List<WordsLoader.WordInfo>();

            loadComboBox();

            DisplayData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = filter.SelectedItem.ToString();

            List<WordsLoader.WordInfo> needToShow = new List<WordsLoader.WordInfo>();

            listWordInfos.AddRange(WordsLoader.data.Values.Cast<List<WordsLoader.WordInfo>>());
            foreach (List<WordsLoader.WordInfo> innerWordInfo in listWordInfos)
            {
                foreach (WordsLoader.WordInfo word in innerWordInfo)
                {
                    flattenList.Add(word);
                }
            }

            foreach (WordsLoader.WordInfo wordInfo in flattenList)
            {
                if (wordInfo.WordType == selectedOption)
                {
                    needToShow.Add(wordInfo);
                }
            }

            wordInfosDisplayer.DataSource = needToShow;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            if (row == null)
            {
                MessageBox.Show(
                    "Please choose the word you want to delete in the table before clicking this",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            AddWord addForm = new AddWord("", "", "", "Delete", row);
            addForm.ShowDialog();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            if (row == null)
            {
                MessageBox.Show(
                    "Please choose the word you want to delete in the table before clicking this",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            AddWord addForm = new AddWord("", "", "", "Update", row);
            addForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddWord addForm = new AddWord("", "", "", "Add", null);
            addForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loader.loadDatabaseFromCsv();
        }

        public void loadComboBox()
        {
            List<string> uniqueWordType = WordsLoader.wordTypesForComboBox.Distinct().ToList();
            filter.Items.AddRange(uniqueWordType.ToArray());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBar.Text;

            if (searchText.Length >= 1)
            {
                //MessageBox.Show("Running this", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData( searchText );
            }
            else
            {
                wordInfosDisplayer.DataSource = new List<WordsLoader.WordInfo>();
                DisplayData();
            }

        }

        void DisplayData(string prefix = "")
        {
            if (prefix == "")
            {
                listWordInfos.AddRange(WordsLoader.data.Values.Cast<List<WordsLoader.WordInfo>>());
            }
            else
            {
                //Display word with the prefix
                searcher.UpdateAutoCompleteions(prefix, 0);
                listWordInfos.Clear();
                foreach (string word in WordSearcher.listData)
                {
                    loader.loadDefinitionOf(word);
                    listWordInfos.Add(WordsLoader.infos);
                }
                //MessageBox.Show("Also this", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            flattenList = new List<WordsLoader.WordInfo>();
            //flattenList.Clear();
            foreach (List<WordsLoader.WordInfo> innerWordInfo in listWordInfos)
            {
                foreach (WordsLoader.WordInfo word in innerWordInfo)
                {
                    flattenList.Add(word);
                }
            }
            wordInfosDisplayer.DataSource = flattenList;
            wordInfosDisplayer.Columns[wordInfosDisplayer.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (AddWord.isFinished)
            {
                DisplayData();

                AddWord.isFinished = false;
            }
        }

        private void filter_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void wordInfosDisplayer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void wordInfosDisplayer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        DataGridViewRow row;
        private void wordInfosDisplayer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                row = wordInfosDisplayer.Rows[e.RowIndex];
            }
        }
    }
}
