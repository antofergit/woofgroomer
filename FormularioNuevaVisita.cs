using Guna.UI2.WinForms;
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
    public partial class FormularioNuevaVisita : Form
    {

        //Campos de clase
        private Conexion conexion;
        private string dniCliente, nombreCliente, idMascota, nombreMascota;
        private DataTable dtProductosServicios;
        private DataTable dtImpuestos;
        private DataTable dtBuscaProductoServicio;
        private DataTable dtTiposPagos;
        private float cantidad, neto, porcentajeImpuestos, importeImpuestos, precioVenta, total;



        
        public FormularioNuevaVisita(string dniCliente, string nombreCliente, string idMascota, string nombreMascota)
        {
            InitializeComponent();

            conexion = new Conexion();

            dtImpuestos = conexion.DameTablaCompleta("select * from impuestos");
            dtTiposPagos = conexion.DameTablaCompleta("select * from tipo_pago");

            this.dniCliente = dniCliente;
            this.nombreCliente = nombreCliente;
            this.idMascota = idMascota;
            this.nombreMascota = nombreMascota;
        }
        private void FormularioNuevaVisita_Load(object sender, EventArgs e)
        {
            txtIDVisita.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            dateFecha.Value = DateTime.Today;
            txtDNICliente.Text = dniCliente;
            txtNombreCliente.Text = nombreCliente;
            txtIDMascota.Text = idMascota;
            txtNombreMascota.Text = nombreMascota;

            cmbImpuestos.DataSource = dtImpuestos;
            cmbImpuestos.DisplayMember = "porcentaje_mostrar";
            cmbImpuestos.ValueMember = "porcentaje_valor";
            if (cmbImpuestos.Items.Count > 0)
            {
                cmbImpuestos.SelectedIndex = cmbImpuestos.Items.Count - 1;
            }

            
            
            calculaDesdeNeto();
            



 
            CalculaTotales();


        }

        private void calculaDesdeNeto()
        {
            //Calculamos
            cantidad = Convert.ToSingle(txtCantidad.Text);
            neto = Convert.ToSingle(txtNeto.Text);
            porcentajeImpuestos = Convert.ToSingle(cmbImpuestos.SelectedValue.ToString());
            importeImpuestos = neto * porcentajeImpuestos;
            precioVenta = neto + importeImpuestos;
            total = precioVenta * cantidad;

            //Mostramos valores
            txtImpuestos.Text = importeImpuestos.ToString("F2");
            txtPrecioVenta.Text = precioVenta.ToString("F2");
            txtTotalImporte.Text = total.ToString("F2");

        }

        private void calculaDesdeCantidad()
        {
            //Calculamos
            cantidad = Convert.ToSingle(txtCantidad.Text);
            total = precioVenta * cantidad;

            //Mostramos valores
            txtTotalImporte.Text = total.ToString("F2");


        }

        private void calculaDesdeBruto()
        {
            //Calculamos
            cantidad = Convert.ToSingle(txtCantidad.Text);
            precioVenta = Convert.ToSingle(txtPrecioVenta.Text);
            porcentajeImpuestos = Convert.ToSingle(cmbImpuestos.SelectedValue.ToString());
            neto = precioVenta / (porcentajeImpuestos + 1);
            importeImpuestos = precioVenta - neto;
            total = precioVenta * cantidad;

            //Mostramos valores
            txtNeto.Text = neto.ToString("F2");
            txtImpuestos.Text = importeImpuestos.ToString("F2");
            txtTotalImporte.Text = total.ToString("F2");
            

        }



        private void CalculaTotales()
        {
            float ticketNeto = 0;
            float ticketImpuestos = 0;
            float ticketCantidad2 = 0;
            float ticketTotal = 0;

            foreach (ListViewItem item in lista.Items)
            {
                ticketCantidad2 = Convert.ToSingle(item.SubItems[5].Text);
                ticketNeto += (Convert.ToSingle(item.SubItems[2].Text.Replace("€", "").Trim()) * ticketCantidad2);
                ticketImpuestos += (Convert.ToSingle(item.SubItems[3].Text.Replace("€", "").Trim()) * ticketCantidad2);
                ticketTotal += Convert.ToSingle(item.SubItems[6].Text.Replace("€", "").Trim());
            }

            lblNeto.Text = ticketNeto.ToString("C2");
            lblImpuestos.Text = ticketImpuestos.ToString("C2");
            btnAceptar.Text = ticketTotal.ToString("C2");
            

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }






        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArticulo.Text.Trim()))
            {
                if (checkGuardar.Checked)
                {
                    //Antes de nada creamos el nuevo artíclulo
                    string tabla = "productos_servicios";
                    string[] campos = new string[]
                    {
                    "id_producto_servicio",
                    "descripcion",
                    "tipo",
                    "stock",
                    "precio_venta",
                    "tipo_IVA"
                    };
                    string[] valores = new string[]
                    {
                    txtIdArticulo.Text,
                    txtArticulo.Text,
                    "SERVICIO",
                    "0",
                    txtPrecioVenta.Text.Replace(".","").Replace(",","."),
                    cmbImpuestos.SelectedIndex.ToString()
                    };

                    string respuesta = conexion.NuevoRegistro(tabla, campos, valores);
                    if (respuesta == null)
                    {

                    }
                    else
                    {
                        MessageBox.Show($"No se ha podido crear el nuevo Producto / Servicio.\n{respuesta}", "Nuevo Artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                

                //Comprobamos si la nueva línea a introducir ya existe en la lista
                ListViewItem itemAbuscar = lista.FindItemWithText(txtIdArticulo.Text);
                if (itemAbuscar == null)
                {

                    decimal itemNeto = Convert.ToDecimal(txtNeto.Text);
                    decimal itemImpuestos = Convert.ToDecimal(txtImpuestos.Text);
                    decimal itemPrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                    decimal itemCantidad = Convert.ToDecimal(txtCantidad.Text);
                    decimal itemTotal = Convert.ToDecimal(txtTotalImporte.Text);

                    //Creamos el ListViewItem
                    ListViewItem item = new ListViewItem(txtIdArticulo.Text);       //ID del servicio o artículo
                    item.SubItems.Add(txtArticulo.Text.ToUpper());                  //Descripción de servicio o artículo
                    item.SubItems.Add(itemNeto.ToString("C2"));                     //Importe Neto
                    item.SubItems.Add(itemImpuestos.ToString("C2"));                //Importe de los impuestos
                    item.SubItems.Add(itemPrecioVenta.ToString("C2"));              //Importe de venta
                    item.SubItems.Add(itemCantidad.ToString("F2"));                 //Cantidad
                    item.SubItems.Add(itemTotal.ToString("C2"));                    //Importe total de la línea

                    //Añadimos el nuevo item a la lista (TICKET)
                    lista.Items.Add(item);
                    lista.Items[lista.Items.Count - 1].Selected = true;
                    CalculaTotales();
                }
                else
                {
                    float cantidad = Convert.ToSingle(itemAbuscar.SubItems[5].Text);
                    cantidad += Convert.ToSingle(txtCantidad.Text);
                    itemAbuscar.SubItems[5].Text = cantidad.ToString("F2");
                    float precioVenta = Convert.ToSingle(itemAbuscar.SubItems[4].Text.Replace("€", "").Trim());
                    float total = precioVenta * cantidad;
                    itemAbuscar.SubItems[6].Text = total.ToString("C2");
                    CalculaTotales();
                }

                //Reseteamos todos los valores
                checkGuardar.Checked = false;
                txtPrecioVenta.Text = "0,00";
                txtPrecioVenta_Leave(sender, e);
                txtArticulo.Text = "";
                txtIdArticulo.Text = "";
                txtCantidad.Text = "1,00";
            }
            else
            {
                MessageBox.Show("No hay ningún producto / servicio seleccionado", "Seleccione Artículo", MessageBoxButtons.OK);
                return;
            }


        }

 



        private void btnMas1_Click(object sender, EventArgs e)
        {
            CalculaTotales();
        }



        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.SelectionStart = 0;
            txtCantidad.SelectionLength = txtCantidad.Text.Length;

        }

        private void txtCantidad_Click(object sender, EventArgs e)
        {
            txtCantidad.SelectionStart = 0;
            txtCantidad.SelectionLength = txtCantidad.Text.Length;
        }

        private void txtNeto_Enter(object sender, EventArgs e)
        {
            txtNeto.SelectionStart = 0;
            txtNeto.SelectionLength = txtNeto.Text.Length;
        }

        private void txtNeto_Click(object sender, EventArgs e)
        {
            txtNeto.SelectionStart = 0;
            txtNeto.SelectionLength = txtNeto.Text.Length;
        }

        private void txtPrecioVenta_Enter(object sender, EventArgs e)
        {
            txtPrecioVenta.SelectionStart = 0;
            txtPrecioVenta.SelectionLength = txtPrecioVenta.Text.Length;
        }

        private void txtPrecioVenta_Click(object sender, EventArgs e)
        {
            txtPrecioVenta.SelectionStart = 0;
            txtPrecioVenta.SelectionLength = txtPrecioVenta.Text.Length;
        }

        private void cmbImpuestos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            calculaDesdeNeto();
        }

        private void btnMenos1_Click(object sender, EventArgs e)
        {
            if (lista.SelectedItems.Count > 0)
            {
                lista.SelectedItems[0].Remove();
                CalculaTotales();
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Reseteamos todos los valores
            checkGuardar.Checked = false;
            txtPrecioVenta.Text = "0,00";
            txtPrecioVenta_Leave(sender, e);
            txtArticulo.Text = "";
            txtIdArticulo.Text = "";
            txtCantidad.Text = "1,00";

            FormularioBuscaArticulo frmBusca = new FormularioBuscaArticulo();
            DialogResult dialogo = frmBusca.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                if (frmBusca.nuevoArticulo)
                {
                    txtArticulo.Text = frmBusca.txtBuscar.Text;
                    txtIdArticulo.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
                    txtCantidad.Text = "1,00";
                    txtPrecioVenta.Text = "0,00";
                    txtPrecioVenta_Leave(sender, e);
                    txtPrecioVenta.Focus();
                    checkGuardar.Checked = true;
                }
                else
                {
                    txtArticulo.Text = frmBusca.dataArticulos.CurrentRow.Cells[1].Value.ToString();
                    txtIdArticulo.Text = frmBusca.dataArticulos.CurrentRow.Cells[0].Value.ToString();
                    txtPrecioVenta.Text = frmBusca.dataArticulos.CurrentRow.Cells[2].Value.ToString().Replace("€", "").Trim();
                    txtPrecioVenta_Leave(sender, e);
                    txtPrecioVenta.Focus();
                }
                

            }
            else
            {

            }
            frmBusca.Dispose();
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            float i = 0;
            if (float.TryParse(txtCantidad.Text, out i))
            {
                txtCantidad.Text = float.Parse(txtCantidad.Text).ToString("F2");
                calculaDesdeCantidad();
            }
            else
            {
                MessageBox.Show("La cantidad introducida no es correcta", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Text = i.ToString("F2");
                txtCantidad.Focus();
            }
        }

        private void txtNeto_Leave(object sender, EventArgs e)
        {
            float i = 0;
            if (float.TryParse(txtNeto.Text, out i))
            {
                txtNeto.Text = float.Parse(txtNeto.Text).ToString("F2");
                calculaDesdeNeto();
            }
            else
            {
                MessageBox.Show("La cantidad introducida no es correcta", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNeto.Text = i.ToString("F2");
                txtNeto.Focus();
            }
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            float i = 0;
            if (float.TryParse(txtPrecioVenta.Text, out i))
            {
                txtPrecioVenta.Text = float.Parse(txtPrecioVenta.Text).ToString("F2");
                calculaDesdeBruto();
            }
            else
            {
                MessageBox.Show("La cantidad introducida no es correcta", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioVenta.Text = i.ToString("F2");
                txtPrecioVenta.Focus();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Comprobamos que haya alguna linea en la lista de conceptos
            if (lista.Items.Count < 1)
            {
                MessageBox.Show("La visita no tiene conceptos que almacenar", "Nueva Visita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Comprobamos que haya historial
            if (string.IsNullOrEmpty(txtHistorial.Text.Trim()))
            {
                DialogResult dialogo = MessageBox.Show("El historial está vacio. ¿Desea continuar?", "Historial vacio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No)
                {
                    txtHistorial.Focus();
                    return;
                }
            }

            //Guardamos la visita
            string tabla = "visitas";

            string[] campos = new string[]
            {
                "id_visita",
                "fecha",
                "dni_cliente",
                "id_mascota",
                "total_neto",
                "total_impuestos",
                "total_venta",
                "tipo_pago",
                "estado",
                "facturado",
                "historial",
                "importe_pendiente"
            };

            ////Mostramos la ventana donde elegir el tipo de pago
            FormularioSeleccionaPago frmSelecciona = new FormularioSeleccionaPago(Convert.ToDecimal(btnAceptar.Text.Replace("€","")));
            frmSelecciona.ShowDialog();


            string[] valores = new string[]
            {
                txtIDVisita.Text,
                dateFecha.Value.ToString("yyyy-MM-dd"),
                txtDNICliente.Text,
                txtIDMascota.Text,
                lblNeto.Text.Replace("€","").Trim().Replace(".","").Replace(",","."),
                lblImpuestos.Text.Replace("€","").Trim().Replace(".","").Replace(",","."),
                btnAceptar.Text.Replace("€","").Trim().Replace(".","").Replace(",","."),
                frmSelecciona.cmbTiposPago.SelectedIndex.ToString(),
                "PAGADO",
                "0",
                txtHistorial.Text,
                frmSelecciona.txtCambio.Text.Replace(".","").Replace(",",".")
            };

            frmSelecciona.Dispose();
            string respuesta = conexion.NuevoRegistro(tabla, campos, valores);





            if (respuesta == null)
            {
                //Guardamos todas las lineas pertenecientes a la visita creada
                string tabla2 = "lineas_visitas";
                foreach (ListViewItem item in lista.Items)
                {
                    string[] campos2 = new string[]
                    {
                        "id_visita",
                        "id_producto_servicio",
                        "descripcion",
                        "importe_neto",
                        "porcentaje_impuestos",
                        "importe_impuestos",
                        "importe_venta",
                        "cantidad",
                        "importe_total"
                    };

                    string idVisita = txtIDVisita.Text;
                    string id = item.Text;
                    string descripcion = item.SubItems[1].Text;
                    float importeNeto = Convert.ToSingle(item.SubItems[2].Text.Replace("€", "").Trim());
                    float importeVenta = Convert.ToSingle(item.SubItems[4].Text.Replace("€", "").Trim());
                    float porcentaje_impuestos = Convert.ToSingle((importeVenta / importeNeto) - 1);
                    float importeImpuestos = importeNeto * porcentaje_impuestos;
                    float cantidad = Convert.ToSingle(item.SubItems[5].Text);
                    float importeTotal = cantidad * importeVenta;


                    string[] valores2 = new string[]
                    {
                        idVisita,
                        id,
                        descripcion,
                        importeNeto.ToString("C2").Replace(".","").Replace("€","").Replace(",","."),
                        porcentaje_impuestos.ToString("C2").Replace(".","").Replace("€","").Replace(",","."),
                        importeImpuestos.ToString("C2").Replace(".","").Replace("€","").Replace(",","."),
                        importeVenta.ToString("C2").Replace(".","").Replace("€","").Replace(",","."),
                        cantidad.ToString("C2").Replace(".","").Replace("€","").Replace(",","."),
                        importeTotal.ToString("C2").Replace(".","").Replace("€","").Replace(",",".")
                    };

                    string respuesta2 = conexion.NuevoRegistro(tabla2, campos2, valores2);
                    if (respuesta != null)
                    {
                        FormularioError frmError = new FormularioError($"Se ha producido un error al añadir una línea a la nueva vitia.\n{respuesta}");
                        frmError.ShowDialog();
                        frmError.Dispose();
                    }

                }


                MessageBox.Show("La visita se ha creado correctamente", "Nueva Visita", MessageBoxButtons.OK);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show($"No se ha podido crear la nueva visita.\n{respuesta}", "Nueva Visita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }




        }






 

        
    }
}
