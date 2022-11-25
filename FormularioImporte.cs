using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoofGroomer
{
    public partial class FormularioImporte : Form
    {
        public FormularioImporte()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtImporte_Click(object sender, EventArgs e)
        {
            txtImporte.SelectionStart = 0;
            txtImporte.SelectionLength = txtImporte.Text.Length;
        }

        private void txtImporte_Enter(object sender, EventArgs e)
        {
            txtImporte.SelectionStart = 0;
            txtImporte.SelectionLength = txtImporte.Text.Length;
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }



                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtImporte_Leave(object sender, EventArgs e)
        {
            float i = 0;
            if (float.TryParse(txtImporte.Text, out i))
            {
                txtImporte.Text = float.Parse(txtImporte.Text).ToString("F2");

            }
            else
            {
                MessageBox.Show("La cantidad introducida no es correcta", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtImporte.Text = i.ToString("F2");
                txtImporte.Focus();
            }
        }
    }
}
