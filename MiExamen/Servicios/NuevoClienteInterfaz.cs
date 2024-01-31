using MiExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiExamen.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentran los métodos de creación de clientes 
    /// y el que ordena y muestra a los mismos.
    /// <author>CHI - 31/01/2024</author>
    /// </summary>
    internal interface NuevoClienteInterfaz
    {
        /// <summary>
        /// Método que contiene la lógica que añade un nuevo cliente
        /// <author>CHI - 31/01/2024</author>
        /// </summary>
        public void añadirCliente(List<ClienteDto> listaAntigua);

        /// <summary>
        /// Método que contiene la lógica que muestra y ordena los clientes
        /// <author>CHI - 31/01/2024</author>
        /// </summary>
        public void ordernarCliente(List<ClienteDto> listaAntigua);
    }
}
