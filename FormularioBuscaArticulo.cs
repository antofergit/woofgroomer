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
    public partial class FormularioBuscaArticulo : Form
    {
        //Campos de clase
        private DataTable dtArticulos;
        private Conexion conexion;
        public bool nuevoArticulo { get; set; }

        public FormularioBuscaArticulo()
        {
            InitializeComponent();
            conexion = new Conexion();
            nuevoArticulo = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormularioBuscaArticulo_Load(object sender, EventArgs e)
        {
            string consulta = "select * from listado_de_productos";
            dtArticulos = conexion.DameTablaCompleta(consulta);
            dataArticulos.DataSource = dtArticulos;

            //Damos formato al dataGrid
            dataArticulos.Columns[0].HeaderText = "ID";
            dataArticulos.Columns[0].Width = 100;
            dataArticulos.Columns[1].HeaderText = "Descripción";
            dataArticulos.Columns[1].Width = 250;
            dataArticulos.Columns[2].HeaderText = "Precio de Venta";
            dataArticulos.Columns[2].Width = 100;
            dataArticulos.Columns[2].DefaultCellStyle.Format = string.Format("C2");
            //dataArticulos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataArticulos.Columns[3].Visible = false;
            dataArticulos.Columns[4].HeaderText = "Porcentaje";
            dataArticulos.Columns[4].Width = 100;
            //dataArticulos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtArticulos = conexion.DameTablaCompleta("SELECT * FROM listado_de_productos");

            if (txtBuscar.Text != "")
            {
                string cadena = txtBuscar.Text;
                string consulta = $"Select * From listado_de_productos WHERE id_producto_servicio Like '%{cadena}%' OR " +
                                                               $"descripcion Like '%{cadena}%'";
                dtArticulos = conexion.DameTablaCompleta(consulta);

            }

            dataArticulos.DataSource = dtArticulos;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            txtBuscar.Text = txtBuscar.Text.Trim();
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void btnSelecciona_Click(object sender, EventArgs e)
        {
            if (dataArticulos.SelectedRows.Count == 0 && !string.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                string mensaje = $"El artículo {txtBuscar.Text.Trim()} no existe. ¿Desea crearlo?";
                string titulo = "Artículo no encontrado";
                DialogResult dialogo = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    //Activamos la creacion del articulo
                    nuevoArticulo = true;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;

                }
            }
            else
            {
                DialogResult = DialogResult.OK;
            }

            this.Close();

        }

        private void dataArticulos_DoubleClick(object sender, EventArgs e)
        {
            btnSelecciona_Click(sender, e);
        }
    }
}
