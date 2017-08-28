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
    public partial class DetallesProducto_Form : Form, IViewForm
    {
        public Form backForm;

        public DetallesProducto_Form()
        {
            InitializeComponent();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            panelBtnPrincipal.Visible = false;
            panelBtnSegundario.Visible = true;
            btnCambiarImg.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            panelBtnSegundario.Visible = false;
            panelBtnPrincipal.Visible = true;
            btnCambiarImg.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelBtnSegundario.Visible = false;
            panelBtnPrincipal.Visible = true;
            btnCambiarImg.Visible = false;
        }
    }
}
