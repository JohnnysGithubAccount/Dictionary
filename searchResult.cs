using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class searchResult : UserControl
    {
        public searchResult()
        {
            InitializeComponent();
        }

        public string temp_word = "";
        public static string staticWord = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchResult_Load(object sender, EventArgs e)
        {

        }

        public void details(string prefix)
        {
           wordDisplayer.Text = prefix;
        }

        public void updateSearchResult(string word)
        {
            WordSearcher searcher = new WordSearcher();
            searcher.UpdateAutoCompleteions(word); //update the recommendations list
            wordDisplayer.Text = word;
            temp_word = word;
            //searchResult.staticWord = temp_word;
        }

        public static bool clicked = false;
        private void searchResult_MouseClick(object sender, MouseEventArgs e)
        {
            string currentWord = wordDisplayer.Text;
            clicked = true;
            DictionaryInterface.undoStack.Push(currentWord);
            searchResult.staticWord = currentWord;
        }


        private void searchResult_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void searchResult_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void searchResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //string currentWord = wordDisplayer.Text;
            //clicked = true;
            //staticWord = temp_word;
        }
    }
}
