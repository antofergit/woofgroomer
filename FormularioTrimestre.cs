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
    public partial class FormularioTrimestre : Form
    {

        private string fechaInicio;
        private string fechaFinal;
        private double importe;

        public FormularioTrimestre(string fechaInicio, string fechaFinal)
        {
            InitializeComponent();
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
        }

        private void FormularioTrimestre_Load(object sender, EventArgs e)
        {

            FormularioImporte frmImporte = new FormularioImporte();
            frmImporte.lblDesde.Text = fechaInicio;
            frmImporte.lblHasta.Text = fechaFinal;
            DialogResult dialogo = frmImporte.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                this.importe = Convert.ToDouble(frmImporte.txtImporte.Text);

            }
            else
            {
                this.Close();
            }
            frmImporte.Dispose();


            DataTable tabla = Generador2.Genara(fechaInicio, fechaFinal, importe);
            tabla.DefaultView.Sort = "fecha";
            dataTrimestre.DataSource = tabla;

            double suma = 0;
            foreach (DataRow fila in tabla.Rows)
            {
                double importe = Convert.ToDouble(fila.ItemArray[5].ToString());
                suma += importe;
                lblTotal.Text = suma.ToString("C2");
            }

            //Damos diseño al DataGridView
            dataTrimestre.Columns["total_neto"].DefaultCellStyle.Format = string.Format("C2");
            dataTrimestre.Columns["total_neto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataTrimestre.Columns["total_impuestos"].DefaultCellStyle.Format = string.Format("C2");
            dataTrimestre.Columns["total_impuestos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataTrimestre.Columns["total_venta"].DefaultCellStyle.Format = string.Format("C2");
            dataTrimestre.Columns["total_venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnTrimestre_Click(object sender, EventArgs e)
        {
            Exportar.ExportarDataGridViewExcel(this.dataTrimestre);
            this.Close();


        }
    }
}
