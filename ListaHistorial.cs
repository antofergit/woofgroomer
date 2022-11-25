using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoofGroomer
{
    public partial class ListaHistorial : UserControl
    {

        //Campos de clase
        private Conexion conexion;
        private DataTable dtVisita;
        private DataTable dtLineas;
        private string idVisita;

        public ListaHistorial(string idVisita)
        {
            InitializeComponent();
            this.idVisita = idVisita;
            conexion = new Conexion();
            dtVisita = conexion.DameTablaCompleta($"select * from visitas where id_visita = {idVisita}");
            dtLineas = conexion.DameTablaCompleta($"select * from lineas_visitas where id_visita = {idVisita}");
        }

        private void ListaHistorial_Load(object sender, EventArgs e)
        {
            cmbTicket.DataSource = dtLineas;
            cmbTicket.DisplayMember = "descripcion";
            DataRow fila = dtVisita.Rows[0];
            DateTime fecha = Convert.ToDateTime(fila.ItemArray[1].ToString());
            lblFecha.Text = fecha.ToString("dd/MM/yyyy");
            decimal importe = Convert.ToDecimal(fila.ItemArray[6].ToString());
            lblImporte.Text = importe.ToString("C2");
            txtHistorial.Text = fila.ItemArray[10].ToString();

            

        }

        private void txtHistorial_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtHistorial_KeyUp(object sender, KeyEventArgs e)
        {
            string respuesta = conexion.ActualizaRegistro($"update visitas set historial = '{txtHistorial.Text}' where id_visita = {idVisita}");
            if (respuesta != null)
            {
                FormularioError frmError = new FormularioError($"No se puede actualizar el historial.\n{respuesta}");
                frmError.ShowDialog();
                frmError.Dispose();
            }
        }
    }
}
