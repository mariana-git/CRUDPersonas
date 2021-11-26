using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaLogica;
using System.Windows.Forms;

namespace CapaVista
{
    public static class CVControlsOption
    {
        public static void ReadOnly(GroupBox gb,bool tof)
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
            }
        }
        public static bool Empty(GroupBox gb)
        {
            bool v = false;
            foreach (Control control in gb.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text == string.Empty) v = true;
                }
                if (control is ComboBox)
                {
                    ComboBox cmb = control as ComboBox;
                    if (cmb.SelectedItem == null) v = true;
                }
            }
            return v;
        }
        public static void CMBLoad(ComboBox cmb, string table, string id, string description)
        {
            cmb.DataSource = new CLRead { Table = table, Description = description }.CMBLoad();

            cmb.DisplayMember = description;
            cmb.ValueMember = id;
            cmb.SelectedIndex = -1;
        }
    }
}
