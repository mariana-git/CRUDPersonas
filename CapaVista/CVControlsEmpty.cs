using System.Windows.Forms;

namespace CapaVista
{
    public static class CVControlsEmpty
    {
        public static bool Empty(GroupBox gb)
        {
            bool v = false;
            foreach (Control control in gb.Controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    if (control.Text == "")
                    {
                        if (control.Name == "txtPFloor" || control.Name == "txtPDepto") v = false;
                        else
                        {
                            v = true;
                            break;
                        }
                    }
                }
                if (control is ComboBox)
                {
                    ComboBox cmb = control as ComboBox;
                    if (cmb.SelectedIndex == -1)
                    {
                        if (control.Name == "cmbLocalidad") v = false;
                        else
                        {
                            v = true;
                            break;
                        }
                    }
                }
            }
            return v;
        }
    }
}
