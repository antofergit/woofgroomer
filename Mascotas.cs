using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoofGroomer
{
    class Mascotas
    {

        //Campos de clase
        public string idMascota { get; set; }
        public string nombre { get; }
        public string raza { get; }
        public Image imagen { get; }
        public string dniCliente { get; }
        public string cliente { get; }
        public string trabajo { get; }
        public DateTime hora { get; }
        public string telefono { get; }



        public static int contador { get; set; }

        public static List<Mascotas> listado = new List<Mascotas>();


        public Mascotas(string idMascota, string nombre, string raza, Image imagen, string dniCliente, string cliente, string trabajo, string telefono )
        {
            this.idMascota = idMascota;
            this.nombre = nombre;
            this.raza = raza;
            this.imagen = imagen;
            this.dniCliente = dniCliente;
            this.cliente = cliente;
            this.trabajo = trabajo;
            this.hora = DateTime.Now;
            this.telefono = telefono;

            
        }




    }
}
