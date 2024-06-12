using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromedio
{
    public class calcularPromedio
    {
        public static double calPromedio(int[] conjunto)
        { 
            int suma = 0; 
            foreach (int numero in conjunto)
            {
                suma += numero;
            }

            return (double)suma / conjunto.Length;
        }
    }
}
