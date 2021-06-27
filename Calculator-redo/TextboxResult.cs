using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator_redo
{
    class TextboxResult
    {
        
        
        public void change_font(string gg)
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
    }
}
