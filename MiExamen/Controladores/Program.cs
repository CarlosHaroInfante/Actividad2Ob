using MiExamen.Servicios;
using MiExamen.Dtos;

namespace MiExamen
{
    /// <summary>
    /// Clase donde se encuentra el main de la aplicación
    /// <author>CHI - 31/01/2024</author>
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main de la aplicación donde se encuentra la llamadas a los métodos, la creación de la lista
        /// , el bool para que se cierre el menú y el switch para que el usuario pueda elegir una opción.
        /// <author>CHI - 31/01/2024</author>
        /// </summary>

        static void Main(string[] args)
        {

            MenuInterfaz menu = new MenuImplementacion();
            List<ClienteDto> cliente = new List<ClienteDto>();
            NuevoClienteInterfaz cli = new NuevoClienteImplementacion();
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {

                int opcion = menu.menu();
                

                switch (opcion) { 
                
                    case 0:
                        Console.WriteLine("Se cerrará el menú");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Se añadirá un nuevo usuario");
                        cli.añadirCliente(cliente);
                        break;
                    case 2:
                        Console.WriteLine("Se ordenará los usuarios por edad");
                        cli.ordernarCliente(cliente);
                        foreach (ClienteDto clientes in cliente)
                        {
                            Console.WriteLine(clientes.ToString());
                        }
                        break;

                    default: 
                        Console.WriteLine("Ninguna opción válida");
                        break;
                
                }


            }

        }


    }


}
