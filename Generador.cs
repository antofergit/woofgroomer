using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoofGroomer
{
    class Generador
    {

        //Campo de clase
        private DataTable dt;
        private Conexion conexion;
        private List<string> fechas_validas = new List<string>();
        

        //Propiedades
        public string fechaInicio { get; }
        public string fechaFin { get; }
        public float Suma { get; set; }

        //Constructor
        public Generador(string fechaInicio, string fechaFin)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.Suma = 0;

            conexion = new Conexion();

            string consultaFechas = $"select distinct fecha from listado_de_visitas where fecha between '{fechaInicio}' and '{fechaFin}'";
            dt = conexion.DameTablaCompleta(consultaFechas);
            foreach (DataRow fila in dt.Rows)
            {
                fechas_validas.Add(fila.ItemArray[0].ToString());
            }

            string consulta = $"select * from listado_de_visitas where listado_de_visitas.fecha between '{fechaInicio}' and '{fechaFin}'";
            dt.Clear();
            dt = conexion.DameTablaCompleta(consulta);


        }

        /// <summary>
        /// Método que genera el cálculo según su máximo
        /// </summary>
        /// <param name="maximo">Cantidad máxima aproximada que debe generar ventas</param>
        /// <returns></returns>
        public DataTable Genera(float maximo)
        {
            string consulta;
            List<string> listaVisitas = new List<string>();

            //Primero debemos de tomar todas las visitas que su tipo de pago sean bancarios
            DataTable bancarios = conexion.DameTablaCompleta
                ($"select * from listado_de_visitas_bancarias where bancario = 1 and fecha between '{fechaInicio}' and '{fechaFin}'");
            foreach (DataRow fila in bancarios.Rows)
            {
                listaVisitas.Add(fila.ItemArray[0].ToString());
                Suma += Convert.ToSingle(fila.ItemArray[1].ToString());
            }

            bancarios.Clear();

            //Ahora pasamos 
            bancarios = conexion.DameTablaCompleta
                ($"select * from listado_de_visitas_bancarias where bancario = 0 and fecha between '{fechaInicio}' and '{fechaFin}'");

            while (Suma < maximo)
            {
                foreach(string fechaValida in fechas_validas)
                {
                   foreach (DataRow fila in bancarios.Rows)
                    {
                        if (fila.ItemArray[2].ToString() == fechaValida)
                        {
                            listaVisitas.Add(fila.ItemArray[0].ToString());
                            Suma += Convert.ToSingle(fila.ItemArray[1].ToString());
                            fila.ItemArray[2] = "0";
                            break;
                        }
                       
                    }
                   
                    if (Suma >= maximo) break;

                }
            }

            DataTable paraColumnas = conexion.DameTablaCompleta("select * from listado_de_visitas");
            DataTable final = paraColumnas.Clone();
            
            foreach (string visita in listaVisitas)
            {
                consulta = $"select * from listado_de_visitas where id_visita = {visita}";
                DataTable temporal = conexion.DameTablaCompleta(consulta);
                final.Rows.Add(temporal.Rows[0].ItemArray);


            }

            return final;

        }




    }
}
