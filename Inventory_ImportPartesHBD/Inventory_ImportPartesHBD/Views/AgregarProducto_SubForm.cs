using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_ImportPartesHBD.Views
{
    public partial class AgregarProducto_SubForm : Form
    {
        public AgregarProducto_SubForm()
        {
            InitializeComponent();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cantidad_SubForm form = new Cantidad_SubForm();
            form.ShowDialog();
        }
    }
}
