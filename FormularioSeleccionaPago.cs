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
    public partial class FormularioSeleccionaPago : Form
    {
        //Campos de clase
        private Conexion conexion;
        private DataTable dtTiposPagos;
        private DataTable dtEstados;
        private decimal totalVenta;
        private decimal cambio = 0;


        //sombreamos el formulario
        

        public FormularioSeleccionaPago(decimal totalVenta)
        {
            InitializeComponent();
            conexion = new Conexion();
            dtTiposPagos = conexion.DameTablaCompleta("select * from tipo_pago");
            dtEstados = conexion.DameTablaCompleta("select * from estados");
            this.totalVenta = totalVenta;
        }

        private void FormularioSeleccionaPago_Load(object sender, EventArgs e)
        {
            txtCobrar.Text = totalVenta.ToString();
            txtPagado.Text = txtCobrar.Text;
            txtCambio.Text = cambio.ToString();

            //cmbEstado.DataSource = dtEstados;
            //cmbEstado.DisplayMember = "descripcion";
            
            cmbTiposPago.DataSource = dtTiposPagos;
            cmbTiposPago.DisplayMember = "descripcion";

            txtPagado.Focus();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           // this.Close();
        }



        private void txtPagado_TextChanged(object sender, EventArgs e)
        {


        }



        private void txtCambio_TextChanged(object sender, EventArgs e)
        {
            decimal aDevolver = Convert.ToDecimal(txtCambio.Text);
            decimal aCobrar = Convert.ToDecimal(txtCobrar.Text);

            decimal cambio = Convert.ToDecimal(txtCambio.Text);


            if (cambio < 0)
            {
                txtCambio.FillColor = Color.Red;

            }
            else
            {
                if (cambio == 0)
                {
                    txtCambio.FillColor = Color.FromArgb(128, 128, 255);
                }
                else
                {
                    txtCambio.FillColor = Color.ForestGreen;
                }
                
            }

            //if (aDevolver >= 0) 
            //{ 
            //    cmbEstado.SelectedIndex = 1; 
            //}
            //else if (aDevolver < 0)
            //{
            //    cmbEstado.SelectedIndex = 0;
            //    if (aDevolver <= aCobrar * (-1))
            //    {
            //        cmbEstado.SelectedIndex = 0;
            //    }
            //}
            

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {

            float i = 0;
            if (float.TryParse(txtPagado.Text, out i))
            {
                txtPagado.Text = float.Parse(txtPagado.Text).ToString("F2");
                this.Close();
            }
            else
            {
                MessageBox.Show("La cantidad introducida no es correcta", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPagado.Text = i.ToString("F2");
                txtPagado.Focus();
                return;
            }

            
        }

        private void txtPagado_Leave(object sender, EventArgs e)
        {
            float i = 0;
            if (float.TryParse(txtPagado.Text, out i))
            {
                txtPagado.Text = float.Parse(txtPagado.Text).ToString("F2");
                
            }
            else
            {
                MessageBox.Show("La cantidad introducida no es correcta", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPagado.Text = i.ToString("F2");
                txtPagado.Focus();
            }
        }



        private void txtPagado_Enter(object sender, EventArgs e)
        {
            txtPagado.SelectionStart = 0;
            txtPagado.SelectionLength = txtPagado.Text.Length;
        }

        private void txtPagado_Click(object sender, EventArgs e)
        {
            txtPagado.SelectionStart = 0;
            txtPagado.SelectionLength = txtPagado.Text.Length;
        }

        private void txtPagado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPagado_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                float Acobrar = Convert.ToSingle(txtCobrar.Text);
                float pagado = Convert.ToSingle(txtPagado.Text);
                float Adevolver = pagado - Acobrar;
                txtCambio.Text = Adevolver.ToString("F2");
            }
            catch (Exception)
            {

                txtPagado.Text = "0,00";
                txtPagado.SelectionStart = 0;
                txtPagado.SelectionLength = txtPagado.Text.Length;
                float Acobrar = Convert.ToSingle(txtCobrar.Text);
                float pagado = Convert.ToSingle(txtPagado.Text);
                float Adevolver = pagado - Acobrar;
                txtCambio.Text = Adevolver.ToString("F2");

            }
            
        }
    }
}
