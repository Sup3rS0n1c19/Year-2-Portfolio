using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VowelOrConsonant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variables

            string letter;

            //Input letter

            letter = txtLetter.Text;

            //Checking the letter

            switch (letter)
            {

                case "a":
                    txtLetterResult.Text = "Vowel";
                    break;

                case "e":
                    txtLetterResult.Text = "Vowel";
                    break;

                case "i":
                    txtLetterResult.Text = "Vowel";
                    break;

                case "o":
                    txtLetterResult.Text = "Vowel";
                    break;

                case "u":
                    txtLetterResult.Text = "Vowel";
                    break;

                case "y":
                    txtLetterResult.Text = "Vowel or Consonant";
                    break;
                
                default:
                    txtLetterResult.Text = "Consonant";
                    break;




            }
        }
    }
}
