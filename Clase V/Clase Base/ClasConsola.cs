using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_V.Clase_Base
{
    internal class ClasConsola
    {
        public string Marca { get; set; }

        public int año { get; set; }


        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca:  { Marca}, año de lanzamiento: {año}, " );
        }

    }
}
