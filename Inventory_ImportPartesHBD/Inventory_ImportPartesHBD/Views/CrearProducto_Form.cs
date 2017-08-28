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
    public partial class CrearProducto_Form : Form
    {
        public Form backForm;

        public CrearProducto_Form()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.backForm.Visible = true;
            this.Close();
        }
    }
}
