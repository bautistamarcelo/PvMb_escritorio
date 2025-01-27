using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PVpresentation.Resources
{
    public static class CustomDataGridView
    {
        public static void ImplementarConfiguracion(this DataGridView datagrid, string textoEnBoton = "")
        {
            datagrid.AllowUserToAddRows = false;
            datagrid.AllowUserToDeleteRows = false;
            datagrid.AllowUserToResizeColumns = true;
            datagrid.AllowUserToResizeRows = false;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.AllowUserToOrderColumns = false;
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.MultiSelect = false;
            datagrid.RowHeadersVisible = false;
            datagrid.ReadOnly = true;
            datagrid.BackgroundColor = Color.FromArgb(45, 66, 91);
            
            datagrid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(70, 130, 180),
                SelectionBackColor = Color.FromArgb(45, 66, 91),
                ForeColor = Color.FromArgb(255, 255, 255)
            };
            datagrid.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor =Color.FromArgb(141,162,182),
                //ForeColor = Color.FromArgb(45,66,91),
                ForeColor = Color.FromArgb(0, 0, 0),
                SelectionBackColor = Color.FromArgb(112, 128, 144),
                SelectionForeColor = Color.FromArgb(255, 255, 255),
            };
            datagrid.ColumnHeadersHeight = 35;
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;


            if (textoEnBoton != "")
            {
                var btnEditarColumn = new DataGridViewButtonColumn();
                btnEditarColumn.Text = textoEnBoton;
                btnEditarColumn.Name = "ColumnaAccion";
                btnEditarColumn.HeaderText = "";
                btnEditarColumn.UseColumnTextForButtonValue = true;
                btnEditarColumn.Width = 50;
                btnEditarColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                btnEditarColumn.Visible = true;

                datagrid.Columns.Add(btnEditarColumn);

            }


        }
    }
}
