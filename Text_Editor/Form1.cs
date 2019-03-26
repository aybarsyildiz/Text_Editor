using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }
        int boldCheck = 0;
        private void boldButton_Click(object sender, EventArgs e)
        {
            if (boldCheck == 0)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                boldCheck = 1;
            }
            else { 

                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                boldCheck = 0;
            }
        }
        int italicCheck = 0;
        private void buttonItalic_Click(object sender, EventArgs e)
        {
            if (italicCheck == 0)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
                italicCheck = 1;
            }
            else
            {

                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                italicCheck = 0;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Tab)
            {
                textBox1.Text += "    ";
            }
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollBar1.Value == 0)
                hScrollBar1.Value = 5;

            textBox1.Font = new Font("Serif", hScrollBar1.Value,FontStyle.Regular);
            label2.Text = Convert.ToString(hScrollBar1.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void blackButton_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Black;
 
        }

        private void greyButton_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Gray;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Gold;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Red;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Green;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        private void nightMode_Click(object sender, EventArgs e)
        {
            
            if (nightMode.Text == "OFF") {
                if (textBox1.ForeColor == System.Drawing.Color.Black)
                    textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;


                BackColor = System.Drawing.Color.Gray;
         
                textBox1.BackColor = System.Drawing.Color.Black;
                nightMode.Text = "ON";
            }
            else
            {
                if (textBox1.ForeColor == System.Drawing.Color.WhiteSmoke)
                    textBox1.ForeColor = System.Drawing.Color.Black;
                BackColor = System.Drawing.Color.PowderBlue;
                textBox1.BackColor = System.Drawing.Color.White;
                nightMode.Text = "OFF";

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Both;
        }

        private void underLine_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
        }
    }
}
