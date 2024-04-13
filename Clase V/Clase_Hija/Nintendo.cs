using Clase_V.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_V.Clase_Hija
{
    internal class Nintendo : ClasConsola
    {
        public bool EsPortatil { get; set; }

        public string MostrarDetallesNintendo()
        {
            return $"ES Portatil: {EsPortatil}";
        }

    }

}