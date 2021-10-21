using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Book_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

        }

        private string[] pages;

        private int pageCount;

        private void generateBtn_Click(object sender, EventArgs e)
        {
            pageCount = 1;
            outputTextBox.Text = "";

            string[] storyString = inputTextBox.Text.Split(' ');

            outputTextBox.Text += "\tPage " + (1) + "\n\n";
            string pageString = "";
            
            int extraCounter = 0;
            for (int i = 0; i < storyString.Count(); i++)
            {



                pageString += storyString[i] + " ";

                if (pageString.Length >= 265)
                {

                    outputTextBox.Text += pageString + "\n\n";

                    pageString = "";
                    outputTextBox.Text += "\n\n\tPage " + (++pageCount) + "\n\n";

                    extraCounter = (i + 1);
                }



                //while (pageString.Length <= 180)
                //{
                //    pageString += storyString[i];
                //}


            }

            for ( int i = 0;  extraCounter < storyString.Count(); extraCounter++)
            {


                outputTextBox.Text += storyString[extraCounter] + " ";

            }


            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add your text into the input box\nThen hit the generate button\nif you want to add more text use teh 'Add Text' button\niif you hit generate you will delete all text in the outputbox\n", "How to Use");

        }

        private void addTextBtn_Click(object sender, EventArgs e)
        {
            string[] storyString = inputTextBox.Text.Split(' ');

            outputTextBox.Text += "\n\n\tPage " + (++pageCount) + "\n\n";
            string pageString = "";
            
            int extraCounter = 0;
            for (int i = 0; i < storyString.Count(); i++)
            {



                pageString += storyString[i] + " ";

                if (pageString.Length >= 265)
                {

                    outputTextBox.Text += pageString + "\n\n";

                    pageString = "";
                    outputTextBox.Text += "\n\n\tPage " + (++pageCount) + "\n\n";

                    extraCounter = (i + 1);
                }



                //while (pageString.Length <= 180)
                //{
                //    pageString += storyString[i];
                //}


            }

            for (int i = 0; extraCounter < storyString.Count(); extraCounter++)
            {


                outputTextBox.Text += storyString[extraCounter] + " ";

            }
        }
    }
}
