using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CoolSoft.UI2._0.Genericos
{
    static class Format
    {


        static public void DataGridView(DataGridView dg)
        {


            //GENERAL
            dg.BackgroundColor = Color.White; //Color.FromArgb(197, 202, 233);
            dg.BorderStyle = BorderStyle.None;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.MultiSelect = false;


            //ENCABEZADOS COLUMNAS
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 44, 84);
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dg.ColumnHeadersHeight = 30;
            dg.ColumnHeadersDefaultCellStyle.SelectionBackColor = dg.ColumnHeadersDefaultCellStyle.BackColor;
            dg.ColumnHeadersDefaultCellStyle.SelectionForeColor = dg.ColumnHeadersDefaultCellStyle.BackColor;

            //ANCHO COLUMNAS
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //FILAS
            dg.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            dg.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            dg.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dg.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;

            //FILAS ALTERNATIVAS
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(190, 195, 227);
            dg.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dg.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);



            //PERMISOS
            dg.AllowUserToAddRows = false;
            dg.AllowUserToDeleteRows = false;
            dg.AllowUserToResizeRows = false;
            dg.RowHeadersVisible = false;
            dg.ReadOnly = true;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dg.EnableHeadersVisualStyles = false;

        }
    }
}
