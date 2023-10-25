using Examen_Parcial_Compiladores.AnalizadorLexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.Traduccion
{
    public class Texto
    {
        private string cadena;
        private Dictionary<CategoriaGramatical, Caracter> diccionario = new Dictionary<CategoriaGramatical, Caracter> ();
        public Texto() { }

        public string DevolverCaracterTraducido(CategoriaGramatical categoria, int tipo)
        {
            Llenar();
            if (tipo.Equals(3) || tipo.Equals(5))
            {
                cadena = diccionario[categoria].Letra;

            }
            else if (tipo.Equals(2) || tipo.Equals(6)) 
            {
                cadena = diccionario[categoria].Numero;
            }
            else if (tipo.Equals(1) || tipo.Equals(4))
            {
                cadena = diccionario[categoria].Puntos;
            }

                return cadena;
        }
        private void Llenar()
        {
            diccionario.Add(CategoriaGramatical.LETRA_A, new Caracter(CategoriaGramatical.LETRA_A, "A", "11 ", " . . "));
            diccionario.Add(CategoriaGramatical.LETRA_B, new Caracter(CategoriaGramatical.LETRA_B, "B", "12 ", " . .. "));
            diccionario.Add(CategoriaGramatical.LETRA_C, new Caracter(CategoriaGramatical.LETRA_C, "C", "13 ", " . ... "));
            diccionario.Add(CategoriaGramatical.LETRA_D, new Caracter(CategoriaGramatical.LETRA_D, "D", "14 ", " . .... "));
            diccionario.Add(CategoriaGramatical.LETRA_E, new Caracter(CategoriaGramatical.LETRA_E, "E", "15 ", " . ..... "));
            diccionario.Add(CategoriaGramatical.LETRA_F, new Caracter(CategoriaGramatical.LETRA_F, "F", "16 ", " . ...... "));
            diccionario.Add(CategoriaGramatical.LETRA_G, new Caracter(CategoriaGramatical.LETRA_G, "G", "17 ", " . ....... "));
            diccionario.Add(CategoriaGramatical.LETRA_H, new Caracter(CategoriaGramatical.LETRA_H, "H", "18 ", " . ........ "));
            diccionario.Add(CategoriaGramatical.LETRA_I, new Caracter(CategoriaGramatical.LETRA_I, "I", "19 ", " . ......... "));
            diccionario.Add(CategoriaGramatical.LETRA_J, new Caracter(CategoriaGramatical.LETRA_J, "J", "21 ", " .. . "));
            diccionario.Add(CategoriaGramatical.LETRA_K, new Caracter(CategoriaGramatical.LETRA_K, "K", "22 ", " .. .. "));
            diccionario.Add(CategoriaGramatical.LETRA_L, new Caracter(CategoriaGramatical.LETRA_L, "L", "23 ", " .. ... "));
            diccionario.Add(CategoriaGramatical.LETRA_M, new Caracter(CategoriaGramatical.LETRA_M, "M", "24 ", " .. .... "));
            diccionario.Add(CategoriaGramatical.LETRA_N, new Caracter(CategoriaGramatical.LETRA_N, "N", "25 ", " .. ..... "));
            diccionario.Add(CategoriaGramatical.LETRA_O, new Caracter(CategoriaGramatical.LETRA_O, "O", "27 ", " .. ....... "));
            diccionario.Add(CategoriaGramatical.LETRA_P, new Caracter(CategoriaGramatical.LETRA_P, "P", "28 ", " .. ........ "));
            diccionario.Add(CategoriaGramatical.LETRA_Q, new Caracter(CategoriaGramatical.LETRA_Q, "Q", "29 ", " .. ......... "));
            diccionario.Add(CategoriaGramatical.LETRA_R, new Caracter(CategoriaGramatical.LETRA_R, "R", "31 ", " ... . "));
            diccionario.Add(CategoriaGramatical.LETRA_S, new Caracter(CategoriaGramatical.LETRA_S, "S", "32 ", " ... .. "));
            diccionario.Add(CategoriaGramatical.LETRA_T, new Caracter(CategoriaGramatical.LETRA_T, "T", "33 ", " ... ... "));
            diccionario.Add(CategoriaGramatical.LETRA_U, new Caracter(CategoriaGramatical.LETRA_U, "U", "34 ", " ... .... "));
            diccionario.Add(CategoriaGramatical.LETRA_V, new Caracter(CategoriaGramatical.LETRA_V, "V", "35 ", " ... ..... "));
            diccionario.Add(CategoriaGramatical.LETRA_W, new Caracter(CategoriaGramatical.LETRA_W, "W", "36 ", " ... ...... "));
            diccionario.Add(CategoriaGramatical.LETRA_X, new Caracter(CategoriaGramatical.LETRA_X, "X", "37 ", " ... ....... "));
            diccionario.Add(CategoriaGramatical.LETRA_Y, new Caracter(CategoriaGramatical.LETRA_Y, "Y", "38 ", " ... ........ "));
            diccionario.Add(CategoriaGramatical.LETRA_Z, new Caracter(CategoriaGramatical.LETRA_Z, "Z", "39 ", " ... ......... "));
            diccionario.Add(CategoriaGramatical.LETRA_Ñ, new Caracter(CategoriaGramatical.LETRA_Ñ, "Ñ", "26 ", " .. ...... "));
            diccionario.Add(CategoriaGramatical.LETRA_TILDADA_A, new Caracter(CategoriaGramatical.LETRA_TILDADA_A, "Á", "41 ", " .... . "));
            diccionario.Add(CategoriaGramatical.LETRA_TILDADA_E, new Caracter(CategoriaGramatical.LETRA_TILDADA_E, "É", "42 ", " .... .. "));
            diccionario.Add(CategoriaGramatical.LETRA_TILDADA_I, new Caracter(CategoriaGramatical.LETRA_TILDADA_I, "Í", "43 ", " .... ... "));
            diccionario.Add(CategoriaGramatical.LETRA_TILDADA_O, new Caracter(CategoriaGramatical.LETRA_TILDADA_O, "Ó", "44 ", " .... .... "));
            diccionario.Add(CategoriaGramatical.LETRA_TILDADA_U, new Caracter(CategoriaGramatical.LETRA_TILDADA_U, "Ú", "45 ", " .... ..... "));
            diccionario.Add(CategoriaGramatical.LETRA_DIERISIS_U, new Caracter(CategoriaGramatical.LETRA_DIERISIS_U, "Ü", "46 ", " .... ...... "));
            diccionario.Add(CategoriaGramatical.Digito_0, new Caracter(CategoriaGramatical.Digito_0, "0", "47 ", " .... ....... "));
            diccionario.Add(CategoriaGramatical.Digito_1, new Caracter(CategoriaGramatical.Digito_1, "1", "48 ", " .... ........ "));
            diccionario.Add(CategoriaGramatical.Digito_2, new Caracter(CategoriaGramatical.Digito_2, "2", "49 ", " .... ......... "));
            diccionario.Add(CategoriaGramatical.Digito_3, new Caracter(CategoriaGramatical.Digito_3, "3", "51 ", " ..... . "));
            diccionario.Add(CategoriaGramatical.Digito_4, new Caracter(CategoriaGramatical.Digito_4, "4", "52 ", " ..... .. "));
            diccionario.Add(CategoriaGramatical.Digito_5, new Caracter(CategoriaGramatical.Digito_5, "5", "53 ", " ..... ... "));
            diccionario.Add(CategoriaGramatical.Digito_6, new Caracter(CategoriaGramatical.Digito_6, "6", "54 ", " ..... .... "));
            diccionario.Add(CategoriaGramatical.Digito_7, new Caracter(CategoriaGramatical.Digito_7, "7", "55 ", " ..... ..... "));
            diccionario.Add(CategoriaGramatical.Digito_8, new Caracter(CategoriaGramatical.Digito_8, "8", "56 ", " ..... ...... "));
            diccionario.Add(CategoriaGramatical.Digito_9, new Caracter(CategoriaGramatical.Digito_9, "9", "57 ", " ..... ....... "));
            diccionario.Add(CategoriaGramatical.Coma, new Caracter(CategoriaGramatical.Coma, ",", "58 ", " ..... ........ "));
            diccionario.Add(CategoriaGramatical.Punto_y_coma, new Caracter(CategoriaGramatical.Punto_y_coma, ";", "59 ", " ..... ......... "));
            diccionario.Add(CategoriaGramatical.Punto, new Caracter(CategoriaGramatical.Punto, ".", "61 ", " ...... . "));
            diccionario.Add(CategoriaGramatical.Dos_puntos, new Caracter(CategoriaGramatical.Dos_puntos, ":", "62 ", " ...... .. "));
            diccionario.Add(CategoriaGramatical.Parentesis_abre, new Caracter(CategoriaGramatical.Parentesis_abre, "(", "63 ", " ...... ... "));
            diccionario.Add(CategoriaGramatical.Parentesis_cierra, new Caracter(CategoriaGramatical.Parentesis_cierra, ")", "64 ", " ...... .... "));
            diccionario.Add(CategoriaGramatical.Corchetes_abre, new Caracter(CategoriaGramatical.Corchetes_abre, "[", "65 ", " ...... ..... "));
            diccionario.Add(CategoriaGramatical.Corchetes_cierra, new Caracter(CategoriaGramatical.Corchetes_cierra, "]", "66 ", " ...... ...... "));
            diccionario.Add(CategoriaGramatical.Llaves_abre, new Caracter(CategoriaGramatical.Llaves_abre, "{", "67 ", " ...... ....... "));
            diccionario.Add(CategoriaGramatical.Llaves_cierra, new Caracter(CategoriaGramatical.Llaves_cierra, "}", "68 ", " ...... ........ "));
            diccionario.Add(CategoriaGramatical.Numeral, new Caracter(CategoriaGramatical.Numeral, "#", "69 ", " ...... ......... "));
            diccionario.Add(CategoriaGramatical.Signo_peso, new Caracter(CategoriaGramatical.Signo_peso, "$", "71 ", " ....... . "));
            diccionario.Add(CategoriaGramatical.SIGNO_AMPERSAN, new Caracter(CategoriaGramatical.SIGNO_AMPERSAN, "&", "72 ", " ....... .. "));
            diccionario.Add(CategoriaGramatical.SIGNO_ARROBA, new Caracter(CategoriaGramatical.SIGNO_ARROBA, "@", "73 ", " ....... ... "));
            diccionario.Add(CategoriaGramatical.SIGNO_MÁS, new Caracter(CategoriaGramatical.SIGNO_MÁS, "+", "74 ", " ....... .... "));
            diccionario.Add(CategoriaGramatical.SIGNO_MENOS, new Caracter(CategoriaGramatical.SIGNO_MENOS, "-", "75 ", " ....... ..... "));
            diccionario.Add(CategoriaGramatical.SIGNO_MULTIPLICACION, new Caracter(CategoriaGramatical.SIGNO_MULTIPLICACION, "*", "76 ", " ....... ...... "));
            diccionario.Add(CategoriaGramatical.SIGNO_DIVISION, new Caracter(CategoriaGramatical.SIGNO_DIVISION, "/", "77 ", " ....... ....... "));
            diccionario.Add(CategoriaGramatical.PORCENTAJE, new Caracter(CategoriaGramatical.PORCENTAJE, "%", "78 ", " ....... ........ "));
            diccionario.Add(CategoriaGramatical.SIGNO_IGUAL, new Caracter(CategoriaGramatical.SIGNO_IGUAL, "=", "79 ", " ....... ......... "));
            diccionario.Add(CategoriaGramatical.BARRA_INVERSA, new Caracter(CategoriaGramatical.BARRA_INVERSA, "\\", "81 ", " ........ . "));
            diccionario.Add(CategoriaGramatical.PALO, new Caracter(CategoriaGramatical.PALO, "|", "82 ", " ........ .. "));
            diccionario.Add(CategoriaGramatical.COMILLA, new Caracter(CategoriaGramatical.COMILLA, "\"", "83 ", " ........ ... "));
            diccionario.Add(CategoriaGramatical.ACENTO_CIRCUNFLEJO, new Caracter(CategoriaGramatical.ACENTO_CIRCUNFLEJO, "^", "85 ", " ........ ..... "));
            diccionario.Add(CategoriaGramatical.EXCLAMACION_ABRE, new Caracter(CategoriaGramatical.EXCLAMACION_ABRE, "¡", "86 ", " ........ ...... "));
            diccionario.Add(CategoriaGramatical.EXCLAMACION_CIERRA, new Caracter(CategoriaGramatical.EXCLAMACION_CIERRA, "!", "87 ", " ........ ....... "));
            diccionario.Add(CategoriaGramatical.SIGNO_DE_PREGUNTA_ABRE, new Caracter(CategoriaGramatical.SIGNO_DE_PREGUNTA_ABRE, "¿", "88 ", " ........ ........ "));
            diccionario.Add(CategoriaGramatical.SIGNO_DE_PREGUNTA_CIERRA, new Caracter(CategoriaGramatical.SIGNO_DE_PREGUNTA_CIERRA, "?", "89 ", " ........ ......... "));
            diccionario.Add(CategoriaGramatical.GUION_BAJO, new Caracter(CategoriaGramatical.GUION_BAJO, "_", "91 ", " ......... . "));
            diccionario.Add(CategoriaGramatical.MAYOR_QUE, new Caracter(CategoriaGramatical.MAYOR_QUE, ">", "92 ", " ......... .. "));
            diccionario.Add(CategoriaGramatical.MENOR_QUE, new Caracter(CategoriaGramatical.MENOR_QUE, "<", "93 ", " ......... ... "));
            diccionario.Add(CategoriaGramatical.SUPERINDICE_A, new Caracter(CategoriaGramatical.SUPERINDICE_A, "ª", "94 ", " ......... .... "));
            diccionario.Add(CategoriaGramatical.SUPERINDICE_0, new Caracter(CategoriaGramatical.SUPERINDICE_0, "º", "95 ", " ......... ..... "));
            diccionario.Add(CategoriaGramatical.VERGULILLA, new Caracter(CategoriaGramatical.VERGULILLA, "~", "96 ", " ......... ...... "));
            diccionario.Add(CategoriaGramatical.COMILLA_ABRE, new Caracter(CategoriaGramatical.COMILLA_ABRE, "«", "97 ", " ......... ....... "));
            diccionario.Add(CategoriaGramatical.COMILLA_CIERRA, new Caracter(CategoriaGramatical.COMILLA_CIERRA, "»", "98 ", " ......... ........ "));
            diccionario.Add(CategoriaGramatical.SIGNO_ESPACIO, new Caracter(CategoriaGramatical.SIGNO_ESPACIO, " ", "99 ", " ......... ......... "));
            diccionario.Add(CategoriaGramatical.COMILLA_SIMPLE, new Caracter(CategoriaGramatical.COMILLA_SIMPLE, "'", "84 ", " ........ .... "));

        }

    }
}