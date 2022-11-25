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
    public partial class FormularioOK : Form
    {

        //Variable global
        int contador = 0;

        //sombreamos el formulario
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public FormularioOK(string mensaje)
        {
            InitializeComponent();
            lblTexto.Text = mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FormularioOK_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador == 3) { this.Close(); }
            contador++;

        }
    }
}
