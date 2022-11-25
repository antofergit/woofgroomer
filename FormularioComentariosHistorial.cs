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
    public partial class FormularioComentariosHistorial : Form
    {

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

        public FormularioComentariosHistorial(string linea)
        {
            InitializeComponent();
            lblLinea.Text = linea;
        }

        private void FormularioComentariosHistorial_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            if (txtComentario.Text == "")
            {
                FormularioError frmError = new FormularioError("Debe introducir los datos a guardar en el historial");
                frmError.ShowDialog();
                frmError.Dispose();
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
