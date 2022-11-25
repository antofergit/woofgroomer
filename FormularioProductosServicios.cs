using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WoofGroomer
{
    public partial class FormularioProductosServicios : Form
    {

        //Campos de clase
        private Conexion conexion;
        private DataTable dtArticulos;
        private DataTable dtImpuestos;
        

        public FormularioProductosServicios()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";

        }

        private void FormularioProductosServicios_Load(object sender, EventArgs e)
        {

            ActualizaArticulos();
            if (dataVisitas.Rows.Count > 0)
            {
                dataArticulos_CurrentCellChanged(sender, e);
                dataVisitas.Focus();
            }

        }

        private void ActualizaArticulos(int indice = 0)
        {
            dtArticulos = conexion.DameTablaCompleta("select * from listado_de_articulos");
            dataVisitas.DataSource = dtArticulos;

            //Damos formato al dataGrid
            dataVisitas.Columns["id_producto_servicio"].HeaderText = "ID";
            dataVisitas.Columns["descripcion"].HeaderText = "Descripción";
            dataVisitas.Columns["descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataVisitas.Columns["tipo"].HeaderText = "Tipo";
            dataVisitas.Columns["stock"].HeaderText = "Stock";
            dataVisitas.Columns["stock"].Width = 50;
            dataVisitas.Columns["precio_venta"].HeaderText = "P.V.P.";
            dataVisitas.Columns["precio_venta"].DefaultCellStyle.Format = string.Format("C2");
            dataVisitas.Columns["precio_venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataVisitas.Columns["precio_venta"].Width = 70;
            dataVisitas.Columns["tipo_IVA"].HeaderText = "ID IVA";
            dataVisitas.Columns["tipo_IVA"].Visible = false;
            dataVisitas.Columns["IVA"].HeaderText = "Tipo IVA";
            dataVisitas.Columns["IVA"].HeaderText = "Tipo IVA";
            dataVisitas.Columns["porcentaje_mostrar"].HeaderText = "% IVA";
            dataVisitas.Columns["porcentaje_mostrar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataVisitas.Columns["porcentaje_mostrar"].Width = 50;
            dataVisitas.Columns["porcentaje_valor"].HeaderText = "% Valor IVA";
            dataVisitas.Columns["porcentaje_valor"].Visible = false;
            dataVisitas.Columns["mNeto"].HeaderText = "Neto";
            dataVisitas.Columns["mNeto"].DefaultCellStyle.Format = string.Format("C2");
            dataVisitas.Columns["mNeto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataVisitas.Columns["mNeto"].Width = 70;
            dataVisitas.Columns["mImpuestos"].HeaderText = "Impuestos";
            dataVisitas.Columns["mImpuestos"].Width = 70;
            dataVisitas.Columns["mImpuestos"].DefaultCellStyle.Format = string.Format("C2");
            dataVisitas.Columns["mImpuestos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Llenamos los comboBox's
            dtImpuestos = conexion.DameTablaCompleta("select * from impuestos");
            cmbTipoIVA.DataSource = dtImpuestos;
            cmbTipoIVA.DisplayMember = "descripcion";
            cmbTipoIVA.ValueMember = "porcentaje_valor";

            cmbTipoArticulo.SelectedIndex = 0;
            if (indice == -1) indice = dtArticulos.Rows.Count - 1;
            if (dataVisitas.Rows.Count > 0)
            {
                dataVisitas.Rows[indice].Cells[0].Selected = true;
            }



        }

        private void cmbTipoIVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataVisitas.SelectedRows.Count > 0)
            {
                txtPorcentajeIVA.Text = dtImpuestos.Rows[cmbTipoIVA.SelectedIndex].ItemArray[3].ToString();
                float defecto = 0;
                float impIVA = 0;
                float impTotal = 0;
                if (float.TryParse(txtNeto.Text.Trim(), out defecto) && float.TryParse(cmbTipoIVA.SelectedValue.ToString(), out defecto))
                {
                    impIVA = float.Parse(txtNeto.Text.Trim()) * Convert.ToSingle(cmbTipoIVA.SelectedValue.ToString());
                    impTotal = float.Parse(txtNeto.Text.Trim()) + impIVA;
                }

                txtTotal.Text = impTotal.ToString("F2");
                txtImporteIVA.Text = impIVA.ToString("F2");
            }
            

        }

        private void txtNeto_Click(object sender, EventArgs e)
        {
            txtNeto.SelectionStart = 0;
            txtNeto.SelectionLength = txtNeto.Text.Length;
        }

        private void txtTotal_Click(object sender, EventArgs e)
        {
            txtTotal.SelectionStart = 0;
            txtTotal.SelectionLength = txtNeto.Text.Length;
        }

        private void txtNeto_Enter(object sender, EventArgs e)
        {
            txtNeto.SelectionStart = 0;
            txtNeto.SelectionLength = txtNeto.Text.Length;
        }

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            txtTotal.SelectionStart = 0;
            txtTotal.SelectionLength = txtNeto.Text.Length;
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

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            float i = 0;
            if (float.TryParse(txtTotal.Text, out i))
            {
                txtTotal.Text = float.Parse(txtTotal.Text).ToString("F2");
                calculaDesdeTotal();
            }
            else
            {
                MessageBox.Show("La cantidad introducida no es correcta", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotal.Text = i.ToString("F2");
                txtTotal.Focus();
            }
        }

        private void calculaDesdeNeto()
        {
            //Obtenemos los valores
            float porcentajeIVA = Convert.ToSingle(cmbTipoIVA.SelectedValue.ToString());
            float neto = Convert.ToSingle(txtNeto.Text.Trim());
            float importeIVA = neto * porcentajeIVA;

            //Mostramos los valores
            txtImporteIVA.Text = importeIVA.ToString("F2");
            txtTotal.Text = (neto + importeIVA).ToString("F2");
        }

        private void calculaDesdeTotal()
        {
            //Obtenemos los valores
            float porcentajeIVA = Convert.ToSingle(cmbTipoIVA.SelectedValue.ToString());
            float total = Convert.ToSingle(txtTotal.Text.Trim());
            float neto = (total / (porcentajeIVA + 1));

            //Mostramos Valores
            txtImporteIVA.Text = (total - neto).ToString("F2");
            txtNeto.Text = neto.ToString(); 

        }

        private void dataArticulos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataVisitas.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataVisitas.CurrentRow;
                txtID.Text = fila.Cells[0].Value.ToString();
                cmbTipoArticulo.Text = fila.Cells[2].Value.ToString();
                txtDescripcion.Text = fila.Cells[1].Value.ToString();
                txtStock.Text = fila.Cells[3].Value.ToString();
                if (cmbTipoIVA.Items.Count > 0)
                {
                    cmbTipoIVA.SelectedIndex = Convert.ToInt32(fila.Cells[5].Value.ToString());
                }

                float total = Convert.ToSingle(fila.Cells[4].Value.ToString());
                float impuestos = Convert.ToSingle(fila.Cells[10].Value.ToString());
                float neto = Convert.ToSingle(fila.Cells[9].Value.ToString());
                txtTotal.Text = total.ToString("F2");
                txtNeto.Text = neto.ToString("F2");
                txtImporteIVA.Text = impuestos.ToString("F2");

                //Cargamos las estadísticas del artículo
                string idArticulo = dataVisitas.CurrentRow.Cells[0].Value.ToString();
                string consulta = $"select " +
                    $"sum(lineas_visitas.importe_total) as totalVetntas,	" +
                    $"(select sum(lineas_visitas.importe_total) from lineas_visitas where id_producto_servicio = '{idArticulo}') as ventasXarticulo," +
                    $"((select sum(lineas_visitas.importe_total) from lineas_visitas where id_producto_servicio = '{idArticulo}') / (SELECT sum(lineas_visitas.importe_total))) as porcentaje " +
                    $"from lineas_visitas";

                DataTable dtEstadisticas = conexion.DameTablaCompleta(consulta);
                DataRow filaEstadisticas = dtEstadisticas.Rows[0];
                float totalVentas = 0;
                float ventasArticulo = 0; 
                float porcentaje = 0;
                try
                {
                    totalVentas = Convert.ToSingle(filaEstadisticas.ItemArray[0].ToString());
                }
                catch (Exception)
                {

                    totalVentas = 0;
                }

                try
                {
                    ventasArticulo = Convert.ToSingle(filaEstadisticas.ItemArray[1].ToString());
                }
                catch (Exception)
                {

                    ventasArticulo = 0;
                }

                try
                {
                    porcentaje = Convert.ToSingle(filaEstadisticas.ItemArray[2].ToString());
                }
                catch (Exception)
                {

                    porcentaje = 0;
                }
                
                lblPorcentajeVentas.Text = porcentaje.ToString("P2");
                int entero = 0;
                try
                {
                    entero = Convert.ToInt32(porcentaje * 100);
                }
                catch (Exception)
                {

                    entero = 0;
                }
                finally
                {
                    circleVentas.Value = entero;
                }

                //Ranking de ventas
                consulta = $"select lineas_visitas.id_producto_servicio, sum(lineas_visitas.cantidad)as sumaVentas, sum(lineas_visitas.importe_total) as sumaImportes, descripcion from lineas_visitas group by descripcion order by sumaImportes DESC";
                DataTable dtRanking = conexion.DameTablaCompleta(consulta);

                //Obtenemos el numero de veces que se ha vendido el artículo
                int contador = 0;
                foreach (DataRow row in dtRanking.Rows)
                {
                    contador++;
                    if (row.ItemArray[0].ToString() == idArticulo)
                    {
                        lblVentas.Text = row.ItemArray[1].ToString();
                        lblRanking.Text = $"{contador.ToString()}/{dtRanking.Rows.Count.ToString()}";
                        return;
                    }
                }


            }

            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show($"¿Desea guardar los cambios realizados en el Producto / Servicio : {txtDescripcion.Text}?", "guardar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                //float pvp = Convert.ToSingle();
                //Actualizamos los datos
                string consulta = $"update productos_servicios set " +
                    $"descripcion = '{txtDescripcion.Text}', " +
                    $"tipo = '{cmbTipoArticulo.Text}', " +
                    $"stock = {txtStock.Text}, " +
                    $"precio_venta = {txtTotal.Text.Trim().Replace(",",".")}, " +
                    $"tipo_IVA = {cmbTipoIVA.SelectedIndex.ToString()} " +
                    $"WHERE id_PRODUCTO_servicio = {txtID.Text};";

                string respuesta = conexion.ActualizaRegistro(consulta);
                if (respuesta == null)
                {
                    int indice = dataVisitas.CurrentRow.Index;
                    dtArticulos = conexion.DameTablaCompleta("select * from listado_de_articulos");
                    dataVisitas.DataSource = dtArticulos;
                    dataVisitas.Rows[indice].Selected = true;
                }
                else
                {
                    MessageBox.Show($"No se ha podido actualizar el registro.\n{respuesta}", "Actualizar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormularioNuevoArticulo frmNuevo = new FormularioNuevoArticulo();
            DialogResult dialogo = frmNuevo.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                ActualizaArticulos(-1);
            }
            else
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataVisitas.SelectedRows.Count > 0)
            {
                DialogResult dialogo = MessageBox.Show($"Se dispone a eliminar el producto/servicio : " +
                    $"{dataVisitas.CurrentRow.Cells[1].Value.ToString()}, ¿Desea continuar?",
                    "Eliminar Registro",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    string respuesta = conexion.EliminarRegistro("productos_servicios", "id_producto_servicio", dataVisitas.CurrentRow.Cells[0].Value.ToString());
                    if (respuesta == null)
                    {
                        ActualizaArticulos();
                    }
                    else
                    {
                        MessageBox.Show($"No se ha podidod eliminar el producto/servicio.\n{respuesta}", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtArticulos = conexion.DameTablaCompleta("Select * From listado_de_articulos");
            if (txtBuscar.Text != "")
            {
                string cadena = txtBuscar.Text;
                string consulta = $"Select * From listado_de_articulos WHERE id_producto_servicio Like '%{cadena}%' OR " +
                                                               $"descripcion Like '%{cadena}%'";
                dtArticulos = conexion.DameTablaCompleta(consulta);
            }

            dataVisitas.DataSource = dtArticulos;
            dataVisitas.Refresh();
            if (dataVisitas.Rows.Count > 0)
            {
                dataVisitas.Rows[0].Cells[0].Selected = true;


            }
        }

        private void dataArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
