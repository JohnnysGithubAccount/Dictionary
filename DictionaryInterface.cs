using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Dictionary
{
    public partial class DictionaryInterface : UserControl
    {
        private WordSearcher searcher;
        private WordsLoader loader;
        public DictionaryInterface()
        {
            InitializeComponent();

            searcher = new WordSearcher();
            searcher.LoadData();

            loader = new WordsLoader();
            loader.loadData();

            word.Text = "";
        }

        public static Stack<string> undoStack;
        public static Stack<string> redoStack;

        static DictionaryInterface()
        {
            undoStack = new Stack<string>();
            redoStack = new Stack<string>();
        }    

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void DisplayData()
        {
            foreach (string suggestion in WordSearcher.listData)
            {
                searchResult res = new searchResult();
                res.details(suggestion);
                resultContainer.Controls.Add(res);
            }
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBar.Text;
            if (searchText.Length >= 1)
            {

                resultContainer.Controls.Clear();
                searchResult res = new searchResult();
                res.updateSearchResult(searchText);
                //MessageBox.Show(searchResult.staticWord, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                resultContainer.Height = resultContainer.Controls.Count * 70;
            }
            else
            {
                resultContainer.Height = 0;
            }
        }

        private void DictionaryInterface_Load(object sender, EventArgs e)
        {
            
        }

        private void result_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void definitionContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void word_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (searchResult.clicked == true && searchResult.staticWord != null)
            {
                DisplaySearchResutl();
            }
            else if (searchResult.staticWord == null || searchResult.staticWord == "")
            {
                //MessageBox.Show(searchResult.staticWord, "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            searchResult.clicked = false;
        }

        public void DisplaySearchResutl()
        {
            searchBar.Text = string.Empty;
            string currWord = searchResult.staticWord;
            resultContainer.Controls.Clear();

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            word.Text = textInfo.ToTitleCase(currWord);
            loader.loadDefinitionOf(currWord);

            string finalText = string.Empty;

            if (WordsLoader.infos != null)
            {
                foreach (WordsLoader.WordInfo wordInfo in WordsLoader.infos)
                {
                    finalText += wordInfo.ToString() + Environment.NewLine;
                }
            }
            definitionsDisplayer.Text = finalText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                string theWord = redoStack.Pop();
                PerformSearching(theWord);
                undoStack.Push(theWord);
            }
            else
            {
                MessageBox.Show("Have't got any word in the redo yet", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                string thePreviousWord = undoStack.Pop();

                PerformSearching(thePreviousWord);

                redoStack.Push(thePreviousWord);
            }
            else
            {
                MessageBox.Show("Have't got any word in the undo yet", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PerformSearching(string currWord)
        {
            searchBar.Text = string.Empty;
            resultContainer.Controls.Clear();
            definitionsDisplayer.Text = "";

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            word.Text = textInfo.ToTitleCase(currWord);
            loader.loadDefinitionOf(currWord);

            string finalText = "";

            if (WordsLoader.infos != null)
            {
                foreach (WordsLoader.WordInfo wordInfo in WordsLoader.infos)
                {
                    finalText += wordInfo.ToString() + Environment.NewLine;
                }
            }
            definitionsDisplayer.Text = finalText;
        }
    }
}
