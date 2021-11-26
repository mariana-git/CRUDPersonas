using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    static public class CVDesingOptions
    {
        static public void DgvDesing(DataGridView dgv)
        {
            dgv.DefaultCellStyle.Font = new Font("Arial",10) ;//fuente
            dgv.DefaultCellStyle.ForeColor = Color.Black; //color de fuente
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders; //ancho de las columas como las celdas
            dgv.RowHeadersVisible = false; // no muestra la primera columna
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona toda la fila
            dgv.ReadOnly = true; //hace que la grilla no se pueda editar
            dgv.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LavenderBlush;//alterna colores de las filas
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;//alterna colores de las filas
            dgv.AllowUserToAddRows = false; //desactiva la ultima fila 
            dgv.MultiSelect = false; //desactiva la seleccion multiple
        }
    }
}
