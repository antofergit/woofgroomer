using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoofGroomer
{
    class ControlHoras
    {
        //Campos de clase
        Conexion conexion;

        //Propiedades
        public string IdEmpleado { get; }
        public string Nombre { get; }
        public DateTime FechaEntrada { get; }
        public DateTime FechaSalida { get; set; }
        public double Minutos { get; set; }
        public double Horas { get; set; }

        public static List<ControlHoras> activos = new List<ControlHoras>();

        public ControlHoras(string idEmpleado, string nombre, DateTime fechaEntrada)
        {
            this.IdEmpleado = idEmpleado;
            this.Nombre = nombre;
            this.FechaEntrada = AdaptaFecha(fechaEntrada);
            conexion = new Conexion();

            //Damos la bienvenida al empleado
            MessageBox.Show($"Hola {this.Nombre}, Bienvenid@","Entrada",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        public DateTime AdaptaFecha(DateTime fecha)
        {
            int hora = fecha.Hour;
            int minuto = fecha.Minute;
            if (minuto >= 0 && minuto <= 8) { minuto = 0; }
            if (minuto >= 9 && minuto <= 23) { minuto = 15; }
            if (minuto >= 24 && minuto <= 38) { minuto = 30; }
            if (minuto >= 39 && minuto <= 53) { minuto = 45; }
            if (minuto >= 54)
            {
                minuto = 0;
                hora += 1;
            }

            if (hora == 23 + 1)
            {
                fecha.AddDays(1);
            }

            return DateTime.Parse($"{fecha.Year}-{fecha.Month}-{fecha.Day} {hora}:{minuto}");
        }

        public bool Salida(DateTime fecha)
        {


            this.FechaSalida = AdaptaFecha(fecha);
            TimeSpan minutos = this.FechaSalida - this.FechaEntrada;
            this.Minutos = minutos.TotalMinutes;
            this.Horas = minutos.TotalHours;

            //Creamos el nuevo registro de horas
            string tabla = "horas";
            string[] campos = new string[]
            {
                "id_empleado",
                "nombre",
                "fecha_valor_entrada",
                "fecha_valor_salida",
                "minutos",
                "horas"
            };
            string[] valores = new string[]
            {
                this.IdEmpleado,
                this.Nombre,
                this.FechaEntrada.ToString("yyyy-MM-dd HH:mm"),
                this.FechaSalida.ToString("yyyy-MM-dd HH:mm"),
                this.Minutos.ToString(),
                this.Horas.ToString().Replace(",",".")
            };
            string respuesta = conexion.NuevoRegistro(tabla, campos, valores);
            if (respuesta == null)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"No se ha podido actualizar la entrada/salida del empleado.\n{respuesta}", "Nueva entrada/salida",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            
        }

    }
}
