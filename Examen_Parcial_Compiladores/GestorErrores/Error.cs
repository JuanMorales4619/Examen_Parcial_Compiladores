﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.GestorErrores
{
    public class Error
    {
        private int numeroLinea;
        private int posicionInicial;
        private int posicionFinal;
        private string lexema;
        private string falla;
        private string causa;
        private string solucion;
        private TipoError tipo;
        private CategoriaError categoria;

        private Error(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, string falla, 
            string causa, string solucion, TipoError tipo, CategoriaError categoria)
        {
            this.numeroLinea = numeroLinea;
            this.posicionInicial = posicionInicial;
            this.posicionFinal = posicionFinal;
            this.lexema = lexema;
            this.falla = falla;
            this.causa = causa;
            this.solucion = solucion;
            this.tipo = tipo;
            this.categoria = categoria;
        }

        public static Error CREAR_ERROR_LEXICO_RECUPERABLE(int numeroLinea, int posicionInicial,
            string lexema, string falla, string causa, string solucion)
        {
            return new Error(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, falla, causa
                , solucion, TipoError.LEXICO, CategoriaError.RECUPERABLE);
        }
        public static Error CREAR_ERROR_LEXICO_STOPPER(int numeroLinea, int posicionInicial,
            string lexema, string falla, string causa, string solucion)
        {
            return new Error(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, falla, causa
                , solucion, TipoError.LEXICO, CategoriaError.STOPPER);
        }
        public static Error CREAR_ERROR_SINTACTICO_RECUPERABLE(int numeroLinea, int posicionInicial,
            string lexema, string falla, string causa, string solucion)
        {
            return new Error(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, falla, causa
                , solucion, TipoError.SINTACTICO, CategoriaError.RECUPERABLE);
        }
        public static Error CREAR_ERROR_SINTACTICO_STOPPER(int numeroLinea, int posicionInicial,
            string lexema, string falla, string causa, string solucion)
        {
            return new Error(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, falla, causa
                , solucion, TipoError.SINTACTICO, CategoriaError.STOPPER);
        }


        public int NumeroLinea { get => numeroLinea; set => numeroLinea = value; }
        public int PosicionInicial { get => posicionInicial; set => posicionInicial = value; }
        public int PosicionFinal { get => posicionFinal; set => posicionFinal = value; }
        public string Lexema { get => lexema; set => lexema = value; }
        public string Falla { get => falla; set => falla = value; }
        public string Causa { get => causa; set => causa = value; }
        public string Solucion { get => solucion; set => solucion = value; }
        public TipoError Tipo { get => tipo; set => tipo = value; }
        public CategoriaError Categoria { get => categoria; set => categoria = value; }



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
            sb.Append("Causa: ").Append(causa).Append("\r\n");
            sb.Append("Falla: ").Append(falla).Append("\r\n");
            sb.Append("Solucion: ").Append(solucion).Append("\r\n");
            sb.Append("..................................FIN.............................").Append("\r\n");

            return sb.ToString();
        }
    }
}
