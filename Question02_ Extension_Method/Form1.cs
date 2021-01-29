using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question02__Extension_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //initialize the input text
            inputText.Text = "This is to test whether the extension method count can return a right answer or not";
        }

        /// <summary>
        /// click button to calculate the number of words of a sentence entered by a user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (inputText.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a sentence first");
                inputText.Focus();
                return;
            }
            StringBuilder sb = new StringBuilder(inputText.Text);
            int count = sb.WordsCounter();
            MessageBox.Show($"The number of words contained in this sentence is {count}");
            inputText.Text = "";
        }
    }
}
