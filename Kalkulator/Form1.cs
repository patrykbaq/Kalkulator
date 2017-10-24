using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Number(0);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Number(1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Number(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Number(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Number(4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Number(5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Number(6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Number(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Number(8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Number(9);
        }

        private void bAddition_Click(object sender, EventArgs e)
        {
            AddNumber();
            AddTypeOfAction("+");
            CleanTextBox();
        }

        private void bSubtraction_Click(object sender, EventArgs e)
        {
            AddNumber();
            AddTypeOfAction("-");
            CleanTextBox();
        }

        private void bMultiplication_Click(object sender, EventArgs e)
        {
            AddNumber();
            AddTypeOfAction("*");
            CleanTextBox();
        }

        private void bDivision_Click(object sender, EventArgs e)
        {
            AddNumber();
            AddTypeOfAction("/");
            CleanTextBox();
        }

        private void bClean_Click(object sender, EventArgs e)
        {
            CleanTextBox();
            TypeOfAction = " ";
            temp = "";
            ClearNumbers();
        }

        private void bResult_Click(object sender, EventArgs e)
        {
            AddNumber();
            CleanTextBox();
            Operation();
            tbResult.Text = result;
            ClearNumbers();
            TypeOfAction = " ";
            if (result != "Can't divide by 0")
                numbers.Add(result);
            else result = "0";
        }


        private void Number(int number)
        {
            temp += number;
            tbResult.Text = temp;
        }

        private void AddNumber()
        {
            if(temp!="")
                numbers.Add(temp);
            temp = "";
        }

        private void AddTypeOfAction(string type)
        {
            numbers.Add(type);
        }

        private void CleanTextBox()
        {
            tbResult.Text = "";
        }

        private void ClearNumbers()
        {
            numbers.Clear();
        }

        private void Operation()
        {
            foreach (String x in numbers)
            {
                if (x == "+")
                    TypeOfAction = x;
                else if (x == "-")
                    TypeOfAction = x;
                else if (x == "*")
                    TypeOfAction = x;
                else if (x == "/")
                    TypeOfAction = x;
                else if (TypeOfAction == " ")
                {
                    result = x;
                }
                else if (TypeOfAction != "") 
                {
                    result = Calculate(result, x);
                }
            }
        }

        private string Calculate(string a, string b)
        { 
            switch (TypeOfAction)
            {
                case "+":
                    return (float.Parse(a) + float.Parse(b)).ToString();

                case "-":
                    return (float.Parse(a) - float.Parse(b)).ToString();

                case "*":
                    return (float.Parse(a) * float.Parse(b)).ToString();

                case "/":
                    if (b == "0")
                    {
                        return "Can't divide by 0";
                        break;
                    }
                    return (float.Parse(a) / float.Parse(b)).ToString();
            }
            return "0";
        }

        List<String> numbers = new List<String>();
        private string temp;
        private string result;
        private string TypeOfAction = " ";
    }
}
