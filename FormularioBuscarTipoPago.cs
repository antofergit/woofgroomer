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
    public partial class FormularioBuscarTipoPago : Form
    {

        //Campos de clase
        private Conexion conexion;
        private DataTable dtTipos;

        public FormularioBuscarTipoPago()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";

        }

        private void FormularioBuscarTipoPago_Load(object sender, EventArgs e)
        {
            Actualiza();
        }

        private void Actualiza()
        {
            string consulta = "select id_tipo_pago, descripcion from tipo_pago";
            dtTipos = conexion.DameTablaCompleta(consulta);
            dataTipoPago.DataSource = dtTipos;
            dataTipoPago.Columns[0].Visible = false;

        }

        private void btnSelecciona_Click(object sender, EventArgs e)
        {
            if (dataTipoPago.SelectedRows.Count > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún tipo de pago", "Seleccione un tipo de pago", MessageBoxButtons.OK);
                return;

            }
        }
    }
}
