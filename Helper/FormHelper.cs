using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Helper
{
    public class FormHelper
    {
        public static void ClearFormInputs(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox tb)
                    tb.Clear();

                if (control.HasChildren)
                    ClearFormInputs(control); // Recursive for nested controls
            }
        }
    }
}
