using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Form1 : Form
    {
       
        
        public float a, b;
        public int count;
        public bool znak = true;
        private float save;
        public Form1()
        {
            InitializeComponent();
        }
       
       
        private void button1_Click_2(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 1;
                znak = true;
            }
            catch(FormatException)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + "Ошибка";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 2;
                znak = true;
            }
            catch (FormatException)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + "Ошибка";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 3;
                znak = true;
            }
            catch (FormatException)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + "Ошибка";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 4;
                znak = true;
            }
            catch (FormatException)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + "Ошибка";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + ",";
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 5;
                znak = true;
            }
            catch (FormatException)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + "Ошибка";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
           try
            {
                save = float.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + "Ошибка";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = textBox1.Text + save;
        }

        private void calculate()
        {

            
            
                switch (count)
                {
                    case 1:
                        {
                            //Zap();
                            b = a + float.Parse(textBox1.Text);
                            textBox1.Text = b.ToString();
                           
                            break;
                        }
                    case 2:
                        {
                            //Zap();
                            b = a - float.Parse(textBox1.Text);
                            textBox1.Text = b.ToString();
                            break;
                        }
                    case 3:
                        {
                           // Zap();
                            b = a * float.Parse(textBox1.Text);
                            textBox1.Text = b.ToString();
                            break;
                        }
                    case 4:
                        {
                           // Zap();
                            b = a / float.Parse(textBox1.Text);
                            textBox1.Text = b.ToString();
                            break;
                        }
                    case 5:
                        {
                           // Zap();
                            b = a % float.Parse(textBox1.Text);
                            textBox1.Text = b.ToString();
                            break;
                        }

                    default:
                        break;
                }
            
            

        }
    }
    
}
