using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator_redo
{
    class TextboxResult
    {
        private Double result = 0;
        public double Result { get => result; set => result = value; }
       
        private string operation = "";
        public string Operation { get => operation; set => operation = value; }
       
        private Boolean operation_performed = false;
        public bool Operation_performed { get => operation_performed; set => operation_performed = value; }

        private string numB;
        public string NumB { get => numB; set => numB = value; }
        
        private string storageTxt;
        public string StorageTxt { get => storageTxt; set => storageTxt = value; }

        public void operationVariation()
        {
            try
            {
                switch (Operation)
                {
                    case "+":
                        Double sum = Result + Double.Parse(NumB);
                        numB = sum.ToString();
                        break;
                    case "-":
                        Double difference = Double.Parse(NumB) - Result;
                        Double difference2 = difference * -1;
                        numB = difference2.ToString();
                        break;
                    case "÷":
                        Double division = Result / Double.Parse(NumB);
                        if (numB == "0")
                        {
                            numB = "Cannot be divided by 0";
                        }
                        else
                            numB = division.ToString();
                        break;
                    case "×":
                        Double multiplication = Result * Double.Parse(numB);
                        numB = multiplication.ToString();
                        break;
                    case "%":
                        Double percentage = Result / 100;
                        numB = percentage.ToString();
                        break;
                }
            }
            catch
            {
                numB = "Invalid";
            }
        }

        public void clearButtonMethod()
        {
            result = 0;
            numB = "0";
            storageTxt = "";
        }

        public void deleteMethod()
        {
            var text = numB;
            if (text.Length > 0)
            {
                numB = text.Remove(text.Length - 1);

                var text2 = numB;
                if (text2.Length == 0)
                {
                    numB = "0";
                }
            }
        }

        public void csignBtnMethod()
        {
            if (numB.StartsWith("-"))
            {
                numB = numB.Substring(1);
            }

            else if (!string.IsNullOrEmpty(numB) && decimal.Parse(numB) != 0)
            {
                numB = "-" + numB;
            }
        }
    }
}