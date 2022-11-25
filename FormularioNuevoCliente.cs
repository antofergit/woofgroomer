using Microsoft.VisualBasic;
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
    public partial class FormularioNuevoCliente : Form
    {

        //Campos de clase
        private Conexion conexion;

        


        public FormularioNuevoCliente()
        {
            InitializeComponent();
            conexion = new Conexion();

        }

        private void FormularioNuevoCliente_Load(object sender, EventArgs e)
        {
            dateAlta.Value = DateTime.Today;
            txtDNI.Focus();

        }

        //Creamos un diccionario de codigos postales
        Dictionary<int, string> diccionarioCodigosPostales = new Dictionary<int, string>()
        {
            {41400,"Écija"},
            {41550,"Aguadulce"},
            {41380,"Alanís"},
            {41809,"Albaida Del Aljarafe"},
            {41500,"Alcalá De Guadaíra"},
            {41200,"Alcalá Del Río"},
            {41449,"Alcolea Del Río"},
            {41980,"Algaba"},
            {41661,"Algámitas"},
            {41240,"Almadén De La Plata"},
            {41111,"Almensilla"},
            {41600,"Arahal"},
            {41849,"Aznalcázar"},
            {41870,"Aznalcóllar"},
            {41570,"Badolatosa"},
            {41805,"Benacazón"},
            {41110,"Bollullos De La Mitación"},
            {41930,"Bormujos"},
            {41310,"Brenes"},
            {41220,"Burguillos"},
            {41730,"Cabezas De San Juan"},
            {41900,"Camas"},
            {41429,"Campana"},
            {41439,"Cañada Rosal"},
            {41320,"Cantillana"},
            {41410,"Carmona"},
            {41820,"Carrión De Los Céspedes"},
            {41580,"Casariche"},
            {41230,"Castilblanco De Los Arroyos"},
            {41908,"Castilleja De Guzmán"},
            {41950,"Castilleja De La Cuesta"},
            {41810,"Castilleja Del Campo"},
            {41890,"Castillo De Las Guardas"},
            {41370,"Cazalla De La Sierra"},
            {41450,"Constantina"},
            {41100,"Coria Del Río"},
            {41780,"Coripe"},
            {41760,"Coronil"},
            {41657,"Corrales"},
            {41749,"Cuervo"},
            {41701,"Dos Hermanas"},
            {41807,"Espartinas"},
            {41560,"Estepa"},
            {41420,"Fuentes De Andalucía"},
            {41888,"Garrobo"},
            {41120,"Gelves"},
            {41860,"Gerena"},
            {41565,"Gilena"},
            {41960,"Gines"},
            {41390,"Guadalcanal"},
            {41210,"Guillena"},
            {41567,"Herrera"},
            {41830,"Huévar Del Aljarafe"},
            {41140,"Isla Mayor"},
            {41630,"Lantejuela"},
            {41740,"Lebrija"},
            {41564,"Lora De Estepa"},
            {41440,"Lora Del Río"},
            {41430,"Luisiana"},
            {41897,"Madroño"},
            {41510,"Mairena Del Alcor"},
            {41927,"Mairena Del Aljarafe"},
            {41620,"Marchena"},
            {41569,"Marinaleda"},
            {41658,"Martín De La Jara"},
            {41750,"Molares"},
            {41770,"Montellano"},
            {41530,"Morón De La Frontera"},
            {41460,"Navas De La Concepción"},
            {41804,"Olivares"},
            {41640,"Osuna"},
            {41720,"Palacios Y Villafranca"},
            {41928,"Palomares Del Río"},
            {41610,"Paradas"},
            {41566,"Pedrera"},
            {41360,"Pedroso"},
            {41470,"Peñaflor"},
            {41840,"Pilas"},
            {41670,"Pruna"},
            {41540,"Puebla De Cazalla"},
            {41479,"Puebla De Los Infantes"},
            {41130,"Puebla Del Río"},
            {41250,"Real De La Jara"},
            {41309,"Rinconada"},
            {41590,"Roda De Andalucía"},
            {41880,"Ronquillo"},
            {41568,"Rubio"},
            {41909,"Salteras"},
            {41920,"San Juan De Aznalfarache"},
            {41388,"San Nicolás Del Puerto"},
            {41800,"Sanlúcar La Mayor"},
            {41970,"Santiponce"},
            {41650,"Saucejo"},
            {41001,"Sevilla"},
            {41340,"Tocina"},
            {41940,"Tomares"},
            {41806,"Umbrete"},
            {41710,"Utrera"},
            {41907,"Valencina De La Concepción"},
            {41850,"Villamanrique De La Condesa"},
            {41660,"Villanueva De San Juan"},
            {41808,"Villanueva Del Ariscal"},
            {41350,"Villanueva Del Río Y Minas"},
            {41318,"Villaverde Del Río"},
            {41520,"Viso Del Alcor"}
        };

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (pictureOK.Visible)
            {

                if (txtCodigoPostal.Text.Length == 5 && txtTelefono1.Text.Length == 9 && (txtTelefono2.Text.Length == 9 || txtTelefono2.Text.Length == 0))
                {
                    //almacenamos los valores y le asignamos un valor válido para almacenarlos en la base de datos
                    int codigoPostal, telefono1, telefono2;
                    string DNI = txtDNI.Text;
                    string nombre = txtNombre.Text;
                    string alias = txtAlias.Text;
                    DateTime fechaAlta = dateAlta.Value;

                    string direccion = txtDireccion.Text;
                    string poblacion = txtPoblacion.Text;
                    string provincia = txtProvincia.Text;
                    string correo = txtCorreo.Text;
                    string comentarios = txtComentarios.Text;

                    codigoPostal = Convert.ToInt32(txtCodigoPostal.Text);
                    telefono1 = Convert.ToInt32(txtTelefono1.Text);
                    if (txtTelefono2.Text != "")
                    {
                        telefono2 = Convert.ToInt32(txtTelefono2.Text);
                    }
                    else
                    {
                        telefono2 = 0;
                    }

                    //Si las validaciones son correctas nos disponemos a almacenar el registro
                    //Creamos los arrays donde almacenaremos los campos y sus valores
                    string[] campos = { "dni", "nombre", "alias", "fecha_alta", "direccion", "codigo_postal", "poblacion", "provincia", "telefono1", "telefono2", "email", "comentarios", "lpd" };
                    string[] valores = { DNI, nombre, alias, fechaAlta.ToString("yyyy-MM-dd"), direccion, codigoPostal.ToString(), poblacion, provincia, telefono1.ToString(), telefono2.ToString(), correo, comentarios, "0" };

                    conexion.AbreConexion();
                    string respuesta = conexion.NuevoRegistro("clientes", campos, valores);
                    conexion.CierraConexion();

                    if (respuesta == null)
                    {

                        FormularioOK frmOK = new FormularioOK("El cliente se ha creado correctamente");
                        frmOK.ShowDialog();
                        frmOK.Dispose();

                        //Despues de mostrar el mensaje de OK al guardar el nuevo cliente agregamos automaticamente una nueva mascota
                        //string registro = txtDNI.Text;
                        //FormularioNuevaEditarMascota frmNuevaMascota = new FormularioNuevaEditarMascota(true, DateTime.Now, registro);
                        //DialogResult dialogo = frmNuevaMascota.ShowDialog();

                        DialogResult = DialogResult.OK;
                        this.Close();
                        
                    }
                    else
                    {

                        string mensaje = $"No se ha podido crear el cliente.\n{respuesta}";
                        FormularioError frmError = new FormularioError(mensaje);
                        frmError.ShowDialog();
                        frmError.Dispose();

                    }


                }
                else
                {
                    string mensaje = $"Alguno de los datos numéricos no son correctos";
                    FormularioError frmError = new FormularioError(mensaje);
                    frmError.ShowDialog();
                    frmError.Dispose();

                }

            }
            else
            {
                string mensaje = $"El DNI introducido no es correcto";
                FormularioError frmError = new FormularioError(mensaje);
                frmError.ShowDialog();
                frmError.Dispose();
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            Dni dni = new Dni();



            if (dni.CompruebaDNI(txtDNI.Text))
            {
                pictureOK.Visible = true;
                pictureCancel.Visible = false;
                txtDNI.BorderColor = Color.Silver;

            }
            else
            {
                pictureOK.Visible = false;
                pictureCancel.Visible = true;
                txtDNI.BorderColor = Color.IndianRed;


            }
        }

        private void txtCodigoPostal_Leave(object sender, EventArgs e)
        {
            if (Information.IsNumeric(txtCodigoPostal.Text) && txtCodigoPostal.Text.Length == 5)
            {
                txtCodigoPostal.BorderColor = Color.Silver;
                try
                {
                    int miCP = Convert.ToInt32(txtCodigoPostal.Text);
                    if (miCP >= 41000 && miCP < 42000)
                    {
                        txtPoblacion.Text = "Sevilla";
                        txtProvincia.Text = "Sevilla";
                    }
                    txtPoblacion.Text = diccionarioCodigosPostales[miCP];
                    txtTelefono1.Focus();

                }
                catch (Exception)
                {


                }

            }
            else
            {
                txtCodigoPostal.BorderColor = Color.IndianRed;
            }
        }

        private void lblGenerarDNI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dni dni = new Dni();
            txtDNI.Text = dni.DNIaleatorio();
            pictureOK.Visible = true;
            pictureCancel.Visible = false;
            txtDNI.BorderColor = Color.Silver;
            txtNombre.Focus();
        }

        private void txtTelefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
