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
    public partial class FormularioBuscarCliente : Form
    {

        //Campos de clase
        private Conexion conexion;
        private DataTable dtClientes;

        public FormularioBuscarCliente()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void FormularioBuscarCliente_Load(object sender, EventArgs e)
        {
            Actualiza();

        }

        private void Actualiza()
        {
            string consulta = "select dni, nombre from clientes";
            dtClientes = conexion.DameTablaCompleta(consulta);
            dataClientes.DataSource = dtClientes;


        }

        private void btnSelecciona_Click(object sender, EventArgs e)
        {
            if (dataClientes.SelectedRows.Count > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay ningún cliente seleccionado", "Seleccione un cliente", MessageBoxButtons.OK);
                return;

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtClientes = conexion.DameTablaCompleta("select dni, nombre from clientes");
            if (txtBuscar.Text != "")
            {
                string cadena = txtBuscar.Text;
                string consulta = $"select dni, nombre from clientes WHERE nombre Like '%{cadena}%' " +
                    $"OR dni Like '%{cadena}%'";

                dtClientes = conexion.DameTablaCompleta(consulta);
            }

            dataClientes.DataSource = dtClientes;
            dataClientes.Refresh();
            dataClientes.Columns[0].Visible = false;
            if (dataClientes.Rows.Count > 0)
            {
                dataClientes.Rows[0].Cells[1].Selected = true;


            }
        }
    }
}
