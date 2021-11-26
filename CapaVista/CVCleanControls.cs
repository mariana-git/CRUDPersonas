using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public static class CVCleanControls
    {
        public static void CleanGB(GroupBox gb)
        {
            foreach (Control control in gb.Controls)
            {
                if (control is TextBox)
                {
                    TextBox t = control as TextBox;
                    t.Text = string.Empty;
                }
                if (control is MaskedTextBox)
                {
                    MaskedTextBox mkt = control as MaskedTextBox;
                    mkt.Text = string.Empty;
                }
                if (control is Label)
                {
                    Label l = control as Label;
                    if (l.BackColor == System.Drawing.Color.Gainsboro) l.Text = string.Empty;
                }
                if (control is ComboBox)
                {
                    ComboBox cmb = control as ComboBox;
                    cmb.SelectedIndex = -1;
                }
                if (control is DataGridView)
                {
                    DataGridView d = control as DataGridView;
                    d.DataSource = null;
                }
            }
        }
    }
}
