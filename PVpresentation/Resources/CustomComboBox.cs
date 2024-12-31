using PVpresentation.Resources;

namespace PVpresentation.Resources
{
    public static class CustomComboBox
    {
        public static void InsertarItems(this ComboBox comboBox, OpcionesComboBox[] items)
        {
            comboBox.Items.AddRange(items);
            comboBox.DisplayMember = "Texto";
            comboBox.ValueMember = "Value";
            comboBox.SelectedIndex = 0;
        }

        public static void EstablecerValor(this ComboBox comBo, int vaLor)
        {
            foreach (OpcionesComboBox opCion in comBo.Items)
            {
                if (opCion.Valor == vaLor)
                {
                    comBo.SelectedItem = opCion;
                    break;
                }
            }
            
        }
    }
}
