using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public class TrieNode
    {
        public char Character { get; set; }
        public bool IsWord { get; set; }
        public TrieNode[] Children;
        public TrieNode(char c)
        {
            Character = c;
            IsWord = false;
            Children = new TrieNode[26];
        }
    }

    public class Trie
    {
        public TrieNode Root;

        public Trie()
        {
            Root = new TrieNode('\0');
        }

        public void Insert(string word)
        {
            TrieNode curr = Root;
            for (int i = 0; i<word.Length; i++)
            {
                char c = word[i];
                int index = c - 'a';
                if (curr.Children[index] == null)
                {
                    curr.Children[index] = new TrieNode(c);
                }
                curr = curr.Children[index];
            }
            curr.IsWord = true;
        }

        public void GetWords(TrieNode currentNode, List<string> suggestions, string currenPrefix)
        {
            if (currentNode.IsWord)
            {
                suggestions.Add(currenPrefix);
            }
            for (int i = 0; i < currentNode.Children.Length; i++)
            {
                if (currentNode.Children[i] != null)
                {
                    GetWords(currentNode.Children[i], suggestions, currenPrefix + currentNode.Children[i].Character);
                }
            }
        }

        public List<string> GetListStartWith(string prefix)
        {
            List<string> suggestions = new List<string>();
            TrieNode node = Root;
            int index;

            for (int i = 0; i < prefix.Length; i++)
            {
                char c = prefix[i];
                index = c - 'a';
                if (index < 0)
                {
                    return suggestions;
                }
                if (node.Children[index] == null)
                {
                    return suggestions; //No such word started with the prefix so return an empty list
                }
                node = node.Children[index];
            }
            GetWords(node, suggestions, prefix);
            return suggestions;
        }
    }
}
