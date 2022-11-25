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
    public partial class ListadoClientes : UserControl
    {

        //Campos de clase
        private int mascotas = 3;
        private int visitas = 24;


        public ListadoClientes()
        {
            InitializeComponent();
        }

        private void lblDNI_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            

        }

        private void lblDNI_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

        }

        

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            MenuClientes.Show(new Point(MousePosition.X - 200 ,MousePosition.Y + 10));
            menuItemMascotas.Text = $"Mascotas : {mascotas}";
            menuItemVisitas.Text = $"Visitas : {visitas}";
        }

        
    }
}
