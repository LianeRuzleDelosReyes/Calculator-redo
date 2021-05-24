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
            input2.Hide();
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
                    Double difference = result - Double.Parse(resultFrame.Text);
                    resultFrame.Text = difference.ToString();
                        break;
                case "÷":
                    Double division = result / Double.Parse(resultFrame.Text) ;
                    resultFrame.Text = division.ToString();
                        break;
                case "×":
                    Double multiplication = result * Double.Parse(resultFrame.Text);
                    resultFrame.Text = multiplication.ToString();
                        break;

            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            equalBtn.PerformClick();
            Button operation_btn = (Button)sender;
            operation = operation_btn.Text;
            result = Double.Parse(resultFrame.Text);
            stored_action.Text = resultFrame.Text + " " + operation;
            operation_performed = true;
            resultFrame.Clear(); 
           
        }

        private void ClrAllBtn_Click(object sender, EventArgs e)
        {
            result = 0;
            resultFrame.Clear();
            stored_action.Text = "";
        }

        private void stored_action_Click(object sender, EventArgs e)
        {

        }
    }
}
