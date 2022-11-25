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
    public partial class FormularioVisitas : Form
    {

        //Campos de clase
        private Conexion conexion;
        private DataTable dtVisitas;



        public FormularioVisitas()
        {
            InitializeComponent();
            conexion = new Conexion();
            

        }

        private void Actualiza()
        {
            string consulta = "select * from listado_de_visitas ";
            if (checkFecha.Checked)
            {
                if (consulta.Length == 33) 
                { 
                    consulta += "where ";
                }
                else
                {
                    consulta += "and ";
                }
                consulta += $"listado_de_visitas.fecha between '{fechaDesde.Value.ToString("yyyy-MM-dd")}' and '{fechaHasta.Value.ToString("yyyy-MM-dd")}' ";
            }

            if (txtCliente.Tag != null)
            {
                if (consulta.Length == 33)
                {
                    consulta += "where ";
                }
                else
                {
                    consulta += "and ";
                }
                consulta += $"listado_de_visitas.dni_cliente = '{txtCliente.Tag}' ";
            }

            if (txtMascota.Tag != null)
            {

                if (consulta.Length == 33)
                {
                    consulta += "where ";
                }
                else
                {
                    consulta += "and ";
                }
                consulta += $"listado_de_visitas.nombre_mascota = '{txtMascota.Text}' ";
            }

            if (txtRaza.Tag != null)
            {
                if (consulta.Length == 33)
                {
                    consulta += "where ";
                }
                else
                {
                    consulta += "and ";
                }
                consulta += $"listado_de_visitas.id_raza = '{txtRaza.Tag}' ";
            }

            if (txtTipoPago.Tag != null)
            {
                if (consulta.Length == 33)
                {
                    consulta += "where ";
                }
                else
                {
                    consulta += "and ";
                }
                consulta += $"listado_de_visitas.tipo_pago = '{txtTipoPago.Tag}' ";
            }

            if (txtEstado.Tag != null)
            {
                if (consulta.Length == 33)
                {
                    consulta += "where ";
                }
                else
                {
                    consulta += "and ";
                }
                consulta += $"listado_de_visitas.estado = '{txtEstado.Text}' ";
            }

            if (checkImportesPendientes.Checked)
            {
                if (consulta.Length == 33)
                {
                    consulta += "where ";
                }
                else
                {
                    consulta += "and ";
                }
                consulta += $"listado_de_visitas.importe_pendiente <> 0 ";
            }






            dtVisitas = conexion.DameTablaCompleta(consulta);
            dataVisitas.DataSource = dtVisitas;
        }

        private void FormularioVisitas_Load(object sender, EventArgs e)
        {
            Actualiza();


            //Damos formato al dataGrid
            dataVisitas.Columns["id_visita"].Visible = false; ;
            dataVisitas.Columns["fecha"].HeaderText = "Fecha";
            //dataVisitas.Columns["fecha"].DefaultCellStyle.Format = DateTime.fo;
            dataVisitas.Columns["dni_cliente"].HeaderText = "DNI Cliente";
            dataVisitas.Columns["nombre_cliente"].HeaderText = "Cliente";
            dataVisitas.Columns["nombre_cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataVisitas.Columns["id_mascota"].Visible = false;
            dataVisitas.Columns["nombre_mascota"].HeaderText = "Mascota";
            dataVisitas.Columns["nombre_mascota"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataVisitas.Columns["id_raza"].Visible = false;
            dataVisitas.Columns["raza"].HeaderText = "Raza";
            dataVisitas.Columns["raza"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataVisitas.Columns["total_neto"].HeaderText = "B.Imponible";
            dataVisitas.Columns["total_neto"].DefaultCellStyle.Format = string.Format("C2");
            dataVisitas.Columns["total_neto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataVisitas.Columns["total_impuestos"].HeaderText = "I.V.A.";
            dataVisitas.Columns["total_impuestos"].DefaultCellStyle.Format = string.Format("C2");
            dataVisitas.Columns["total_impuestos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataVisitas.Columns["total_venta"].HeaderText = "P.V.P.";
            dataVisitas.Columns["total_venta"].DefaultCellStyle.Format = string.Format("C2");
            dataVisitas.Columns["total_venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataVisitas.Columns["tipo_pago"].Visible = false;
            dataVisitas.Columns["descripcion"].HeaderText = "Tipo Pago";
            dataVisitas.Columns["estado"].HeaderText = "Estado";
            dataVisitas.Columns["factura"].HeaderText = "Facturado";
            dataVisitas.Columns["historial"].Visible = false;
            dataVisitas.Columns["importe_pendiente"].HeaderText = "Imp. Pendiente";
            dataVisitas.Columns["importe_pendiente"].DefaultCellStyle.Format = string.Format("C2");
            dataVisitas.Columns["importe_pendiente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FormularioBuscarCliente frmBuscaCliente = new FormularioBuscarCliente();
            DialogResult dialogo = frmBuscaCliente.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                txtCliente.Tag = frmBuscaCliente.dataClientes.CurrentRow.Cells[0].Value.ToString();
                txtCliente.Text = frmBuscaCliente.dataClientes.CurrentRow.Cells[1].Value.ToString();

            }
            else
            {

            }
        }

        private void btnBuscarRaza_Click(object sender, EventArgs e)
        {
            FormularioBuscarRaza frmBuscaRaza = new FormularioBuscarRaza();
            DialogResult dialogo = frmBuscaRaza.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                txtRaza.Tag = frmBuscaRaza.dataRazas.CurrentRow.Cells[0].Value.ToString();
                txtRaza.Text = frmBuscaRaza.dataRazas.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {

            }
            frmBuscaRaza.Dispose();

        }

        private void btnBorrarRaza_Click(object sender, EventArgs e)
        {
            txtRaza.Tag = null;
            txtRaza.Text = "";


        }

        private void btnBuscarMascota_Click(object sender, EventArgs e)
        {
            FormularioBuscarMascota frmBuscaMascota = new FormularioBuscarMascota();
            DialogResult dialogo = frmBuscaMascota.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                txtMascota.Tag = frmBuscaMascota.dataMascotas.CurrentRow.Cells[0].Value.ToString();
                txtMascota.Text = frmBuscaMascota.dataMascotas.CurrentRow.Cells[1].Value.ToString();

            }
            else
            {

            }
            frmBuscaMascota.Dispose();
        }

        private void btnBorrarMascota_Click(object sender, EventArgs e)
        {
            txtMascota.Tag = null;
            txtMascota.Text = "";
            
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            txtCliente.Tag = null;
            txtCliente.Text = "";
            

        }

        private void btnBorrarTipoPago_Click(object sender, EventArgs e)
        {
            txtTipoPago.Tag = null;
            txtTipoPago.Text = "";
            

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FormularioBuscarTipoPago frmBuscaTipo = new FormularioBuscarTipoPago();
            DialogResult dialogo = frmBuscaTipo.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                txtTipoPago.Tag = frmBuscaTipo.dataTipoPago.CurrentRow.Cells[0].Value.ToString();
                txtTipoPago.Text = frmBuscaTipo.dataTipoPago.CurrentRow.Cells[1].Value.ToString();

            }
            else
            {

            }
            frmBuscaTipo.Dispose();
        }

        private void btnBorrarEstado_Click(object sender, EventArgs e)
        {
            txtEstado.Tag = null;
            txtEstado.Text = "";
            

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FormularioBuscarEstados frmBuscaEstado = new FormularioBuscarEstados();
            DialogResult dialogo = frmBuscaEstado.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                txtEstado.Tag = frmBuscaEstado.dataEstados.CurrentRow.Cells[0].Value.ToString();
                txtEstado.Text = frmBuscaEstado.dataEstados.CurrentRow.Cells[1].Value.ToString();

            }
            else
            {

            }
            frmBuscaEstado.Dispose();
        }

        private void checkFecha_CheckedChanged(object sender, EventArgs e)
        {
            fechaDesde.Value = DateTime.Today;

            fechaDesde.Enabled = checkFecha.Checked;
            fechaHasta.Enabled = checkFecha.Checked;
            fechaHasta.MinDate = fechaDesde.Value;
            Actualiza();


        }

        private void fechaDesde_ValueChanged(object sender, EventArgs e)
        {
            fechaHasta.MinDate = fechaDesde.Value;
            fechaHasta.Value = fechaDesde.Value;
            Actualiza();

        }

        private void fechaHasta_ValueChanged(object sender, EventArgs e)
        {
            Actualiza();
        }

        private void checkImportesPendientes_CheckedChanged(object sender, EventArgs e)
        {
            Actualiza();
        }

        private void txtTipoPago_TextChanged(object sender, EventArgs e)
        {
            Actualiza();

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            Actualiza();

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            Actualiza();

        }

        private void txtMascota_TextChanged(object sender, EventArgs e)
        {
            Actualiza();

        }

        private void txtRaza_TextChanged(object sender, EventArgs e)
        {
            Actualiza();

        }

        private void dataVisitas_DataSourceChanged(object sender, EventArgs e)
        {
            lblVisitas.Text = dataVisitas.Rows.Count.ToString();
            //Calculamos el total de las visitas
            float suma = 0;
            float cantidad = 0;
            foreach (DataGridViewRow fila in dataVisitas.Rows)
            {
                cantidad = Convert.ToSingle(fila.Cells["total_venta"].Value.ToString());
                suma += cantidad;
                //MessageBox.Show(suma.ToString());
            }
            lblImporte.Text = suma.ToString("C2");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataVisitas.SelectedRows.Count > 0)
            {
                string idVisita = dataVisitas.CurrentRow.Cells[0].Value.ToString();
                string fecha = dataVisitas.CurrentRow.Cells[1].Value.ToString();
                string cliente = dataVisitas.CurrentRow.Cells[3].Value.ToString();
                string mascota = dataVisitas.CurrentRow.Cells[5].Value.ToString();
                DialogResult dialogo = MessageBox.Show($"Se dispone a eliminar la visita de\n{fecha} - {cliente} - {mascota}, ¿Desea continuar?", "Eliminar visita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    string respuesta = conexion.EliminarRegistro("visitas", "id_visita", idVisita);
                    if (respuesta == null)
                    {
                        MessageBox.Show("La visita ha sido eliminada correctamente", "Eliminar visita", MessageBoxButtons.OK);
                        Actualiza();
                    }
                    else
                    {
                        MessageBox.Show($"No se ha podido eliminar la visita.\n{respuesta}", "Eliminar visita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                }
            }
        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {




        }

        private async Task Prueba()
        {

        }

        private void btnTrimestre_Click(object sender, EventArgs e)
        {
            FormularioTrimestre frmTrimestre = new FormularioTrimestre(fechaDesde.Value.ToString("yyyy-MM-dd"), fechaHasta.Value.ToString("yyyy-MM-dd"));
            DialogResult dialogo = frmTrimestre.ShowDialog();
            if (dialogo == DialogResult.OK)
            {

            }
            else
            {

            }
            frmTrimestre.Dispose();

        }
    }
}
