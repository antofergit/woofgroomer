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
    public partial class FormularioPassword : Form
    {

        public string usuario { get; set; }
        public string password { get; set; }

        public FormularioPassword(string usuario, string password)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.password = password;
        }

        private void FormularioPassword_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
            lblEmpleado.Text = usuario;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == password)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show($"La contraseña para el empleado {usuario} no es correcta", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtPassword.Focus();
                return;
            }
        }
    }
}
