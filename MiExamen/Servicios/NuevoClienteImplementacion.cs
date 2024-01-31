using MiExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiExamen.Servicios
{
    /// <summary>
    /// Clase donde se encuentran los métodos donde se añadirán un nuevo cliente, y el que
    /// los ordenará por edad y mostrarlos por pantalla
    /// <author>CHI - 31/01/2024</author>
    /// </summary>
    internal class NuevoClienteImplementacion : NuevoClienteInterfaz
    {
        

        public void añadirCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Datos del cliente");

            Console.WriteLine("Id: ");
            cliente.Id = Convert.ToInt64(Console.ReadLine());
             
            Console.WriteLine("Nombre: ");
            cliente.Nombre = Console.ReadLine();

            Console.WriteLine("Apellido: ");
            cliente.Apellidos = Console.ReadLine();

            Console.WriteLine("Edad: ");
            cliente.Edad = Convert.ToInt32(Console.ReadLine());

            
            listaAntigua.Add(cliente);

          
            
        }
        public void ordernarCliente(List<ClienteDto> listaAntigua)
        {
          
            ClienteDto cliente = new ClienteDto();

            for (int i = 0; i < listaAntigua.Count; i++)
            {
                for(int j = 0; j < listaAntigua.Count - 1 -i; j++)
                {
                    if (listaAntigua[j + 1].Edad > listaAntigua[j].Edad)
                    {

                        ClienteDto aux = listaAntigua[j];
                        listaAntigua[j] = listaAntigua[j + 1];
                        listaAntigua[j + 1] = aux;

                        
                    }

                }
            }
           
           
            


        }

    }
}
