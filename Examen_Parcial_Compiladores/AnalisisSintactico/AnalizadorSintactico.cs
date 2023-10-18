using Examen_Parcial_Compiladores.AnalizadorLexico;
using Examen_Parcial_Compiladores.GestorErrores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.AnalisisSintactico
{
    public class AnalizadorSintactico
    {
        private AnalizadorLexicoLetra letra =new AnalizadorLexicoLetra();
        private AnalizadorLexicoNumero numero = new AnalizadorLexicoNumero();
        private AnalizadorLexicoPunto punto = new AnalizadorLexicoPunto();
        private ComponenteLexico componente;
        private string falla;
        private string causa;
        private string solucion;
        private int cont = 0;

        private void ReportarErrorSintacticoStopper()
        {
            Error error = Error.CREAR_ERROR_SINTACTICO_STOPPER(componente.NumeroLinea, componente.PosicionInicial, componente.Lexema, falla, causa, solucion);
            ManejadorErrores.ObtenerManejadorErrores().ReportarError(error);
        }
        private void ReportarErrorSintacticorRecuperable()
        {
            Error error = Error.CREAR_ERROR_SINTACTICO_STOPPER(componente.NumeroLinea, componente.PosicionInicial, componente.Lexema, falla, causa, solucion);
            ManejadorErrores.ObtenerManejadorErrores().ReportarError(error);
        }
        
        private void DevolverSiguienteComponenteLexico(int opcion)
        {
            if (opcion.Equals(1))
            {
                componente = letra.DevolverSiguienteComponente();
            }
            else if (opcion.Equals(2))
            {
                componente = numero.DevolverSiguienteComponente();
            }
            else if (opcion.Equals(3))
            {
                componente = punto.DevolverSiguienteComponente();
            }
            
        }
        
        public string AnalizarLetra()
        {
            cont = 1;
            string resultado = "";
            DevolverSiguienteComponenteLexico(cont);
            if (ManejadorErrores.ObtenerManejadorErrores().HayErroresAnalisis())
            {
                resultado = "El proceso de compilacion finalizo con errores";
            }
            else if (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.Categoria))
            {
                resultado = "Aunque el problema no presenta errores, faltaron componentes por evaluar...";
            }
            else
            {
                resultado = "El programa se encuentra bien escrito";
            }
            return resultado;
        }
        public string AnalizarNumero()
        {
            cont = 2;
            string resultado = "";
            DevolverSiguienteComponenteLexico(cont);
            if (ManejadorErrores.ObtenerManejadorErrores().HayErroresAnalisis())
            {
                resultado = "El proceso de compilacion finalizo con errores";
            }
            else if (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.Categoria))
            {
                resultado = "Aunque el problema no presenta errores, faltaron componentes por evaluar...";
            }
            else
            {
                resultado = "El programa se encuentra bien escrito";
            }
            return resultado;
        }
        public string AnalizarPunto()
        {
            cont = 3;
            string resultado = "";
            DevolverSiguienteComponenteLexico(cont);
            
            if (ManejadorErrores.ObtenerManejadorErrores().HayErroresAnalisis())
            {
                resultado = "El proceso de compilacion finalizo con errores";
            }
            else if (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.Categoria))
            {
                resultado = "Aunque el problema no presenta errores, faltaron componentes por evaluar...";
            }
            else
            {
                resultado = "El programa se encuentra bien escrito";
            }
            return resultado;
        }

        private void Entrada()
        {
            Categoria();
            if (!"@EOF@".Equals(componente.Categoria))
            {
                Entrada();
            }
        }
        private void Categoria()
        {
            //muchas categorias
        }
    }
}
