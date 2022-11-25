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
    public partial class FormularioClientesMascotas2 : Form
    {
        //Campos de clase
        private Conexion conexion;
        private DataTable dtClientes;
        private DataTable dtMascotas;
        private DataRow drClientes;
        private bool prueba = false;



        public FormularioClientesMascotas2()
        {
            InitializeComponent();
            conexion = new Conexion();
            
        }






        private void dataMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataMascotas.SelectedRows.Count > 0)
            {
                string registroDNI = dataMascotas.CurrentRow.Cells[4].Value.ToString();
                if (dataClientes.CurrentRow.Cells[0].Value.ToString() == registroDNI)
                {
                    //return;
                }
                else
                {
                    foreach (DataGridViewRow fila in dataClientes.Rows)
                    {
                        if (fila.Cells[0].Value.ToString() == registroDNI)
                        {
                            fila.Cells[0].Selected = true;
                            break;
                        }
                    }
                }

                txtNombreMascota.Text = dataMascotas.CurrentRow.Cells["nombre"].Value.ToString();
                txtObservaciones.Text = dataMascotas.CurrentRow.Cells["comentarios"].Value.ToString();
                string imagen = dataMascotas.CurrentRow.Cells["raza"].Value.ToString();
                img.Load($@"{Directory.GetCurrentDirectory()}\Resources\{imagen.Replace(" ", "_")}.jpg");

                //Cargamos el historial de visitas
                string consulta = $"SELECT " +
                    $"visitas.id_visita," +
                    $"strftime('%d-%m-%Y', visitas.fecha) as fecha," +
                    $"visitas.id_mascota," +
                    $"visitas.total_venta," +
                    $"visitas.historial " +
                    $"from visitas where id_mascota = {dataMascotas.CurrentRow.Cells["ID"].Value.ToString()} " +
                    $"Order By id_visita Desc";

                DataTable dtVisitas = conexion.DameTablaCompleta(consulta);
                if (dtVisitas.Rows.Count > 0)
                {
                    float importe = Convert.ToSingle(dtVisitas.Rows[0].ItemArray[3].ToString());
                    lblFecha.Text = dtVisitas.Rows[0].ItemArray[1].ToString();
                    lblImporte.Text = importe.ToString("C2");
                    string historial = "";
                    foreach (DataRow fila in dtVisitas.Rows)
                    {
                        historial += $"{fila.ItemArray[1].ToString()}:{System.Environment.NewLine}{fila.ItemArray[4].ToString()}{System.Environment.NewLine}{System.Environment.NewLine}";
                    }
                    txtHistorial.Text = historial;
                }
                else
                {
                    lblFecha.Text = "";
                    lblImporte.Text = "0,00 €";
                    txtHistorial.Text = "";

                }
            }

            lblNumeroMascotas.Text = "Número de mascotas : " + dataMascotas.Rows.Count.ToString();
            if (dataMascotas.SelectedRows.Count > 0)
            {
                


            }


        }









        private void txtBuscarMascotas_TextChanged(object sender, EventArgs e)
        {
            dtMascotas = conexion.DameTablaCompleta("Select * From listado_de_mascotas");
            if (txtBuscarMascotas.Text != "")
            {
                string cadena = txtBuscarMascotas.Text;
                string consulta = $"Select * From listado_de_mascotas WHERE ID Like '%{cadena}%' OR " +
                                                               $"nombre Like '%{cadena}%' OR " +
                                                               $"raza Like '%{cadena}%' OR " +
                                                               $"comentarios Like '%{cadena}%' OR " +
                                                               $"dni_cliente Like '%{cadena}%' OR " +
                                                               $"chip Like '%{cadena}%'";
                dtMascotas = conexion.DameTablaCompleta(consulta);
            }

            dataMascotas.DataSource = dtMascotas;
            //dataMascotas.Refresh();
            if (dataMascotas.Rows.Count > 0)
            {
                dataMascotas.Rows[0].Cells[0].Selected = true;


            }
        }

        private void txtBuscarCliente_Enter(object sender, EventArgs e)
        {
            txtBuscarMascotas.Text = "";
        }

        private void btnBorrarBusquedaMascotas_Click(object sender, EventArgs e)
        {
            txtBuscarMascotas.Text = "";
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            dtClientes = conexion.DameTablaCompleta("Select dni,nombre,alias,fecha_alta,poblacion,telefono1,email From clientes");
            if (txtBuscarCliente.Text != "")
            {
                string cadena = txtBuscarCliente.Text;
                string consulta = $"Select dni,nombre,alias,fecha_alta,poblacion,telefono1,email From clientes WHERE dni Like '%{cadena}%' OR " +
                                                               $"nombre Like '%{cadena}%' OR " +
                                                               $"alias Like '%{cadena}%' OR " +
                                                               $"direccion Like '%{cadena}%' OR " +
                                                               $"telefono1 Like '%{cadena}%' OR " +
                                                               $"email Like '%{cadena}%'";
                dtClientes = conexion.DameTablaCompleta(consulta);
            }

            dataClientes.DataSource = dtClientes;
            dataClientes.Refresh();
            if (dataClientes.Rows.Count > 0)
            {
                dataClientes.Rows[0].Cells[0].Selected = true;


            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            string registroDNI = dataClientes.SelectedRows[0].Cells[0].Value.ToString();
            string registroNombre = dataClientes.SelectedRows[0].Cells[1].Value.ToString();

            if (registroDNI == "12345678Z")
            {
                FormularioError frmError = new FormularioError("No se pueden crear mascotas para el cliente selecionado");
                frmError.ShowDialog();
                frmError.Dispose();
                return;
            }

            FormularioNuevaMascota frmNuevaMascota = new FormularioNuevaMascota();
            frmNuevaMascota.txtNombreCliente.Text = registroNombre;
            frmNuevaMascota.txtDNICliente.Text = registroDNI;
            DialogResult dialogo = frmNuevaMascota.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                ActualizaMascotas();

            }
            else
            {

            }
            frmNuevaMascota.Dispose();
        }

        private void btnEliminarMascota_Click(object sender, EventArgs e)
        {
            string IDMascota;

            if (dataMascotas.Rows.Count < 1)
            {
                FormularioError frmError = new FormularioError("No hay ninguna mascota selecionada.");
                frmError.ShowDialog();
                frmError.Dispose();
                return;
            }
            else
            {
                IDMascota = dataMascotas.CurrentRow.Cells[0].Value.ToString();
            }


            string registroNombre = dataMascotas.CurrentRow.Cells[1].Value.ToString();

            //Comprobaciones antes de eliminar

            //Comprobamos que no sea el cliente VENTA MOSTRADOR
            if (IDMascota == "2020193")
            {
                string mensajeError = $"La mascota {registroNombre} está protegida y no se puede eliminar";
                FormularioError frmError = new FormularioError(mensajeError);
                frmError.ShowDialog();
                frmError.Dispose();
                return;
            }


            string mensaje = $"Se dispone a eliminar la mascota:\n\n{IDMascota} - {registroNombre}";
            FormularioMensajeEliminar frmMensaje = new FormularioMensajeEliminar(mensaje);
            DialogResult dialogo = frmMensaje.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                string respuesta = conexion.EliminarRegistro("mascotas", "id_mascota", IDMascota);
                if (respuesta == null)
                {
                    FormularioOK frmOK = new FormularioOK("La mascota se ha eliminado correctamente");
                    frmOK.ShowDialog();
                    frmOK.Dispose();
                    ActualizaMascotas();
                }
                else
                {
                    string mensajeError = $"No se ha podido eliminar la mascota.\n{respuesta}";
                    FormularioError frmError = new FormularioError(mensajeError);
                    frmError.ShowDialog();
                    frmError.Dispose();
                }
            }
            else
            {

            }
            frmMensaje.Dispose();
        }

        private void dataClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormularioFicha frmFicha = new FormularioFicha();
            frmFicha.txtDNICliente.Text = dataClientes.CurrentRow.Cells[0].Value.ToString();
            if (dataMascotas.SelectedRows.Count > 0)
            {
                frmFicha.txtIDMascota.Text = dataMascotas.CurrentRow.Cells[0].Value.ToString();
            }

            DialogResult dialogo = frmFicha.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                ActualizaClientes(frmFicha.txtDNICliente.Text);
                ActualizaMascotas();

            }
            else
            {

            }
            frmFicha.Dispose();
        }

        private void dataMascotas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormularioFicha frmFicha = new FormularioFicha(dataMascotas.CurrentRow.Index);
            frmFicha.txtDNICliente.Text = dataClientes.CurrentRow.Cells[0].Value.ToString();
            if (dataMascotas.SelectedRows.Count > 0)
            {
                frmFicha.txtIDMascota.Text = dataMascotas.CurrentRow.Cells[0].Value.ToString();
            }

            DialogResult dialogo = frmFicha.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                ActualizaClientes(frmFicha.txtDNICliente.Text);
                ActualizaMascotas();

            }
            else
            {

            }
            frmFicha.Dispose();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string registroDNI = dataClientes.CurrentRow.Cells[0].Value.ToString();
            string registroNombre = dataClientes.CurrentRow.Cells[1].Value.ToString();

            //Comprobaciones antes de eliminar

            //Comprobamos que no sea el cliente VENTA MOSTRADOR
            if (registroDNI == "12345678Z")
            {
                string mensajeError = $"El usuario {registroNombre} está protegido y no se puede eliminar";
                FormularioError frmError = new FormularioError(mensajeError);
                frmError.ShowDialog();
                frmError.Dispose();
                return;
            }

            //Comprobamos que el cliente no tenga mascotas asociadas
            if (dataMascotas.Rows.Count != 0)
            {
                string mensajeError = $"El cliente tiene mascotas asociadas. Debe eliminar estas mascotas antes de eliminar el cliente";
                FormularioError frmError = new FormularioError(mensajeError);
                frmError.ShowDialog();
                frmError.Dispose();
                return;
            }



            string mensaje = $"Se dispone a eliminar el cliente:\n\n{registroDNI} - {registroNombre}";
            FormularioMensajeEliminar frmMensaje = new FormularioMensajeEliminar(mensaje);
            DialogResult dialogo = frmMensaje.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                string respuesta = conexion.EliminarRegistro("clientes", "dni", registroDNI);
                if (respuesta == null)
                {
                    FormularioOK frmOK = new FormularioOK("El cliente se ha eliminado correctamente");
                    frmOK.ShowDialog();
                    frmOK.Dispose();
                    ActualizaClientes();
                    ActualizaMascotas();
                }
                else
                {
                    string mensajeError = $"No se ha podido eliminar el cliente.\n{respuesta}";
                    FormularioError frmError = new FormularioError(mensajeError);
                    frmError.ShowDialog();
                    frmError.Dispose();
                }
            }
            else
            {

            }
            frmMensaje.Dispose();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            string registroDNI = "", registroNombre = "";
            bool nuevaMascota = false;

            FormularioNuevoCliente frmNuevoCliente = new FormularioNuevoCliente();
            DialogResult dialogo = frmNuevoCliente.ShowDialog();
            if (dialogo == DialogResult.OK)
            {

                if (frmNuevoCliente.checkNuevaMascota.Checked)
                {
                    registroDNI = frmNuevoCliente.txtDNI.Text;
                    registroNombre = frmNuevoCliente.txtNombre.Text;
                    nuevaMascota = true;

                }



                ActualizaClientes(frmNuevoCliente.txtDNI.Text);
                ActualizaMascotas();
            }
            else
            {

            }
            frmNuevoCliente.Dispose();


            if (nuevaMascota)
            {
                FormularioNuevaMascota frmNuevaMascota = new FormularioNuevaMascota();
                frmNuevaMascota.txtNombreCliente.Text = registroNombre;
                frmNuevaMascota.txtDNICliente.Text = registroDNI;
                DialogResult dialogo2 = frmNuevaMascota.ShowDialog();
                if (dialogo2 == DialogResult.OK)
                {
                    ActualizaMascotas();

                }
                else
                {

                }
                frmNuevaMascota.Dispose();
            }
        }

        private void dataClientes_DataSourceChanged(object sender, EventArgs e)
        {
            lblNumeroClientes.Text = "Número de clientes : " + dataClientes.Rows.Count.ToString();
        }

        private void dataMascotas_DataSourceChanged(object sender, EventArgs e)
        {
            lblNumeroMascotas.Text = "Número de mascotas : " + dataMascotas.Rows.Count.ToString();
            if (dataMascotas.SelectedRows.Count > 0)
            {
                txtNombreMascota.Text = dataMascotas.CurrentRow.Cells["nombre"].Value.ToString();
                txtObservaciones.Text = dataMascotas.CurrentRow.Cells["comentarios"].Value.ToString();
                string imagen = dataMascotas.CurrentRow.Cells["raza"].Value.ToString();
                img.Load($@"{Directory.GetCurrentDirectory()}\Resources\{imagen.Replace(" ", "_")}.jpg");

                //Cargamos el historial de visitas
                string consulta = $"SELECT " +
                    $"visitas.id_visita," +
                    $"strftime('%d-%m-%Y', visitas.fecha) as fecha," +
                    $"visitas.id_mascota," +
                    $"visitas.total_venta," +
                    $"visitas.historial " +
                    $"from visitas where id_mascota = {dataMascotas.CurrentRow.Cells["ID"].Value.ToString()} " +
                    $"Order By id_visita Desc";

                DataTable dtVisitas = conexion.DameTablaCompleta(consulta);
                if (dtVisitas.Rows.Count > 0)
                {
                    float importe = Convert.ToSingle(dtVisitas.Rows[0].ItemArray[3].ToString());
                    lblFecha.Text = dtVisitas.Rows[0].ItemArray[1].ToString();
                    lblImporte.Text = importe.ToString("C2");
                    string historial = "";
                    foreach (DataRow fila in dtVisitas.Rows)
                    {
                        historial += $"{fila.ItemArray[1].ToString()}:{System.Environment.NewLine}{fila.ItemArray[4].ToString()}{System.Environment.NewLine}";
                    }
                    txtHistorial.Text = historial;
                }
                else
                {
                    lblFecha.Text = "";
                    lblImporte.Text = "0,00 €";
                    txtHistorial.Text = "";

                }


            }
        }

        private void txtBuscarMascotas_Enter(object sender, EventArgs e)
        {
            txtBuscarCliente.Text = "";


            //Llenamos el grid de mascotas
            string consulta = $"SELECT * FROM listado_de_mascotas";
            dtMascotas = conexion.DameTablaCompleta(consulta);
            dataMascotas.DataSource = dtMascotas;
            dataMascotas.Rows[0].Selected = true;
            lblNumeroMascotas.Text = "Número de mascotas : " + dataMascotas.Rows.Count.ToString();
            dataMascotas.Columns["dni_cliente"].Visible = false;
        }

        private void FormularioClientesMascotas2_Load(object sender, EventArgs e)
        {
            ActualizaClientes("12345678Z");

            ActualizaMascotas();


            //Asignamos el tamaño a las columnas del grid Clientes
            dataClientes.Columns[0].Width = 100;
            dataClientes.Columns[2].Width = 100;
            dataClientes.Columns[3].Width = 100;
            dataClientes.Columns[1].Width = dataClientes.Width - 300;
            dataClientes.Columns[4].Visible = false;



            //Asignamos el tamaño a las columnas del grid Mascotas
            dataMascotas.Columns[0].Width = 100;
            dataMascotas.Columns[1].Width = 130;
            dataMascotas.Columns[2].Width = 200;
            dataMascotas.Columns[3].Visible = false;
            //dataMascotas.Columns[4].Visible = false;
            dataMascotas.Columns[5].Visible = false;
            dataMascotas.Columns[6].Width = dataMascotas.Width - 430;

        }

        private void ActualizaClientes(string ultimoRegistro = "12345678Z")
        {
            //Creamos la consulta para llenar el dataGridView con la lista de clientes
            string consulta = "SELECT * FROM listado_de_clientes_grid";
            dtClientes = conexion.DameTablaCompleta(consulta);
            drClientes = dtClientes.Rows[0];
            dataClientes.DataSource = dtClientes;
            lblNumeroClientes.Text = "Número de clientes : " + dataClientes.Rows.Count.ToString();

            //Hacemos que se active el último registro activo
            foreach (DataGridViewRow fila in dataClientes.Rows)
            {
                if (fila.Cells[0].Value.ToString() == ultimoRegistro)
                {
                    fila.Cells[0].Selected = true;
                    ActualizaMascotas();
                    return;
                }
            }

        }

        private void ActualizaMascotas()
        {
            //Llenamos el grid de mascotas
            string registroDNI = dataClientes.SelectedRows[0].Cells[0].Value.ToString();
            string consulta = $"SELECT * FROM listado_de_mascotas WHERE dni_cliente = '{registroDNI}'";
            dtMascotas = conexion.DameTablaCompleta(consulta);
            dataMascotas.DataSource = dtMascotas;
            lblNumeroMascotas.Text = "Número de mascotas : " + dataMascotas.Rows.Count.ToString();
            dataMascotas.Columns["dni_cliente"].Visible = false;
            if (dataMascotas.SelectedRows.Count > 0)
            {
                txtNombreMascota.Text = dataMascotas.CurrentRow.Cells["nombre"].Value.ToString();
            }
        }

        private void btnBorrarBusquedaCliente_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Text = "";
        }

        private void dataClientes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataClientes.SelectedRows.Count > 0)
            {
                //Obtenemos el DNI del cliente seleccionado
                string registroDNI = dataClientes.CurrentRow.Cells[0].Value.ToString();
                //Llenamos el grid de mascotas
                string consulta = $"SELECT * FROM listado_de_mascotas WHERE dni_cliente = '{registroDNI}'";
                dtMascotas = conexion.DameTablaCompleta(consulta);

                dataMascotas.DataSource = dtMascotas;
                dataMascotas.Refresh();
                if (dataMascotas.Rows.Count > 0)
                {
                    dataMascotas.Rows[0].Selected = true;
                }

            }
        }



        private void btnAbrirFicha_Click(object sender, EventArgs e)
        {
            FormularioFicha frmFicha = new FormularioFicha(dataMascotas.CurrentRow.Index);
            frmFicha.txtDNICliente.Text = dataClientes.CurrentRow.Cells[0].Value.ToString();
            if (dataMascotas.SelectedRows.Count > 0)
            {
                frmFicha.txtIDMascota.Text = dataMascotas.CurrentRow.Cells[0].Value.ToString();
            }

            DialogResult dialogo = frmFicha.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                ActualizaClientes(frmFicha.txtDNICliente.Text);
                ActualizaMascotas();

            }
            else
            {

            }
            frmFicha.Dispose();
        }

        private void btnNuevaVisita_Click(object sender, EventArgs e)
        {
            if (dataMascotas.SelectedRows.Count > 0)
            {
                FormularioNuevaVisita frmNuevaVisita = new FormularioNuevaVisita(dataMascotas.CurrentRow.Cells["dni_cliente"].Value.ToString(), dataMascotas.CurrentRow.Cells["cliente"].Value.ToString(), dataMascotas.CurrentRow.Cells["ID"].Value.ToString(), txtNombreMascota.Text);
                frmNuevaVisita.img.Image = img.Image;
                DialogResult dialogo = frmNuevaVisita.ShowDialog();
                if (dialogo == DialogResult.OK)
                {
                }
                else
                {
                }
                frmNuevaVisita.Dispose();
            }
            
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            if (dataMascotas.SelectedRows.Count > 0)
            {
                string trabajo = "";

                FormularioTrabajo frmTrabajo = new FormularioTrabajo();
                DialogResult dialogo = frmTrabajo.ShowDialog();
                if (dialogo == DialogResult.OK)
                {
                    trabajo = frmTrabajo.txtTrabajo.Text;
                    string idMascota = dataMascotas.CurrentRow.Cells["ID"].Value.ToString();
                    string nombre = dataMascotas.CurrentRow.Cells["Nombre"].Value.ToString();
                    string raza = dataMascotas.CurrentRow.Cells["raza"].Value.ToString();
                    Image imagen = img.Image;
                    string dniCliente = dataMascotas.CurrentRow.Cells["dni_cliente"].Value.ToString();
                    string cliente = dataMascotas.CurrentRow.Cells["Cliente"].Value.ToString();
                    string telefono = dataMascotas.CurrentRow.Cells["telefono"].Value.ToString();


                    //Mascotas actual = new Mascotas(idMascota,nombre,raza,imagen,dniCliente,cliente,trabajo);
                    Mascotas.listado.Add(new Mascotas(idMascota, nombre, raza, imagen, dniCliente, cliente, trabajo, telefono));
                    MessageBox.Show("La mascota ha sido añadida a la sala", "En Sala", MessageBoxButtons.OK);
                    //this.Close();
                }
                else
                {

                }

                
            }
            
        }
    }
}
