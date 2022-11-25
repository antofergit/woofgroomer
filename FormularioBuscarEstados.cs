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
    public partial class FormularioBuscarEstados : Form
    {

        //campoos de clase
        private Conexion conexion;
        private DataTable dtEstados;

        public FormularioBuscarEstados()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";

        }

        private void FormularioBuscarEstados_Load(object sender, EventArgs e)
        {
            Actualiza();

        }

        private void Actualiza()
        {
            string consulta = "select id_estado, descripcion from estados";
            dtEstados = conexion.DameTablaCompleta(consulta);
            dataEstados.DataSource = dtEstados;
            dataEstados.Columns[0].Visible = false;


        }

        private void btnSelecciona_Click(object sender, EventArgs e)
        {
            if (dataEstados.SelectedRows.Count > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay ningún estado seleccionado", "Selecciones Estado", MessageBoxButtons.OK);
                return;

            }
        }
    }
}
