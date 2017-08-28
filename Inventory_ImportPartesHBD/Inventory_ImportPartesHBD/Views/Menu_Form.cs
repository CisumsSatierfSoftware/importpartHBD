using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory_ImportPartesHBD.Views.Interface;

namespace Inventory_ImportPartesHBD.Views
{
    public partial class Menu_Form : Form, IViewForm
    {
        public Form backForm;

        public Menu_Form()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos_Form form = new Productos_Form();
            form.backForm = this;
            form.Visible = true;
            this.Visible = false;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Config_Form form = new Config_Form();
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.backForm.Visible = true;
            this.Close();
        }

        Form IViewForm.BackForm
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

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            CrearProducto_Form form = new CrearProducto_Form();
            form.backForm = this;
            form.Visible = true;
            this.Visible = false;
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {

        }
    }
}
