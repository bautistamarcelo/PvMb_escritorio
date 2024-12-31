using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVpresentation.Resources
{
    public static class CustomFocusTxt
    {
        public static void ColorFondoFoco(this TextBox textBox)
        {
            textBox.BackColor = Color.FromArgb(161, 192, 100);
        }
        public static void ColorFondoNormal(this TextBox textBox)
        {
            textBox.BackColor = Color.FromArgb(221, 217, 195);
        }


        public static void ColorCmbFoco(this ComboBox comboBox)
        {
            comboBox.BackColor = Color.FromArgb(161, 192, 100);
        }
        public static void ColorCmbNormal(this ComboBox comboBox)
        {
           comboBox.BackColor = Color.FromArgb(221, 217, 195);
        }

    }
}