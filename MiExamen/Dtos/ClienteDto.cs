using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiExamen.Dtos
{
    /// <summary>
    /// Clase donde se encuentra los tipos de datos que se encontrarán en un cliente, getters y setters y el toString()
    /// <author>CHI - 31/01/2024</author>
    /// </summary>

    internal class ClienteDto
    {
        long id;

        string nombre = "aaaaa";

        string apellidos = "aaaaa";

        int edad = 99;

        

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }


        public ClienteDto(long id, string nombre, string apellidos, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        public ClienteDto() { } 

        override
        public string ToString()
        {

            string datos = "idCliente " + this.id +
                " Nombre y Apellidos " + this.apellidos + this.Nombre +
                " Edad " + this.edad;

            return datos;
        }

       
    }
}
