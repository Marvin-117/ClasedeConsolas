using Clase_V.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_V.Clase_Hija
{
    internal class Xbox: ClasConsola
    {
        public required string Kinet { get; set; }
        public string MostrarDetallesXbox()
        {
            return $"Tiene Kinet: {Kinet}";
        }
    }
}
