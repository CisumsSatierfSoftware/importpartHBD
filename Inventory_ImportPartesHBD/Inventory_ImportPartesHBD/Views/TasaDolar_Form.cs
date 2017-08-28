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
    public partial class TasaDolar_Form : Form
    {
        public string valorDolar = "16200,00";
        public TasaDolar_Form()
        {
            InitializeComponent();
            txtTasaDolar.Text = valorDolar;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            panelPrincipal.Visible = false;
            panelSegundario.Visible = true;
            txtTasaDolar.ReadOnly = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            panelSegundario.Visible = false;
            panelPrincipal.Visible = true;
            txtTasaDolar.ReadOnly = true;
            valorDolar = txtTasaDolar.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelSegundario.Visible = false;
            panelPrincipal.Visible = true;
            txtTasaDolar.ReadOnly = true;
            txtTasaDolar.Text = valorDolar;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
