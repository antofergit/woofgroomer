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
    public partial class FormularioSala : Form
    {
        public FormularioSala()
        {
            InitializeComponent();
        }

        private void FormularioSala_Load(object sender, EventArgs e)
        {
            //FichaSala ficha = new FichaSala();
            //ficha.Location = new Point(20, 20);
            //contenedor.Controls.Add(ficha);

            foreach (Mascotas mascota in Mascotas.listado)
            {
                FichaSala ficha = new FichaSala(mascota.idMascota,mascota.dniCliente);
                ficha.tarjeta.Text = mascota.nombre;
                ficha.lblHora.Text = "Hora de entrada - " + mascota.hora.ToString("HH:mm") + "h.";
                ficha.lblCliente.Text = mascota.cliente;
                ficha.lblRaza.Text = mascota.raza;
                ficha.lblTelefono.Text = mascota.telefono;
                ficha.img.Image = mascota.imagen;
                ficha.txtTrabajo.Text = mascota.trabajo;

                contenedor.Controls.Add(ficha);


            }

            foreach (ControlHoras empleados in ControlHoras.activos)
            {
                FichaEmpleado fichaEmpleado = new FichaEmpleado(empleados.FechaEntrada.ToString("dd/MM/yyyy HH:mm"));
                fichaEmpleado.btnEmpleado.Text = empleados.Nombre;
                fichaEmpleado.btnEmpleado.Tag = empleados.IdEmpleado;
                GrupoEmpleados.Controls.Add(fichaEmpleado);
                fichaEmpleado.Dock = DockStyle.Left;

            }

        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
