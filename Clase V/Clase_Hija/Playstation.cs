using Clase_V.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_V.Clase_Hija
{
    internal class Playstation : ClasConsola
    {
        public required string ModeloControlador { get; set; }

        public new string MostrarDetalles() => $"Modelo de la consola: {ModeloControlador}"



