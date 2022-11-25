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
    public partial class FormularioClientes : Form
    {

        //Campos de clase
        private Conexion conexion;
        private DataTable dtClientes;
        private DataRow drClientes;

        public FormularioClientes()
        {
            InitializeComponent();
            conexion = new Conexion();
            
        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            EncabezadoClientes encabezado = new EncabezadoClientes();
            panelEncabezado.Controls.Add(encabezado);
            encabezado.Dock = DockStyle.Top;

            

            


            

        }

        private void dataClientes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
    }
}
