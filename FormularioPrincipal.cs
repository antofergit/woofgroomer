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
    public delegate void delegadoPrincipal(Form form);

    public partial class FormularioPrincipal : Form
    {

        //Campos de clase
        Conexion conexion;



        public FormularioPrincipal()
        {
            InitializeComponent();
            conexion = new Conexion();

        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            conexion.AbreConexion();
            conexion.CierraConexion();
            //abreFormulario(new FormularioSala());

        }

        public void abreFormulario(Form frm)
        {

            //comprobamos que el panel contenedor esté vacio, si no es así borra el último formulario
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            //Damos propiedades al formulario, lo agregamos al panel contenedor y lo abrimos
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frm);
            this.panelContenedor.Tag = frm;
            
            frm.Show();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            

            abreFormulario(new FormularioClientesMascotas2());

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            abreFormulario(new FormularioSala());
        }

        private void panelContenedor_ControlRemoved(object sender, ControlEventArgs e)
        {
            //abreFormulario(new FormularioSala());
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            abreFormulario(new FormularioProductosServicios());

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormularioObras frmObras = new FormularioObras();
            frmObras.Text = "Módulo Agenda";
            frmObras.ShowDialog();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            abreFormulario(new FormularioVisitas());
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FormularioObras frmObras = new FormularioObras();
            frmObras.Text = "Módulo Estadísticas";
            frmObras.ShowDialog();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {

            FormularioObras frmObras = new FormularioObras();
            frmObras.Text = "Módulo de Caja";
            frmObras.ShowDialog();
        }

        private void FormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (Mascotas.listado.Count > 0)
            {
                DialogResult dialogo = MessageBox.Show($"Tiene {Mascotas.listado.Count.ToString()} mascota(s) en sala. Si cierra perderá la información de Sala al volver a abrir el programa.\n¿Desea cerrar la aplicación?", "Mascotas en sala", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

            if (ControlHoras.activos.Count > 0)
            {
                DialogResult dialogo = MessageBox.Show($"Tiene {ControlHoras.activos.Count.ToString()} empleado(s) en sala. Si cierra la aplicación se le anotará la hora de cierre como hora de salida.\n¿Desea cerrar la aplicación?", "Empleados en sala", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.No)
                {
                    e.Cancel = true;

                }
                else
                {
                    for (int x = 0; x < ControlHoras.activos.Count; x++)
                    {
                        if (ControlHoras.activos[x].Salida(DateTime.Now))
                        {
                            ControlHoras.activos.RemoveAt(x);
                        }
                    }
                }
                
            }
            
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            FormularioAcceso frmAcceso = new FormularioAcceso();
            DialogResult dialogo = frmAcceso.ShowDialog();
            if (dialogo == DialogResult.OK)
            {

            }
            else
            {
                Application.Exit();
            }
            frmAcceso.Dispose();

        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            FormularioConfiguracion frmConfiguracion = new FormularioConfiguracion();
            DialogResult dialogo = frmConfiguracion.ShowDialog();
            if (dialogo == DialogResult.OK)
            {

            }
            else
            {

            }
            frmConfiguracion.Dispose();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            FormularioControlEmpleados frmControl = new FormularioControlEmpleados();
            DialogResult dialogo = frmControl.ShowDialog();
            if (dialogo == DialogResult.OK)
            {

            }
            else
            {

            }
            frmControl.Dispose();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
