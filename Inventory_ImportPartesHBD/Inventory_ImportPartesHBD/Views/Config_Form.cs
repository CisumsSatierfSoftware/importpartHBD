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
    public partial class Config_Form : Form
    {
        public Config_Form()
        {
            InitializeComponent();
        }

        private void btnTasaDolar_Click(object sender, EventArgs e)
        {
            TasaDolar_Form form = new TasaDolar_Form();
            form.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
