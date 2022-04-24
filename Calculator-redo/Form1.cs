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
        TextboxResult calcu = new TextboxResult();

        public Calculator()
        {
            InitializeComponent();
            operation_lbl.Hide();
            resultFrame.Text = "0";
        }

        public void resultFrame_TextChanged(object sender, EventArgs e)
        {
            change_font();
        }

        public void change_font()
        {
            var text3 = resultFrame.Text;
            if (text3.Length > 13)
            {
                Font Font_New = new Font("Microsoft Sans Serif", 8.5f);
                resultFrame.Font = Font_New;
            }
            else
            {
                Font Font_New = new Font("Microsoft Sans Serif", 21.5f);
                resultFrame.Font = Font_New;
            }
        }

        public void Btn1_Click(object sender, EventArgs e)
        {
            if ((resultFrame.Text == "0") || calcu.Operation_performed)
                resultFrame.Clear();

            calcu.Operation_performed = false;
            Button button = (Button)sender;
            if (resultFrame.Text == ".")
            {
                if (!resultFrame.Text.Contains("."))
                {
                    resultFrame.Text = resultFrame.Text + button.Text;
                }

                else if (resultFrame.Text.Contains("."))
                {
                    resultFrame.Text = resultFrame.Text + button.Text;
                    stored_action.Text = resultFrame.Text;
                }
            }

            else
            {
                resultFrame.Text = resultFrame.Text + button.Text;
            }
        }

        public void equalBtn_Click(object sender, EventArgs e)
        {
            calcu.NumB = resultFrame.Text;
            calcu.operationVariation();
            resultFrame.Text = calcu.NumB;
        }

        public void plusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Button operation_btn = (Button)sender;
                calcu.Operation = operation_btn.Text;
                formula();
            }

            catch
            {

            }
        }

        public void formula()
        {
            calcu.Result = Double.Parse(resultFrame.Text);
            stored_action.Text = resultFrame.Text + " " + calcu.Operation;
            equalBtn.PerformClick();
            calcu.Operation_performed = true;
            resultFrame.Clear();
        }

        public void ClrAllBtn_Click(object sender, EventArgs e)
        {
            calcu.NumB = resultFrame.Text;
            calcu.StorageTxt = stored_action.Text;
            calcu.clearButtonMethod();

            resultFrame.Text = calcu.NumB;
            stored_action.Text = calcu.StorageTxt;
        } 
    
        private void stored_action_Click(object sender, EventArgs e)
        {
            
        }

        public void DltBtn_Click(object sender, EventArgs e)
        {
            calcu.NumB = resultFrame.Text;
            calcu.deleteMethod();
            resultFrame.Text = calcu.NumB;
        }       

        public void csignBtn_Click(object sender, EventArgs e)
        {
            calcu.NumB = resultFrame.Text;
            calcu.csignBtnMethod();
            resultFrame.Text = calcu.NumB;
        }
        
        public void resultFrame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '.' && resultFrame.Text.Contains("."))
            {
                e.Handled = true;
            }
         
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }              
    }
}
