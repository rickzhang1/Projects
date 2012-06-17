using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class LoveCalculator : Form
    {
        public LoveCalculator()
        {
            InitializeComponent();
        }

        public string person1 = "";
        public string person2 = "";

        private int number10 = 0;
        private int number20 = 0;
        private void Calculate_Click(object sender, EventArgs e)
        {
            number10 = 0;
            number20 = 0;
            person1 = textBox1.Text.ToLower();
            person2 = textBox2.Text.ToLower();
            if (DoChecks())
            {
                if (hash(person1, person2) == 0)
                {
                    richTextBox1.Text = "100";
                }
                else
                {
                    richTextBox1.Text = hash(person1, person2).ToString();
                }
            }
        }

        public int hash(string first, string second)
        {
            int result = (number10 + number20);
            result = result + 69;
            result = result - 2;
            result = result * 12;
            result = result % 100;
            return result;
        }

        public bool DoChecks()
        {
            if (person1 == "" || person2 == "")
            {
                richTextBox1.Text = "0, because you forgot to enter a name!";
            }
            if (person1 == person2)
            {
                richTextBox1.Text = "0, because having a relationship with yourself is disgusting!";
                return false;
            }
            char[] lettersp1 = person1.ToCharArray();
            char[] lettersp2 = person2.ToCharArray();
            if (!CheckOther1(lettersp1) || !CheckOther2(lettersp2))
            {
                richTextBox1.Text = "0, I would totally love to have anything besides letters in my name too. Even periods would be nice..";
                return false;
            }
            return true;
        }

        public bool CheckOther1(char[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(((int)array[i] <= 122 && (int)array[i] >= 97) || ((int)array[i] <= 90 && (int)array[i] >= 65) || (int)array[i] == ' ')
                {
                    number20 = number20 + (int)array[i];
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckOther2(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (((int)array[i] <= 122 && (int)array[i] >= 97) || ((int)array[i] <= 90 && (int)array[i] >= 65) || (int)array[i] == ' ')
                {
                    number10 = number10 + (int)array[i];
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
