using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.Cache
{
    internal class DataCache
    {
        private static Dictionary<int, Linea> programaFuente = new Dictionary<int, Linea>();

        public static void Limpiar()
        {
            programaFuente.Clear();
        }
        public static void AgregarLinea(String linea)
        {
            if (linea != null)
            {
                int numeroLinea = ObtenerProximaLinea();
                programaFuente.Add(numeroLinea, Linea.CREAR(numeroLinea, linea));
            }
        }
        public static void AgregarLienas(String[] lineas)
        {
            foreach (String linea in lineas)
            {
                AgregarLinea(linea);
            }
        }
        private static int ObtenerProximaLinea()
        {
            return programaFuente.Count + 1;
        }

        public static Linea ObtenerLinea(int numeroLiena)
        {
            int numeroUltimalinea = ObtenerProximaLinea();
            Linea lineaRetorno = Linea.CREAR(numeroUltimalinea, "@EOF@");
            if (numeroLiena <= 0)
            {
                throw new Exception("Numero de lineas invalido");
            }
            else if (numeroLiena <= programaFuente.Count)
            {
                lineaRetorno = programaFuente[numeroLiena];
            }
            
            return lineaRetorno;
        }



    }
}
