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
    public partial class FormularioBuscarMascota : Form
    {
        //Campos de clase
        private Conexion conexion;
        private DataTable dtMascotas;

        public FormularioBuscarMascota()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void FormularioBuscarMascota_Load(object sender, EventArgs e)
        {
            
            Actualiza();

        }

        private void Actualiza()
        {
            string consulta = "select ID, nombre, raza, cliente from listado_de_mascotas";
            dtMascotas = conexion.DameTablaCompleta(consulta);
            dataMascotas.DataSource = dtMascotas;
            dataMascotas.Columns[0].Visible = false;

        }

        private void btnSelecciona_Click(object sender, EventArgs e)
        {
            if (dataMascotas.SelectedRows.Count > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay ninguna mascota seleccionada", "Seleccione una mascota", MessageBoxButtons.OK);
                return;

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtMascotas = conexion.DameTablaCompleta("select ID, nombre, raza, cliente from listado_de_mascotas");
            if (txtBuscar.Text != "")
            {
                string cadena = txtBuscar.Text;
                string consulta = $"select ID, nombre, raza, cliente from listado_de_mascotas WHERE nombre Like '%{cadena}%'";

                dtMascotas = conexion.DameTablaCompleta(consulta);
            }

            dataMascotas.DataSource = dtMascotas;
            dataMascotas.Refresh();
            dataMascotas.Columns[0].Visible = false;
            if (dataMascotas.Rows.Count > 0)
            {
                dataMascotas.Rows[0].Cells[1].Selected = true;


            }
        }
    }
}
