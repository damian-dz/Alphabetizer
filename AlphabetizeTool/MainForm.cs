using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AlphabetizeTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string[] RemoveEmptyLines(string[] lines)
        {
            List<string> lineList = lines.ToList();
            int index = 0;
            while (index < lineList.Count)
            {
                if (string.IsNullOrWhiteSpace(lineList[index]))
                {
                    lineList.RemoveAt(index--);
                }
                index++;
            }
            return lineList.ToArray();
        }

        private void RichTextBoxTextChanged(object sender, EventArgs e)
        {
            alphabetizeButton.Enabled = richTextBox.Lines.Length > 0 &&
            !string.IsNullOrWhiteSpace((richTextBox.Lines[0]));
        }

        private void AlphabetizeButtonClick(object sender, EventArgs e)
        {
            string[] lines = richTextBox.Lines;
            lines = RemoveEmptyLines(lines);
            Array.Sort(lines);
            richTextBox.Lines = lines;
            richTextBox.Focus();
            richTextBox.SelectAll();
        }
    }
}
