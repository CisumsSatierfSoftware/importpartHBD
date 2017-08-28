using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory_ImportPartesHBD.Model;
using Inventory_ImportPartesHBD.Views.Interface;

namespace Inventory_ImportPartesHBD.Views
{
    public partial class Productos_Form : Form, IViewForm
    {
        public Form backForm;

        public Productos_Form()
        {
            InitializeComponent();
            List<Producto> list = new List<Producto>();
            Producto producto = new Producto();
            producto.Codigo = "18471E41";
            producto.Descripcion = "Amortiguador Delantero Nissan Tiida";
            producto.Ubicacion = "E515";
            producto.Cantidad = 10;
            producto.Precio = 120000;
            list.Add(producto);
            dgvProductos.DataSource = null;
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = list;
            dgvProductos.Columns["codigo"].DataPropertyName = "codigo";
            dgvProductos.Columns["descripcion"].DataPropertyName = "descripcion";
            dgvProductos.Columns["ubicacion"].DataPropertyName = "ubicacion";
            dgvProductos.Columns["cant"].DataPropertyName = "cantidad";
            dgvProductos.Columns["precio"].DataPropertyName = "precio";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.backForm.Visible = true;
            this.Close();
        }

        public Form BackForm
        {
            get
            {
                return backForm;
            }
            set
            {
                backForm = value;
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!dgvProductos.RowCount.Equals(0) && e.ColumnIndex.Equals(5))
            {
                DetallesProducto_Form form = new DetallesProducto_Form();
                form.backForm = this;
                form.Visible = true;
                this.Visible = false;
            }
        }
    }
}
