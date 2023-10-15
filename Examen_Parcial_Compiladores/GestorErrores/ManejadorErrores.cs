using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.GestorErrores
{
    public class ManejadorErrores
    {
        private Dictionary<TipoError, List<Error>> errores = new Dictionary<TipoError, List<Error>>();
        private static readonly ManejadorErrores INSTANCIA = new ManejadorErrores();

        private ManejadorErrores() 
        {
            Limpiar();
        }
        public void Limpiar()
        {
            errores.Clear();
            errores.Add(TipoError.LEXICO, new List<Error>());
            errores.Add(TipoError.SINTACTICO, new List<Error>());
            errores.Add(TipoError.SEMANTICO, new List<Error>());
            errores.Add(TipoError.OPTINIZACION, new List<Error>());
            errores.Add(TipoError.GENERACION_CODIGO_FINAL, new List<Error>());
            errores.Add(TipoError.GENERADOR_CODIGO_INTERMEDIO, new List<Error>());
        }
        public static ManejadorErrores ObtenerManejadorErrores()
        { 
            return INSTANCIA;
        }
        public void ReportarError(Error error)
        {
            if (error != null)
            {
                errores[error.Tipo].Add(error);

                if (CategoriaError.STOPPER.Equals(error.Categoria))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("*************************ERROR TIPO STOPPER**************************").Append("\r\n");
                    sb.Append("Se ha presentado un error de tipo STOPPER dentro del proceso ").Append(error.Tipo).Append("\r\n");
                    sb.Append("Por favor solucione el problema para llevar a cabo nuevamente el proceso de compilacion").Append("\r\n");
                    sb.Append("Verifique la tabla de errores para tener mayor detalle").Append("\r\n");
                    throw new Exception(sb.ToString());
                }
            }
        }
        public bool HayErrores(TipoError tipo)
        {
            return errores.ContainsKey(tipo) && errores[tipo].Count > 0;
        }
        public bool HayErroresAnalisis()
        {
            return HayErrores(TipoError.LEXICO) || HayErrores(TipoError.SINTACTICO) || HayErrores(TipoError.SEMANTICO);
        }
        public bool HayErroresSintesis()
        {
            return HayErrores(TipoError.OPTINIZACION) || HayErrores(TipoError.GENERACION_CODIGO_FINAL) || HayErrores(TipoError.GENERADOR_CODIGO_INTERMEDIO);
        }
        public bool hayErroresCompilacion()
        {
            return HayErroresAnalisis() || HayErroresSintesis();
        }
        public List<Error> ObtenerErrores(TipoError tipo)
        {
            return errores[tipo];
        }
    }
}
