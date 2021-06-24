using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_redo
{
    public partial class Calculator : Form
    {

        Double result = 0;
        string operation = "";
        Boolean operation_performed = false;
        public Calculator()
        {
            InitializeComponent();
            operation_lbl.Hide();
            input1.Hide();
            stored_Action2.Hide();
            resultFrame.Text = "0";
        }


        private void resultFrame_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if((resultFrame.Text == "0") || operation_performed) 
                resultFrame.Clear();

            operation_performed = false;
            Button button = (Button)sender;
            if(resultFrame.Text == ".")
            {
                if (!resultFrame.Text.Contains("."))
                {
                    resultFrame.Text = resultFrame.Text + button.Text;
                }
            }
            else
            {
                resultFrame.Text = resultFrame.Text + button.Text;
            }
            
            
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {

            switch (operation)
            {
                case "+":
                    Double sum = result + Double.Parse(resultFrame.Text);
                    resultFrame.Text = sum.ToString();
                    break;
                case "-":
                    Double difference = Double.Parse(resultFrame.Text) - result;
                    Double difference2 = difference * -1;
                    resultFrame.Text = difference2.ToString();
                        break;
                case "÷":
                    Double division = result / Double.Parse(resultFrame.Text) ;
                    if(resultFrame.Text == "0")
                    {
                        resultFrame.Text = "Cannot be divide by 0";
                    }
                    else
                        resultFrame.Text = division.ToString();
                    break;
                case "×":
                    Double multiplication = result * Double.Parse(resultFrame.Text);
                    resultFrame.Text = multiplication.ToString();
                        break;
                case "%":
                    Double percentage = result / 100;
                    resultFrame.Text = percentage.ToString();
                    break;

            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            
            Button operation_btn = (Button)sender;
            operation = operation_btn.Text;
            result = Double.Parse(resultFrame.Text);
            stored_action.Text = resultFrame.Text + " " + operation;
            equalBtn.PerformClick();
            operation_performed = true;
            resultFrame.Clear();
            


        }

        private void ClrAllBtn_Click(object sender, EventArgs e)
        {
            result = 0;
            resultFrame.Text = "0";
            stored_action.Text = "";
        }

        private void stored_action_Click(object sender, EventArgs e)
        {

        }

        private void DltBtn_Click(object sender, EventArgs e)
        {
            var text = resultFrame.Text;
            if (text.Length > 0)
            {
                resultFrame.Text = text.Remove(text.Length - 1);

                var text2 = resultFrame.Text;
                if(text2.Length == 0)
                {
                    resultFrame.Text = "0";
                }

            }

        }

        private void csignBtn_Click(object sender, EventArgs e)
        {
            if (resultFrame.Text.StartsWith("-"))
            {
                resultFrame.Text = resultFrame.Text.Substring(1);
            }

            else if(!string.IsNullOrEmpty(resultFrame.Text) && decimal.Parse(resultFrame.Text) != 0)
            {
                resultFrame.Text = "-" + resultFrame.Text;
            }
        }
    }
}
