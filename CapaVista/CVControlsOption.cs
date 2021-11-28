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
        public static void CMBLoad(ComboBox cmb, string table, string id, string description, string column = "", string condition ="")
        {
            cmb.DataSource = new CLRead { Table = table, Description = description, Column = column,
                Condition = condition}.CMBLoad();

            cmb.DisplayMember = description;
            cmb.ValueMember = id;
            cmb.SelectedIndex = -1;
        }

    }
}
