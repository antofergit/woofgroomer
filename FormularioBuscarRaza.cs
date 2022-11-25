using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoofGroomer
{
    public partial class FormularioBuscarRaza : Form
    {

        //Campos de clase
        private Conexion conexion;
        private DataTable dtRazas;

        public FormularioBuscarRaza()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void FormularioBuscarRaza_Load(object sender, EventArgs e)
        {
            Actualiza();

        }

        private void Actualiza() 
        {
            dtRazas = conexion.DameTablaCompleta("select id_raza, raza from razas");
            dataRazas.DataSource = dtRazas;
            dataRazas.Refresh();
            dataRazas.Columns[0].Visible = false;
            if (dataRazas.Rows.Count > 0)
            {
                dataRazas.Rows[0].Cells[1].Selected = true;
                txtBuscar.Text = "";

            }
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtRazas = conexion.DameTablaCompleta("Select id_raza, raza From razas");
            if (txtBuscar.Text != "")
            {
                string cadena = txtBuscar.Text;
                string consulta = $"Select id_raza, raza From razas WHERE raza Like '%{cadena}%'";

                dtRazas = conexion.DameTablaCompleta(consulta);
            }

            dataRazas.DataSource = dtRazas;
            dataRazas.Refresh();
            dataRazas.Columns[0].Visible = false;
            if (dataRazas.Rows.Count > 0)
            {
                dataRazas.Rows[0].Cells[1].Selected = true;


            }
        }

        private void btnSelecciona_Click(object sender, EventArgs e)
        {
            if (dataRazas.SelectedRows.Count > 0)  //Hay una raza seleccionada
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else    //No hay ninguna raza seleccionada
            {
                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    MessageBox.Show("Debe seleccionar una raza o indicar el nombre de la nueva raza para crearla", "Seleccionar Raza", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    string mensaje = $"¿Desea crear una nueva raza con el nombre {txtBuscar.Text}?";
                    string titulo = "Nueva Raza";
                    DialogResult dialogo = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogo == DialogResult.OK)
                    {
                        string tabla = "razas";
                        string[] campos = new string[]
                        {
                            "id_raza",
                            "raza",
                            "img"
                        };
                        string[] valores = new string[]
                        {
                            DateTime.Now.ToString("yyyyMMddHHmmss"),
                            txtBuscar.Text.ToUpper(),
                            ""
                        };
                        string respuesta = conexion.NuevoRegistro(tabla, campos, valores);
                        if (respuesta == null)
                        {
                            MessageBox.Show($"Se ha creado la nueva raza {txtBuscar.Text}", "Nueva Raza", MessageBoxButtons.OK);
                            Actualiza();
                        }
                        else
                        {
                            MessageBox.Show($"No se ha podido crear la nueva raza.\n{respuesta}", "Nueva Raza", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";

        }

        private void dataRazas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecciona_Click(sender, e);
        }

        private void dataRazas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                img.Load($@"{Directory.GetCurrentDirectory()}\Resources\{dataRazas.CurrentRow.Cells[1].Value.ToString().Replace(" ", "_")}.jpg");
            }
            catch (Exception)
            {

                img.Load($@"{Directory.GetCurrentDirectory()}\Resources\sin_imagen.png");
            }
            
        }
    }
}
