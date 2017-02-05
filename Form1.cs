using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchMistakesInText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            List<string> words = new List<string>();
            List<string> wrongWords = new List<string>();

            foreach (string word in textBox.Text.Split(' '))
            {
                words.Add(word);
            }

            foreach(string word in words)
            {
                if (!Program.wordslist.Contains(word))
                    wrongWords.Add(word);
            }

            foreach(string word in words)
            {
                foreach(string wrongWord in wrongWords)
                {
                    if (word == wrongWord)
                    {
                        int index = textBox.Text.IndexOf(word);
                        textBox.Select(index, word.Length);
                        textBox.SelectionFont = new Font(textBox.SelectionFont, FontStyle.Underline);
                    }
                }
            }
            /*
                for (int i = 0; i < wrongWords.Count; i += 1)
            {
                    int index = textBox.Text.IndexOf(wrongWords[i]);

                    textBox.Select(index, wrongWords[i].Length);
                    textBox.SelectionFont = new Font(textBox.SelectionFont, FontStyle.Underline);
                    
            }*/
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
            textBox.SelectionFont = new Font(textBox.SelectionFont, FontStyle.Regular);
        }

        
    }
}
