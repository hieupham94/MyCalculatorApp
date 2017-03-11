using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyCalculatorApp
{
    public partial class MainPage : ContentPage
    {
        public string num1 = "";
        public string num2 = "";
        public char act = ' ';

        public MainPage()
        {
            InitializeComponent();
            Output.Text = "0";
        }

        private void btnAC(object sender, System.EventArgs e)
        {
            Output.Text = "0";
            num1 = "";
            num2 = "";
            act = ' ';
        }
        /////////////////act
        private void btnPlus(object sender, System.EventArgs e)
        {
            num1 = Output.Text;
            act = '+';
        }

        private void btnDivide(object sender, System.EventArgs e)
        {
            num1 = Output.Text;
            act = '/';
        }

        private void btnMultiply(object sender, System.EventArgs e)
        {
            num1 = Output.Text;
            act = '*';
        }

        private void btnMinus(object sender, System.EventArgs e)
        {
            num1 = Output.Text;
            act = '-';
        }

        /////////////////equal
        private void btnEqual(object sender, System.EventArgs e)
        {
            num2 = Output.Text;
            switch (act)
            {
                case '+':
                    Output.Text = Convert.ToString(Convert.ToDouble(num1) + Convert.ToDouble(num2));
                    break;
                case '-':
                    Output.Text = Convert.ToString(Convert.ToDouble(num1) - Convert.ToDouble(num2));
                    break;
                case '/':
                    Output.Text = Convert.ToString(Convert.ToDouble(num1) / Convert.ToDouble(num2));
                    break;
                case '*':
                    Output.Text = Convert.ToString(Convert.ToDouble(num1) * Convert.ToDouble(num2));
                    break;
            }
            num1 = "";
            num2 = "";
            act = ' ';
        }


        /////////////////number
        private void btn0(object sender, System.EventArgs e)
        {
            if (act == ' ')
            {
                num1 += "0";
                Output.Text = Convert.ToString(num1);
            }
            else
            {
                num2 += "0";
                Output.Text = Convert.ToString(num2);
            }
        }

        private void btn1(object sender, System.EventArgs e)
        {
            if (act == ' ')
            {
                num1 += "1";
                Output.Text = Convert.ToString(num1);
            }
            else
            {
                num2 += "1";
                Output.Text = Convert.ToString(num2);
            }
        }

        private void btn2(object sender, System.EventArgs e)
        {
            if (act == ' ')
            {
                num1 += "2";
                Output.Text = Convert.ToString(num1);
            }
            else
            {
                num2 += "2";
                Output.Text = Convert.ToString(num2);
            }
        }

        private void btn3(object sender, System.EventArgs e)
        {
            if (act == ' ')
            {
                num1 += "3";
                Output.Text = Convert.ToString(num1);
            }
            else
            {
                num2 += "3";
                Output.Text = Convert.ToString(num2);
            }
        }

        private void btn4(object sender, System.EventArgs e)
        {
            if (act == ' ')
            {
                num1 += "4";
                Output.Text = Convert.ToString(num1);
            }
            else
            {
                num2 += "4";
                Output.Text = Convert.ToString(num2);
            }
        }

        private void btn5(object sender, System.EventArgs e)
        {
            if (act == ' ')
            {
                num1 += "5";
                Output.Text = Convert.ToString(num1);
            }
            else
            {
                num2 += "5";
                Output.Text = Convert.ToString(num2);
            }
        }

        private void btn6(object sender, System.EventArgs e)
        {
            if (act == ' ')
            {
                num1 += "6";
                Output.Text = Convert.ToString(num1);
            }
            else
            {
                num2 += "6";
                Output.Text = Convert.ToString(num2);
            }
        }

        private void btn7(object sender, System.EventArgs e)
        {
            if (act == ' ')
            {
                num1 += "7";
                Output.Text = Convert.ToString(num1);
            }
            else
            {
                num2 += "7";
                Output.Text = Convert.ToString(num2);
            }
        }

        private void btn8(object sender, System.EventArgs e)
        {
            if (act == ' ')
            {
                num1 += "8";
                Output.Text = Convert.ToString(num1);
            }
            else
            {
                num2 += "8";
                Output.Text = Convert.ToString(num2);
            }
        }

        private void btn9(object sender, System.EventArgs e)
        {
            if (act == ' ')
            {
                num1 += "9";
                Output.Text = Convert.ToString(num1);
            }
            else
            {
                num2 += "9";
                Output.Text = Convert.ToString(num2);
            }
        }



        //////////////////

        private void btnPoint(object sender, System.EventArgs e)
        {
            if (act == ' ')
            {
                num1 += ".";
                Output.Text = Convert.ToString(num1);
            }
            else
            {
                num2 += ".";
                Output.Text = Convert.ToString(num2);
            }
        }

        private void btnPercent(object sender, System.EventArgs e)
        {
            Output.Text = Convert.ToString(Convert.ToDouble(Output.Text) / 100);
        }

        private void btnRed(object sender, System.EventArgs e)
        {
            LayoutRoot.Style = (Style)Resources["RedStyle"];
        }
        private void btnBlue(object sender, System.EventArgs e)
        {
            LayoutRoot.Style = (Style)Resources["BlueStyle"];
        }
    }
}
