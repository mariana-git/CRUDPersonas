using System.Windows.Forms;

namespace CapaVista
{
    public static class CVControlsReadOnly
    {
        public static void ReadOnly(GroupBox gb, bool tof)
        {
            foreach (Control control in gb.Controls)
            {
                if (control is TextBox)
                {
                    TextBox t = control as TextBox;
                    t.ReadOnly = tof;
                }
                if (control is ComboBox)
                {
                    ComboBox cmb = control as ComboBox;
                    cmb.Enabled = !tof;
                }
                if (control is MaskedTextBox)
                {
                    MaskedTextBox mkt = control as MaskedTextBox;
                    mkt.ReadOnly = tof;
                }
            }
        }
    }
}
