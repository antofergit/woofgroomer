using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoofGroomer
{
    public static class Generador2
    {

        public static DataTable Genara (string fechaInicio, string fechaFinal, double limite)
        {
            DataTable tabla;
            DataTable tablaAuxiliar;
            Conexion conexion = new Conexion();

            string consulta = $"select fecha, dni_cliente, nombre_cliente, total_neto, total_impuestos, total_venta, descripcion from listado_de_visitas where fecha between '{fechaInicio}' and '{fechaFinal}' AND tipo_pago <> 0";
            tabla = conexion.DameTablaCompleta(consulta);

            consulta = $"select fecha, dni_cliente, nombre_cliente, total_neto, total_impuestos, total_venta, descripcion from listado_de_visitas where fecha between '{fechaInicio}' and '{fechaFinal}' AND tipo_pago = 0";
            tablaAuxiliar = conexion.DameTablaCompleta(consulta);

            double suma = 0;
            foreach (DataRow fila in tabla.Rows)
            {
                double importe = Convert.ToDouble(fila.ItemArray[5].ToString());
                suma += importe;
            }
            Random rnd = new Random();

            while (suma < limite)
            {
                if (tablaAuxiliar.Rows.Count > 0)
                {
                    int auxiliar = rnd.Next(tablaAuxiliar.Rows.Count - 1);
                    DataRow row = tablaAuxiliar.Rows[auxiliar];

                    double importe = Convert.ToDouble(row.ItemArray[5].ToString());
                    suma += importe;
                    tabla.ImportRow(row);
                    tablaAuxiliar.Rows.Remove(row);
                    //tablaAuxiliar.Rows[auxiliar].Delete();
                }
                else
                {
                    suma = limite;
                }
                

            }
            return tabla;
        }





    }
}
