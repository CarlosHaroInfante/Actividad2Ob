using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiExamen.Servicios
{
    /// <summary>
    /// Clase donde la implementación del menú
    /// <author>CHI - 31/01/2024</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        public int menu()
        {

            Console.WriteLine("Menú de Clientes");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Añadir nuevo cliente");
            Console.WriteLine("[2] - Ordenar lista por edad del cliente");
            
            

            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;


        }
    }
}
