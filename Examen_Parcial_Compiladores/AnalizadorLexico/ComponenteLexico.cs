using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.AnalizadorLexico
{
    public  class ComponenteLexico
    {
        private int numeroLinea;
        private int posicionInicial;
        private int posicionFinal;
        private string lexema;
        private CategoriaGramatical categoria;
        private TipoComponente tipo;

        private ComponenteLexico(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, CategoriaGramatical categoria, TipoComponente tipo)
        {
            this.numeroLinea = numeroLinea;
            this.posicionInicial = posicionInicial;
            this.posicionFinal = posicionFinal;
            this.lexema = lexema;
            this.categoria = categoria;
            this.tipo = tipo;
        }
        public static ComponenteLexico CREAR_SIMBOLO(int numeroLinea, int posicionInicial, string lexema, CategoriaGramatical categoria)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionInicial+lexema.Length, lexema, categoria, TipoComponente.SIMBOLO);
        }
        public static ComponenteLexico CREAR_DUMMY(int numeroLinea, int posicionInicial, string lexema, CategoriaGramatical categoria)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, categoria, TipoComponente.DUMMY);
        }
        public static ComponenteLexico CREAR_PALABRA_RESERVADA(int numeroLinea, int posicionInicial, string lexema, CategoriaGramatical categoria)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, categoria, TipoComponente.PALABRA_RESERVADA);
        }
        public static ComponenteLexico CREAR_LITERAL(int numeroLinea, int posicionInicial, string lexema, CategoriaGramatical categoria)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, categoria, TipoComponente.LITERAL);
        }

        public int NumeroLinea { get => numeroLinea; set => numeroLinea = value; }
        public int PosicionInicial { get => posicionInicial; set => posicionInicial = (value < 0) ? 1 : value; }
        public int PosicionFinal { get => posicionFinal; set => posicionFinal = (value < 0 )? 1: value; }
        public string Lexema { get => lexema; set => lexema = value; }
        public CategoriaGramatical Categoria { get => categoria; set => categoria = value; }
        public TipoComponente Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("..................................INICIO.............................").Append("\r\n");
            sb.Append("Tipo: ").Append(tipo).Append("\r\n");
            sb.Append("Categoria: ").Append(categoria).Append("\r\n");
            sb.Append("Lexema: ").Append(lexema).Append("\r\n");
            sb.Append("Numero linea: ").Append(numeroLinea).Append("\r\n");
            sb.Append("Posicion inicial: ").Append(posicionInicial).Append("\r\n");
            sb.Append("Posicion final: ").Append(posicionFinal).Append("\r\n");
            sb.Append("..................................FIN.............................").Append("\r\n");

            return sb.ToString();
        }
    }
}
