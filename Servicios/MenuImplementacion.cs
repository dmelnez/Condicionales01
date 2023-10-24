using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01Condicionales.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {


        public int solictarNumero()
        {
            int valor;
            Console.WriteLine("Indique un Valor Numerico");
            valor = Convert.ToInt32(Console.ReadLine());
            return valor;
        }


    }
}
