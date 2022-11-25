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
    public partial class FichaSala : UserControl
    {

        public string idMascota { get; set; }
        public string dniCliente { get; set; }

        private int indexFicha = Mascotas.listado.Count-1;

        public FichaSala(string idMascota, string dniCliente)
        {
            InitializeComponent();
            this.idMascota = idMascota;
            this.dniCliente = dniCliente;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            for (int x = 0; x < Mascotas.listado.Count; x++)
            {
                if (Mascotas.listado[x].idMascota == this.idMascota)
                {
                    Mascotas.listado.Remove(Mascotas.listado[x]);
                }
            }
            this.Dispose();

        }

        private void btnFicha_Click(object sender, EventArgs e)
        {
            FormularioFicha frmFicha = new FormularioFicha();
            frmFicha.txtDNICliente.Text = dniCliente;
            frmFicha.txtIDMascota.Text = idMascota;

            DialogResult dialogo = frmFicha.ShowDialog();
            if (dialogo == DialogResult.OK)
            {

            }
            else
            {

            }
            frmFicha.Dispose();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            FormularioNuevaVisita frmNuevaVisita = new FormularioNuevaVisita(dniCliente, lblCliente.Text, idMascota, tarjeta.Text);
            frmNuevaVisita.img.Image = img.Image;
            DialogResult dialogo = frmNuevaVisita.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                for (int x = 0; x < Mascotas.listado.Count; x++)
                {
                    if (Mascotas.listado[x].idMascota == this.idMascota)
                    {
                        Mascotas.listado.Remove(Mascotas.listado[x]);
                    }
                }
                this.Dispose();

            }
            else
            {

            }
            frmNuevaVisita.Dispose();
        }
    }
}
