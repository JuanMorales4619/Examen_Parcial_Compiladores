using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.Util
{
    internal class UtilTexto
    {
        public static bool EsFinArchivo(string caracter)
        {
            return "@EOF@".Equals(caracter);
        }
        public static bool EsFinLinea(string caracter)
        {
            return "@FL@".Equals(caracter);
        }
    }
}