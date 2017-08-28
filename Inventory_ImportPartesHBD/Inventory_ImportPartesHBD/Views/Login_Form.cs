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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Menu_Form form = new Menu_Form();
            form.backForm = this;
            form.Visible = true;
            this.Visible = false;
        }
    }
}
