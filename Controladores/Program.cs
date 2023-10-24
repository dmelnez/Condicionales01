using DocumentFormat.OpenXml.Spreadsheet;
using Ejercicio01Condicionales.Servicios;

namespace Ejercicio01Condicionales;


class Program
{
    static void Main(String[] args)
    {
        MenuInterfaz nu = new MenuImplementacion();
        int valor01 = nu.solicitarNumero();


        if ((valor01%2)==0)
        {
            Console.WriteLine("El valor el Par");
        }

        else
        {
            Console.WriteLine("El valor es Impar");
        }

    }
}
