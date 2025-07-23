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
                // Recursively clear nested controls
                if (control.HasChildren)
                    ClearFormInputs(control);

                // Clear logic
                switch (control)
                {
                    case TextBoxBase textBox: 
                        textBox.Clear();
                        break;
                    case ComboBox comboBox:
                        comboBox.SelectedIndex = -1;
                        break;
                    case CheckBox checkBox:
                        checkBox.Checked = false;
                        break;
                    case RadioButton radioButton:
                        radioButton.Checked = false;
                        break;
                      
                }
            }
        }
    }
}
