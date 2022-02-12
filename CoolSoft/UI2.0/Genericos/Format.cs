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
            dg.EnableHeadersVisualStyles = false;

            dg.BackgroundColor = Color.White; //Color.FromArgb(197, 202, 233);
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 44, 84);
            dg.BorderStyle = BorderStyle.None;
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dg.ColumnHeadersHeight = 30;

            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(190, 195, 227);
            dg.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            dg.AllowUserToAddRows = false;
            dg.AllowUserToDeleteRows = false;
            dg.AllowUserToResizeRows = false;
            dg.RowHeadersVisible = false;
            dg.ReadOnly = true;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;


        }
    }
}
