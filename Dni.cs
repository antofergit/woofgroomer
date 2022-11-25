using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoofGroomer
{
    class Dni
    {

        private int numero;
        public string numeroString;
        private string letra1;
        private string letra2;
        public Dictionary<int, String> dict = new Dictionary<int, String>()
        {
            {0,"T"},
            {1,"R" },
            {2,"W" },
            {3,"A" },
            {4,"G" },
            {5,"M" },
            {6,"Y" },
            {7,"F" },
            {8,"P" },
            {9,"D" },
            {10,"X" },
            {11,"B" },
            {12,"N" },
            {13,"J" },
            {14,"Z" },
            {15,"S" },
            {16,"Q" },
            {17,"V" },
            {18,"H" },
            {19,"L" },
            {20,"C" },
            {21,"K" },
            {22,"E" }

        };

        public bool CompruebaDNI(string dni)
        {
            bool validacion = false;
            dni = dni.ToUpper();

            if (dni.Length == 9)
            {

                try
                {
                    numeroString = dni.Substring(0, dni.Length - 1);
                    letra1 = dni.Substring(0, 1);

                    numeroString = numeroString.Replace('X', '0').Replace('Y', '1').Replace('Z', '2');

                    //MessageBox.Show(numeroString);
                    numero = Convert.ToInt32(numeroString);
                    int divisor = numero % 23;
                    letra2 = dni.Substring(dni.Length - 1);

                    if (letra2 == dict[divisor])
                    {
                        validacion = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"El DNI introducido : {dni} no es correcto");
                }
            }


            return validacion;

        }

        public string DNIaleatorio()
        {
            string nuevoDNI;
            Random rnd = new Random();
            int aleatorio = rnd.Next(10000000, 99999999);
            int divisor = aleatorio % 23;
            string letra = dict[divisor];
            nuevoDNI = aleatorio.ToString() + letra;


            return nuevoDNI;
        }


    }

}

