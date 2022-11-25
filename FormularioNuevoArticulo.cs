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
    public partial class FormularioNuevoArticulo : Form
    {
        //Campos de clase
        private Conexion conexion;
        private DataTable dtImpuestos;

        public FormularioNuevoArticulo()
        {
            InitializeComponent();
            conexion = new Conexion();
            dtImpuestos = conexion.DameTablaCompleta("select * from impuestos");
        }

        private void FormularioNuevoArticulo_Load(object sender, EventArgs e)
        {
            txtID.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            cmbTipoIVA.DataSource = dtImpuestos;
            cmbTipoIVA.DisplayMember = "descripcion";
            cmbTipoIVA.ValueMember = "porcentaje_valor";
            cmbTipoIVA.SelectedIndex = cmbTipoIVA.Items.Count - 1;

            cmbTipoArticulo.SelectedIndex = 0;
        }

        private void txtNeto_Click(object sender, EventArgs e)
        {
            txtNeto.SelectionStart = 0;
            txtNeto.SelectionLength = txtNeto.Text.Length;
        }

        private void txtNeto_Enter(object sender, EventArgs e)
        {
            txtNeto.SelectionStart = 0;
            txtNeto.SelectionLength = txtNeto.Text.Length;
        }

        private void txtNeto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNeto_Leave(object sender, EventArgs e)
        {
            float i = 0;
            if (float.TryParse(txtNeto.Text, out i))
            {
                txtNeto.Text = float.Parse(txtNeto.Text).ToString("F2");
                calculaDesdeNeto();
            }
            else
            {
                MessageBox.Show("La cantidad introducida no es correcta", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNeto.Text = i.ToString("F2");
                txtNeto.Focus();
            }
        }

        private void txtTotal_Click(object sender, EventArgs e)
        {
            txtTotal.SelectionStart = 0;
            txtTotal.SelectionLength = txtNeto.Text.Length;
        }

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            txtTotal.SelectionStart = 0;
            txtTotal.SelectionLength = txtNeto.Text.Length;
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            float i = 0;
            if (float.TryParse(txtTotal.Text, out i))
            {
                txtTotal.Text = float.Parse(txtTotal.Text).ToString("F2");
                calculaDesdeTotal();
            }
            else
            {
                MessageBox.Show("La cantidad introducida no es correcta", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotal.Text = i.ToString("F2");
                txtTotal.Focus();
            }
        }

        private void calculaDesdeNeto()
        {
            //Obtenemos los valores
            float porcentajeIVA = Convert.ToSingle(cmbTipoIVA.SelectedValue.ToString());
            float neto = Convert.ToSingle(txtNeto.Text.Trim());
            float importeIVA = neto * porcentajeIVA;

            //Mostramos los valores
            txtImporteIVA.Text = importeIVA.ToString("F2");
            txtTotal.Text = (neto + importeIVA).ToString("F2");
        }

        private void calculaDesdeTotal()
        {
            //Obtenemos los valores
            float porcentajeIVA = Convert.ToSingle(cmbTipoIVA.SelectedValue.ToString());
            float total = Convert.ToSingle(txtTotal.Text.Trim());
            float neto = (total / (porcentajeIVA + 1));

            //Mostramos Valores
            txtImporteIVA.Text = (total - neto).ToString("F2");
            txtNeto.Text = neto.ToString("F2");

        }

        private void cmbTipoIVA_SelectedIndexChanged(object sender, EventArgs e)
        {

                txtPorcentajeIVA.Text = dtImpuestos.Rows[cmbTipoIVA.SelectedIndex].ItemArray[3].ToString();
                float defecto = 0;
                float impIVA = 0;
                float impTotal = 0;
                if (float.TryParse(txtNeto.Text.Trim(), out defecto) && float.TryParse(cmbTipoIVA.SelectedValue.ToString(), out defecto))
                {
                    impIVA = float.Parse(txtNeto.Text.Trim()) * Convert.ToSingle(cmbTipoIVA.SelectedValue.ToString());
                    impTotal = float.Parse(txtNeto.Text.Trim()) + impIVA;
                }

                txtTotal.Text = impTotal.ToString("F2");
                txtImporteIVA.Text = impIVA.ToString("F2");

        }

        private void txtStock_Click(object sender, EventArgs e)
        {
            txtStock.SelectionStart = 0;
            txtStock.SelectionLength = txtNeto.Text.Length;
        }

        private void txtStock_Enter(object sender, EventArgs e)
        {
            txtStock.SelectionStart = 0;
            txtStock.SelectionLength = txtNeto.Text.Length;
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtStock_Leave(object sender, EventArgs e)
        {
            float i = 0;
            if (float.TryParse(txtStock.Text, out i))
            {
                txtStock.Text = float.Parse(txtStock.Text).ToString("F2");
                calculaDesdeNeto();
            }
            else
            {
                MessageBox.Show("La cantidad introducida no es correcta", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStock.Text = i.ToString("F2");
                txtStock.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                MessageBox.Show("Debe indicar una descripción al nuevo producto/servicio", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Focus();
                return;
            }

            //Creamos el nuevo artículo
            string tabla = "productos_servicios";
            string[] campos = new string[]
            {
                "id_producto_servicio",
                "descripcion",
                "tipo",
                "stock",
                "precio_venta",
                "tipo_IVA"
            };
            string[] valores = new string[]
            {
                txtID.Text,
                txtDescripcion.Text,
                cmbTipoArticulo.Text,
                txtStock.Text,
                txtTotal.Text,
                cmbTipoIVA.SelectedIndex.ToString()
            };

            string respuesta = conexion.NuevoRegistro(tabla, campos, valores);
            if (respuesta == null)
            {
                MessageBox.Show("El producto/servicio se ha creado correctamente", "Nuevo producto/servicio", MessageBoxButtons.OK);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show($"No se ha podido crear el producto/servicio.\n{respuesta}", "Nuevo producto/servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
