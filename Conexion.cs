using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoofGroomer
{
    class Conexion
    {
        //private static String servidor = "com331.raiolanetworks.es";
        //private static String dataBase = "antoferc_pelcan";
        //private static String user = "antoferc_pelcan";
        //private static String password = "Pelcan4883";

        private static string cadenaConexion = $@"Data Source= {Directory.GetCurrentDirectory()}\woofGroomerDB.db; Version=3";
        private static SQLiteConnection miConexion = new SQLiteConnection(cadenaConexion);

        //private static String cadenaConexion = $"server={servidor};database={dataBase};user id={user};password={password}";
        //private MySqlConnection con = new MySqlConnection(cadenaConexion);

        public void AbreConexion()
        {
            try
            {
                if (miConexion.State == ConnectionState.Closed)
                {
                    miConexion.Open();
                   
                }


            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo conectar.\n\n{e}");
            }
        }

        public void CierraConexion()
        {
            if (miConexion.State == ConnectionState.Open)
            {
                try
                {
                    if (miConexion.State == ConnectionState.Open)
                    {
                        miConexion.Close();
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public DataTable DameTablaCompleta(String consulta)
        {
            DataTable myDT = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(consulta, miConexion);
            da.Fill(myDT);
            return myDT;
        }

        /// <summary>
        /// Crea un nuevo registro en la base de datos
        /// </summary>
        /// <param name="tabla">Especifique el nombre de la tabla</param>
        /// <param name="campos">Array con los campos de la tabla</param>
        /// <param name="valores">Array con los valores a asignar al nuevo registro</param>
        /// <returns>String con el resultado de la inserción</returns>
        public string NuevoRegistro(string tabla, string[] campos, string[] valores)
        {
            AbreConexion();
            string consulta = $"INSERT INTO {tabla} ";

            int contador = 0;
            foreach (string campo in campos)
            {
                if (contador != 0)
                {
                    consulta += ",`";
                }
                else
                {
                    consulta += "(`";
                }
                consulta += campo + "`";
                contador += 1;
            }

            consulta += ") VALUES ";

            contador = 0;
            foreach (string valor in valores)
            {
                if (contador != 0)
                {
                    consulta += ",'";
                }
                else
                {
                    consulta += "('";
                }
                consulta += valor + "'";
                contador += 1;
            }

            consulta += ");";

            string resultado;
            SQLiteCommand cmd = new SQLiteCommand(consulta, miConexion);


            try
            {
                cmd.ExecuteNonQuery();
                resultado = null;
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467259)
                {
                    resultado = "Ya existe un usuario con el DNI indicado";
                }
                else
                {
                    resultado = ex.Message.ToString();
                }


            }


            CierraConexion();
            return resultado;
        }


        public string NuevoRegistro(string consulta)
        {
            AbreConexion();
            string resultado;
            SQLiteCommand cmd = new SQLiteCommand(consulta, miConexion);

            try
            {
                cmd.ExecuteNonQuery();
                resultado = null;
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467259)
                {
                    resultado = "Ya existe un registro con el ID indicado";
                }
                else
                {
                    resultado = ex.Message.ToString();
                }


            }

            CierraConexion();
            return resultado;

        }

        public string ActualizaRegistro(string consulta)
        {
            AbreConexion();
            string resultado = null;
            SQLiteCommand cmd = new SQLiteCommand(consulta, miConexion);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                resultado = ex.Message.ToString();
            }
            finally
            {
                CierraConexion();
            }

            
            return resultado;
        }

        public string EliminarRegistro(string tabla, string campo, string valor)
        {
            AbreConexion();
            string consulta = $"DELETE FROM {tabla} WHERE `{campo}` = '{valor}';";
            string resultado;
            SQLiteCommand cmd = new SQLiteCommand(consulta, miConexion);
            try
            {
                cmd.ExecuteNonQuery();
                resultado = null;
            }
            catch (Exception ex)
            {
                resultado = ex.Message.ToString();
            }

            CierraConexion();

            return resultado;



        }

        //private string consultaCreacionDataBase = "" +




    }
}

