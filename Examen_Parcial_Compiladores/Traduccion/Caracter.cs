using Examen_Parcial_Compiladores.AnalizadorLexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.Traduccion
{
    public class Caracter
    {
        private CategoriaGramatical categoria;
        private string letra;
        private string numero;
        private string puntos;

        public Caracter(CategoriaGramatical categoria, string letra, string numero, string puntos)
        {
            Categoria = categoria;
            Letra = letra;
            Numero = numero;
            Puntos = puntos;
        }

        public CategoriaGramatical Categoria { get => categoria; set => categoria = value; }
        public string Letra { get => letra; set => letra = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Puntos { get => puntos; set => puntos = value; }
    }
}
