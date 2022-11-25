﻿using System;
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
    public partial class FormularioConfiguracion : Form
    {
        //Campos de clase
        private Conexion conexion;
        private DataTable dtUsuarios;


        public FormularioConfiguracion()
        {
            InitializeComponent();
            conexion = new Conexion();
        }





        private void FormularioConfiguracion_Load(object sender, EventArgs e)
        {
            dtUsuarios = conexion.DameTablaCompleta("select * from empleados");
            listaEmpleados.DataSource = dtUsuarios;
            listaEmpleados.DisplayMember = "nombre";
            listaEmpleados.ValueMember = "id_empleado";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
