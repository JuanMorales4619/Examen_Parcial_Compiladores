using Examen_Parcial_Compiladores.AnalizadorLexico;
using Examen_Parcial_Compiladores.GestorErrores;
using Examen_Parcial_Compiladores.Traduccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Parcial_Compiladores.AnalisisSintactico
{
    public class AnalizadorSintactico
    {
        private AnalizadorLexicoLetra letra =new AnalizadorLexicoLetra();
        private AnalizadorLexicoNumero numero = new AnalizadorLexicoNumero();
        private AnalizadorLexicoPunto punto = new AnalizadorLexicoPunto();
        private ComponenteLexico componente;
        private int cont = 0;
        private string traduccion = "";


        private void DevolverSiguienteComponenteLexico(int opcion)
        {
            if (opcion.Equals(1))
            {
                componente = letra.DevolverSiguienteComponente();
            }
            else if (opcion.Equals(2))
            {
                componente = letra.DevolverSiguienteComponente();
            }
            else if (opcion.Equals(3))
            {
                componente = numero.DevolverSiguienteComponente();
            }else if (opcion.Equals(4))
            {
                componente = numero.DevolverSiguienteComponente();
            }else if (opcion.Equals(5))
            {
                componente = punto.DevolverSiguienteComponente();
            }else if (opcion.Equals(6))
            {
                componente = punto.DevolverSiguienteComponente();
            }
            
        }

        public List<string> Analizar(int tipo)
        {
            List<string> lista = new List<string>();
            cont = tipo;
            string resultado = "";
            DevolverSiguienteComponenteLexico(cont);
            Entrada();
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
            lista.Add(resultado);
            lista.Add(traduccion);
            return lista;
        }

        private void Entrada()
        {
            Categoria();
            DevolverSiguienteComponenteLexico(cont);
            if (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.Categoria))
            {
                Entrada();
            }
        }
        private void Categoria()
        {
            //muchas categorias
            Texto texto = new Texto();
            traduccion = traduccion + texto.DevolverCaracterTraducido(componente.Categoria, cont);
            traduccion.Trim();
        }
    }
}
