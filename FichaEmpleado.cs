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
    public partial class FichaEmpleado : UserControl
    {

        public string horaEntrada;


        public FichaEmpleado(string horaEntrada)
        {
            InitializeComponent();
            this.horaEntrada = horaEntrada;
        }

        private void FichaEmpleado_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Empleado:\t\t{btnEmpleado.Text}\nHora de entrada:\t\t{horaEntrada}");

        }
    }
}
