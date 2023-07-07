using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private decimal valuefirst = 0.0m;
        private decimal valuesecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        int count = 0;
        int length;
        string digit = string.Empty;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            displaytextBox.Text= "0";
            valuefirst = 0; valuesecond = 0;
            smalltextBox.Clear();
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if(count<=8)
            {
                if (displaytextBox.Text == "0")
                {
                    displaytextBox.Text = "1";
                }
                else
                {
                    displaytextBox.Text += "1";
                }
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 8)
            {
                if (displaytextBox.Text == "0")
                {
                    displaytextBox.Text = "0";
                }
                else
                {
                    displaytextBox.Text += "0";
                }
            }

        }

        private void pointerbutton_Click(object sender, EventArgs e)
        {
            if (!displaytextBox.Text.Contains("."))
            {
                displaytextBox.Text += ".";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 8)
            {
                if (displaytextBox.Text == "0")
                {
                    displaytextBox.Text = "2";
                }
                else
                {
                    displaytextBox.Text += "2";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 8)
            {
                if (displaytextBox.Text == "0")
                {
                    displaytextBox.Text = "3";
                }
                else
                {
                    displaytextBox.Text += "3";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 8)
            {
                if (displaytextBox.Text == "0")
                {
                    displaytextBox.Text = "4";
                }
                else
                {
                    displaytextBox.Text += "4";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 8)
            {
                if (displaytextBox.Text == "0")
                {
                    displaytextBox.Text = "5";
                }
                else
                {
                    displaytextBox.Text += "5";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 8)
            {
                if (displaytextBox.Text == "0")
                {
                    displaytextBox.Text = "6";
                }
                else
                {
                    displaytextBox.Text += "6";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 8)
            {
                if (displaytextBox.Text == "0")
                {
                    displaytextBox.Text = "7";
                }
                else
                {
                    displaytextBox.Text += "7";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 8)
            {
                if (displaytextBox.Text == "0")
                {
                    displaytextBox.Text = "8";
                }
                else
                {
                    displaytextBox.Text += "8";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 8)
            {
                if (displaytextBox.Text == "0")
                {
                    displaytextBox.Text = "9";
                }
                else
                {
                    displaytextBox.Text += "9";
                }
            }
        }

        private void plusminusbutton_Click(object sender, EventArgs e)
        {
            if (displaytextBox.Text.Contains('-'))
            {
                displaytextBox.Text = displaytextBox.Text.Trim('-');
            }
            else
            {
                displaytextBox.Text = '-' + displaytextBox.Text;
            }
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            count = 0;
            valuefirst = decimal.Parse(displaytextBox.Text);
            smalltextBox.Text = valuefirst.ToString() + "-";
            displaytextBox.Clear();
            operators = "-";
        }

        private void plusbutton_Click(object sender, EventArgs e)
        {
            count = 0;
            valuefirst = decimal.Parse(displaytextBox.Text);
            smalltextBox.Text = valuefirst.ToString() + "+";
            displaytextBox.Clear();
            operators = "+";
        }

        private void multiplybutton_Click(object sender, EventArgs e)
        {
            count = 0;
            valuefirst = decimal.Parse(displaytextBox.Text); 
            smalltextBox.Text = valuefirst.ToString() + "*";
            displaytextBox.Clear();
            operators = "*";
        }

        private void dividebutton_Click(object sender, EventArgs e)
        {
            count = 0;
            valuefirst = decimal.Parse(displaytextBox.Text);
            smalltextBox.Text = valuefirst.ToString() + "/";
            displaytextBox.Clear();
            operators = "/";
        }

        private void percentagebutton_Click(object sender, EventArgs e)
        {
            count = 0;
            valuefirst = decimal.Parse(displaytextBox.Text);
            smalltextBox.Text = valuefirst.ToString() + "%";
            Result = valuefirst / 100;
            displaytextBox.Text = Result.ToString();
            valuefirst = Result;
            operators = "%";
        }

        private void equalbutton_Click(object sender, EventArgs e)
        {
            switch(operators)
            {
                case "+":
                    {
                        valuesecond = decimal.Parse(displaytextBox.Text);
                        smalltextBox.Text += valuesecond.ToString() + "=";
                        Result = valuefirst + valuesecond;
                        digit = Result.ToString();

                        length = digit.Length;
                        if (length <= 8)
                        {
                            displaytextBox.Text = digit;
                            valuefirst = Result;
                        }
                        else
                        {
                            displaytextBox.Text = "ERROR";
                        }
                        break;
                    }
                case "-":
                    {
                        valuesecond = decimal.Parse(displaytextBox.Text);
                        smalltextBox.Text += valuesecond.ToString() + "=";
                        Result = valuefirst - valuesecond;
                        displaytextBox.Text = Result.ToString();
                        valuefirst = Result;
                        break;
                    }
                case "*":
                    {
                        valuesecond = decimal.Parse(displaytextBox.Text);
                        smalltextBox.Text += valuesecond.ToString() + "=";
                        Result = valuefirst * valuesecond;
                        digit = Result.ToString();

                        length = digit.Length;
                        if (length <= 8)
                        {
                            displaytextBox.Text = digit;
                            valuefirst = Result;
                        }
                        else
                        {
                            displaytextBox.Text = "ERROR";
                        }
                        break;
                    }
                case "/":
                    {
                        valuesecond = decimal.Parse(displaytextBox.Text);
                        smalltextBox.Text += valuesecond.ToString() + "=";
                        
                        if(valuesecond != 0)
                        {
                            Result = valuefirst / valuesecond;
                            digit = Result.ToString();

                            length = digit.Length;
                            if (length <= 8)
                            {
                                displaytextBox.Text = digit;
                                valuefirst = Result;
                            }
                            else
                            {
                                displaytextBox.Text = "ERROR";
                            }
                        }
                        else
                        { displaytextBox.Text = "Math Error"; }
                        break;
                    }

            }
        }
    }
}
