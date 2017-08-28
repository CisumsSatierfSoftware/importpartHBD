using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory_ImportPartesHBD.Model;

namespace Inventory_ImportPartesHBD.Views
{
    public partial class EntradaProducto_Form : Form
    {
        public EntradaProducto_Form()
        {
            InitializeComponent();
            List<Producto> list = new List<Producto>();
            Producto producto = new Producto();
            producto.Codigo = "18471E41";
            producto.Descripcion = "Amortiguador Delantero Nissan Tiida";
            producto.Cantidad = 10;
            producto.Precio = 120000;
            list.Add(producto);
            list.Add(producto);
            list.Add(producto);
            list.Add(producto);

            foreach (Producto produc in list)
            {
                DataGridViewRow row = (DataGridViewRow)dgvProductos.Rows[0].Clone();
                row.Cells[1].Value = produc.Codigo;
                row.Cells[2].Value = produc.Descripcion;
                row.Cells[3].Value = produc.Cantidad;
                row.Cells[4].Value = produc.Precio;
                row.Cells[5].Value = produc.Cantidad * produc.Precio;
                row.Cells[6].Value = "Editar";
                dgvProductos.Rows.Add(row);
                //dgvProductos.Rows.Add("",produc.Codigo,produc.Descripcion,produc.Cantidad,produc.Precio,"","");
            }
            dgvProductos.Rows[list.Count].Cells[6].Value = "Agregar";
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    if (dgvProductos.RowCount > 1)
                    {
                        dgvProductos.Rows.RemoveAt(e.RowIndex);
                    }
                    break;

                case 6:
                    if (e.RowIndex < (dgvProductos.RowCount - 1))
                    {
                    }
                    else
                    {
                        AgregarProducto_SubForm form = new AgregarProducto_SubForm();
                        form.ShowDialog();
                    }
                    break;
            }
        }
    }
}
