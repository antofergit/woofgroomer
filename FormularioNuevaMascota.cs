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


    public partial class FormularioNuevaMascota : Form
    {

        //Campos de clase
        private Conexion conexion;
        private DataTable dtClientes;
        private DataTable dtRazas;
        


        

        public FormularioNuevaMascota()
        {
            InitializeComponent();
            conexion = new Conexion();
            dtClientes = conexion.DameTablaCompleta("SELECT dni, nombre FROM CLIENTES WHERE dni <> '12345678Z'");
            dtRazas = conexion.DameTablaCompleta("SELECT * FROM RAZAS order by raza");
        }

        private void FormularioNuevaMascota_Load(object sender, EventArgs e)
        {

            

            img.Image = Properties.Resources.affenpinscher;
        
            //Llenamos el combo de razas
            //cmbRaza.DataSource = dtRazas;
            //cmbRaza.DisplayMember = "raza";
            //cmbRaza.ValueMember = "id_raza";

            dateAlta.Value = DateTime.Today;
            dateNacimiento.Value = DateTime.Today;

            //cmbRaza.Focus();

            txtIDMascota.Text = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss").Replace("-","");


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private bool ValidaFormulario()
        {
            bool validacion = true;

            txtNombre.BorderColor = Color.Silver;
            
            txtIDMascota.BorderColor = Color.Silver;
            txtChip.BorderColor = Color.Silver;
            txtNombreCliente.BorderColor = Color.Silver;
            txtDNICliente.BorderColor = Color.Silver;
            numericPeso.BorderColor = Color.Silver;

            if (txtNombre.Text == string.Empty) { validacion = false; txtNombre.BorderColor = Color.Red; txtNombre.Focus(); }
            if (txtChip.Text == string.Empty) { validacion = false; txtChip.BorderColor = Color.Red; txtChip.Focus(); }
            if (numericPeso.Text == string.Empty) { validacion = false; numericPeso.BorderColor = Color.Red; numericPeso.Focus(); }
            if (!validacion)
            {
                FormularioError frmError = new FormularioError("Debe rellenar los datos marcados en rojo.");
                frmError.ShowDialog();
                frmError.Dispose();
            }

            return validacion;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {

                conexion.AbreConexion();
                ////obtenemos el ID de la raza selecionada
                //DataRow drRaza = dtRazas.Rows[ComboRaza.SelectedIndex];
                //string id_raza = drRaza.ItemArray[0].ToString();

                //Obtenemos los campos y valores para realizar la consulta de agregar nueva mascota
                string[] campos = new string[] 
                { 
                    "id_mascota", 
                    "chip", 
                    "nombre", 
                    "raza", 
                    "peso", 
                    "fecha_alta", 
                    "fecha_nacimiento",
                    "comentarios", 
                    "dni_cliente" 
                };
                string[] valores = new string[] 
                { 
                    txtIDMascota.Text, 
                    txtChip.Text, 
                    txtNombre.Text, 
                    txtRaza.Tag.ToString(), 
                    numericPeso.Text.Replace(",","."), 
                    dateAlta.Value.ToString("yyyy-MM-dd"),
                    dateNacimiento.Value.ToString("yyyy-MM-dd"),
                    txtComentarios.Text, 
                    txtDNICliente.Text 
                };

                //Ejecutamos la consulta para agregar una nueva mascota
                string respuesta = null;
                respuesta = conexion.NuevoRegistro("mascotas", campos, valores);
               
                if (respuesta != null)
                {
                    FormularioError frmError = new FormularioError($"No se ha podido agregar la nueva Mascota\n{respuesta}");
                    frmError.ShowDialog();
                    frmError.Dispose();
                }
                else
                {

                    FormularioOK frmOK = new FormularioOK("La nueva mascota se ha añadido correctamente");
                    frmOK.ShowDialog();
                    frmOK.Dispose();

                    DialogResult = DialogResult.OK;
                    this.Close();


                }
                conexion.CierraConexion();

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void cmbRaza_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            txtNombre.Focus();
        }

        



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormularioBuscarRaza frmBuscar = new FormularioBuscarRaza();
            DialogResult dialogo = frmBuscar.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                txtRaza.Text = frmBuscar.dataRazas.CurrentRow.Cells[1].Value.ToString();
                txtRaza.Tag = frmBuscar.dataRazas.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Focus();
            }
            else
            {

            }
            frmBuscar.Dispose();

        }

        private void txtRaza_TextChanged(object sender, EventArgs e)
        {
            img.Load($@"{Directory.GetCurrentDirectory()}\Resources\{txtRaza.Text.Replace(" ", "_")}.jpg");
        }
    }
}
