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
    public partial class FormularioControlEmpleados : Form
    {
        //Campo de clase
        private Conexion conexion;
        private DataTable dtEmpleados;


        public FormularioControlEmpleados()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void FormularioControlEmpleados_Load(object sender, EventArgs e)
        {
            

            //Activamos el reloj
            timer1.Start();

            //Rellenamos los comboBox's
            cmbMes.SelectedIndex = DateTime.Today.Month - 1;
            for (int x = DateTime.Today.Year - 5; x <= DateTime.Today.Year; x++)
            {
                cmbAnio.Items.Add(x.ToString());
            }
            cmbAnio.SelectedIndex = cmbAnio.Items.Count - 1;



            dtEmpleados = conexion.DameTablaCompleta("select * from empleados");

            cmbEmpleado.DataSource = dtEmpleados;
            cmbEmpleado.DisplayMember = "nombre";
            cmbEmpleado.ValueMember = "id_empleado";
            cmbEmpleado.SelectedIndex = -1;
            btnPique.Enabled = false;
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void btnPique_Click(object sender, EventArgs e)
        {
            //Obtenemos el password del usuario
            string password = "";
            foreach (DataRow fila in dtEmpleados.Rows)
            {
                if (fila.ItemArray[0].ToString() == cmbEmpleado.SelectedValue.ToString())
                {
                    password = fila.ItemArray[2].ToString();
                }
            }

            FormularioPassword frmPass = new FormularioPassword(cmbEmpleado.Text, password);
            DialogResult dialogo = frmPass.ShowDialog();
            if (dialogo == DialogResult.OK)
            {

                if (btnPique.Text == "Marcar Entrada")
                {
                    ControlHoras.activos.Add(new ControlHoras(cmbEmpleado.SelectedValue.ToString(),cmbEmpleado.Text,DateTime.Now));

                }
                else
                {
                    for (int x = 0; x < ControlHoras.activos.Count; x++)
                    {
                        if (ControlHoras.activos[x].IdEmpleado == cmbEmpleado.SelectedValue.ToString())
                        {
                            if (ControlHoras.activos[x].Salida(DateTime.Now))
                            {
                                ControlHoras.activos.RemoveAt(x);
                                MessageBox.Show($"Adiós {cmbEmpleado.Text}, Muchas gracias por tu trabajo");

                            }
                        }
                    }
                }

                this.Close();
            }
            else
            {

            }
            frmPass.Dispose();







        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Mostramos la Hora/dia/mes/año
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDia.Text = DateTime.Now.ToString("dddd dd").ToUpper();
            lblMes.Text = DateTime.Now.ToString("MMMM yyyy").ToUpper();


        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            //Obtenemos el password del usuario
            string password = "";
            foreach (DataRow fila in dtEmpleados.Rows)
            {
                if (fila.ItemArray[0].ToString() == cmbEmpleado.SelectedValue.ToString())
                {
                    password = fila.ItemArray[2].ToString();
                }
            }

            FormularioPassword frmPass = new FormularioPassword(cmbEmpleado.Text, password);
            DialogResult dialogo = frmPass.ShowDialog();
            if (dialogo == DialogResult.OK)
            {

                Actualiza();
                cmbAnio.Enabled = true;
                cmbMes.Enabled = true;
            }
            else
            {

            }
            frmPass.Dispose();
        }

        private void Actualiza()
        {
            //Obtenemos la fecha a mostrar
            string fechaInicio = $"{cmbAnio.Text}-{(cmbMes.SelectedIndex + 1).ToString("D2")}-01";
            string fechaFin = $"{cmbAnio.Text}-{(cmbMes.SelectedIndex + 1).ToString("D2")}-31";

            string consulta = "";

            if (cmbEmpleado.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un empleado");
                cmbMes.SelectedIndex = DateTime.Today.Month - 1;
                cmbAnio.SelectedIndex = cmbAnio.Items.Count - 1;
                return;
                
            }
            else
            {
                consulta = $"select * from horas where id_empleado = {cmbEmpleado.SelectedValue.ToString()} and fecha_valor_entrada between '{fechaInicio}' and '{fechaFin}'";
            }

            
            DataTable dtHoras = conexion.DameTablaCompleta(consulta);
            dataHoras.DataSource = dtHoras;

            //Damos formato al DataGridView
            dataHoras.Columns[0].Visible = false;
            dataHoras.Columns[1].Visible = false;
            dataHoras.Columns[2].Visible = false;
            dataHoras.Columns[3].HeaderText = "Fecha/Hora Entrada";
            dataHoras.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy"; 
            dataHoras.Columns[4].HeaderText = "Fecha/Hora Salida";
            dataHoras.Columns[6].DefaultCellStyle.Format = string.Format("F2");


            //Obtenemos la suma de horas
            if (dataHoras.Rows.Count > 0)
            {
                double horas = 0;
                foreach (DataRow fila in dtHoras.Rows)
                {
                    horas += Convert.ToDouble(fila.ItemArray[6].ToString());

                }

                lblHoras.Text = horas.ToString("F2");
            }
            


        }

        private void cmbEmpleado_SelectionChangeCommitted(object sender, EventArgs e)
        {



            //Comprobamos si el empleado esta dentro

            btnPique.Enabled = true;
            btnListado.Enabled = true;
            btnPique.Text = "Marcar Entrada";
            if (ControlHoras.activos.Count > 0)
            {
                foreach (ControlHoras ctr in ControlHoras.activos)
                {
                    if (ctr.IdEmpleado == cmbEmpleado.SelectedValue.ToString())
                    {
                        btnPique.Text = "Marcar Salida";
                    }
                }
            }


            //reseteamos
            cmbAnio.SelectedIndex = cmbAnio.Items.Count - 1;
            cmbAnio.Enabled = false;
            cmbMes.SelectedIndex = DateTime.Today.Month - 1;
            cmbMes.Enabled = false;
            dataHoras.DataSource = null;
            dataHoras.Refresh();

        }

        private void cmbMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Actualiza();

        }

        private void cmbAnio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Actualiza();
        }
    }
}
