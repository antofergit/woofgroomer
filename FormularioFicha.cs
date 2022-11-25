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
    public partial class FormularioFicha : Form
    {

        //Campos de clase
        private Conexion conexion;
        private DataTable dtRazas;
        private DataTable dtClientes;
        private DataTable dtMascotas;
        private DataRow drCliente;
        private DataRow drMascota;
        private bool hayCambios;
        private int posMascota;
        private string dniCliente;

        
        public FormularioFicha(int posMascota = 0)
        {
            InitializeComponent();
            conexion = new Conexion();
            hayCambios = false;
            dtRazas = conexion.DameTablaCompleta("SELECT * FROM razas order by raza");
            this.posMascota = posMascota;

        }

        private void FormularioFicha_Load(object sender, EventArgs e)
        {
            
            dtClientes = conexion.DameTablaCompleta($"select * from clientes where dni = '{txtDNICliente.Text}'");
            dniCliente = txtDNICliente.Text;
            drCliente = dtClientes.Rows[0];
            if (txtIDMascota.Text != "")
            {
                dtMascotas = conexion.DameTablaCompleta($"select * from mascotas where dni_cliente = '{txtDNICliente.Text}'");
                try
                {
                    drMascota = dtMascotas.Rows[posMascota];
                }
                catch (Exception)
                {

                    posMascota = 0;
                    drMascota = dtMascotas.Rows[posMascota];
                }

                //Llenamos el comboBox con las razas almacenadas en la base de datos
                cmbRaza.DataSource = dtRazas;
                cmbRaza.DisplayMember = "raza";
                cmbRaza.ValueMember = "id_raza";
                
                CompletaMascota();
            }
            else
            {
                //Adaptamos el formulario a cliente sin mascota
                btnSiguiente.Visible = false;
                dateAltaMascota.Value = DateTime.Today;
                txtNombreMascota.Enabled = false;
                cmbRaza.Enabled = false;
                txtChipMascota.Enabled = false;
                numericPeso.Enabled = false;
                dateAltaMascota.Enabled = false;
                txtComentariosMascota.Enabled = false;
            }


            CompletaCliente();

            

        }

        private void CompletaCliente()
        {
            //Completamos los datos del cliente a mostrar por el formulario
            txtNombreCliente.Text = drCliente.ItemArray[1].ToString();
            dateAltaCliente.Value = Convert.ToDateTime(drCliente.ItemArray[3].ToString());
            txtDireccionCliente.Text = drCliente.ItemArray[4].ToString();
            txtCodigoPostalCliente.Text = drCliente.ItemArray[5].ToString();
            txtPoblacionCliente.Text = drCliente.ItemArray[6].ToString();
            txtProvinciaCliente.Text = drCliente.ItemArray[7].ToString();
            txtTelefono1Cliente.Text = drCliente.ItemArray[8].ToString();
            txtTelefono2Cliente.Text = drCliente.ItemArray[9].ToString();
            txtCorreoCliente.Text = drCliente.ItemArray[10].ToString();
            txtComentariosCliente.Text = drCliente.ItemArray[11].ToString();
        }

        private void CompletaMascota()
        {
            //Completamos los datos de la mascota a mostrar por el formulario
            txtIDMascota.Text = drMascota.ItemArray[0].ToString();
            dateAltaMascota.Value = Convert.ToDateTime(drMascota.ItemArray[5].ToString());
            dateNacimiento.Value = Convert.ToDateTime(drMascota.ItemArray[6].ToString());
            txtChipMascota.Text = drMascota.ItemArray[1].ToString();
            numericPeso.Value = Convert.ToDecimal(drMascota.ItemArray[4].ToString().Replace(".",","));
            txtNombreMascota.Text = drMascota.ItemArray[2].ToString();
            cmbRaza.SelectedValue = drMascota.ItemArray[3].ToString();
            txtComentariosMascota.Text = drMascota.ItemArray[7].ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            hayCambios = true;

        }

        private void numericPeso_ValueChanged(object sender, EventArgs e)
        {
            hayCambios = true;

        }

        private void dateAlta_ValueChanged(object sender, EventArgs e)
        {
            hayCambios = true;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (hayCambios)
            {
               
                if (ValidaCliente())
                {
                    //creamos la consulta para la actualización del cliente
                    string consulta = $"UPDATE clientes SET " +
                        $"dni = '{txtDNICliente.Text}', " +
                        $"nombre = '{txtNombreCliente.Text}', " +
                        $"fecha_alta = '{dateAltaCliente.Value.ToString("yyyy-MM-dd")}', " +
                        $"direccion = '{txtDireccionCliente.Text}', " +
                        $"codigo_postal = '{txtCodigoPostalCliente.Text}', " +
                        $"poblacion = '{txtPoblacionCliente.Text}', " +
                        $"provincia = '{txtProvinciaCliente.Text}', " +
                        $"telefono1 = '{txtTelefono1Cliente.Text}', " +
                        $"telefono2 = '{txtTelefono2Cliente.Text}', " +
                        $"email = '{txtCorreoCliente.Text}', " +
                        $"comentarios = '{txtComentariosCliente.Text}' " +
                        $"WHERE dni = '{dniCliente}'";

                    string respuesta = conexion.ActualizaRegistro(consulta);
                    if (respuesta != null)
                    {
                        FormularioError frmError = new FormularioError($"No se ha podido actualizar el registro.\n{respuesta}");
                        frmError.ShowDialog();
                        frmError.Dispose();
                        return;
                    }

                    conexion.ActualizaRegistro($"update mascotas set id_cliente = '{txtDNICliente.Text}' where mascotas.id_cliente = '{dniCliente}'");
                    conexion.ActualizaRegistro($"update visitas set dni_cliente = '{txtDNICliente.Text}' where visitas.dni_cliente = '{dniCliente}'");

                    if (txtIDMascota.Text != "")
                    {
                        if (ValidaMascota())
                        {
                            //creamos la consulta para la actualización de la mascota
                            consulta = $"UPDATE mascotas SET " +
                                $"chip = '{txtChipMascota.Text}', " +
                                $"nombre = '{txtNombreMascota.Text}', " +
                                $"raza = {cmbRaza.SelectedValue}, " +
                                $"peso = {numericPeso.Value.ToString().Replace(",",".")}, " +
                                $"fecha_alta = '{dateAltaMascota.Value.ToString("yyyy-MM-dd")}', " +
                                $"fecha_nacimiento = '{dateNacimiento.Value.ToString("yyyy-MM-dd")}', " +
                                $"comentarios = '{txtComentariosMascota.Text}', " +
                                $"dni_cliente = '{txtDNICliente.Text}' " +
                                $"WHERE id_mascota = {txtIDMascota.Text};";

                            respuesta = conexion.ActualizaRegistro(consulta);
                            if (respuesta != null)
                            {
                                FormularioError frmError = new FormularioError($"No se ha podido actualizar el registro.\n{respuesta}");
                                frmError.ShowDialog();
                                frmError.Dispose();
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else
                {
                    return;
                }

                DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private bool ValidaCliente()
        {
            string respuesta = null;
            if (txtNombreCliente.Text == "") { respuesta = "Debe introducir un nombre de cliente."; }
            bool retorno;
            if (respuesta == null)
            {
                return true;
            }
            else
            {
                FormularioError frmError = new FormularioError(respuesta);
                frmError.ShowDialog();
                frmError.Dispose();
                return false;
            }
        }

        private bool ValidaMascota()
        {
            string respuesta = null;
            if (txtNombreMascota.Text == "") { respuesta = "Debe introducir un nombre de mascota."; }
            bool retorno;
            if (respuesta == null)
            {
                return true;
            }
            else
            {
                FormularioError frmError = new FormularioError(respuesta);
                frmError.ShowDialog();
                frmError.Dispose();
                return false;
            }
        }

        private void cmbRaza_SelectedValueChanged(object sender, EventArgs e)
        {
            imgMascota.Load($@"{Directory.GetCurrentDirectory()}\Resources\{cmbRaza.Text.Replace(" ", "_")}.jpg");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            posMascota++;
            try
            {
                drMascota = dtMascotas.Rows[posMascota];
            }
            catch (Exception)
            {

                posMascota = 0;
                drMascota = dtMascotas.Rows[posMascota];
            }
            
            CompletaMascota();

        }

        private void btnNuevaVisita_Click(object sender, EventArgs e)
        {

            //Antes de abrir el formulario actualizamos la base de datos si ha habido cambios
            btnAceptar_Click(sender, e);

            //Escondemos el formulario de ficha
            this.Opacity = 0;


            FormularioNuevaVisita frmNuevaVisita = new FormularioNuevaVisita(txtDNICliente.Text, txtNombreCliente.Text, txtIDMascota.Text, txtNombreMascota.Text);
            frmNuevaVisita.img.Image = imgMascota.Image;
            DialogResult dialogo = frmNuevaVisita.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Opacity = 1;
            }
            frmNuevaVisita.Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDNICliente_TextChanged(object sender, EventArgs e)
        {
            hayCambios = true;
        }
    }
}
