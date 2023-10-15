using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.AnalizadorLexico
{
    public enum CategoriaGramatical
    {
        LETRA_A, LETRA_B, LETRA_C, LETRA_D, LETRA_E, LETRA_F, LETRA_G, LETRA_H, LETRA_I, LETRA_J, LETRA_K, LETRA_L, LETRA_M, LETRA_N, LETRA_O, LETRA_P,
        LETRA_Q, LETRA_R, LETRA_S, LETRA_T, LETRA_U, LETRA_V, LETRA_W, LETRA_X, LETRA_Y, LETRA_Z, LETRA_Ñ, LETRA_TILDADA_A, LETRA_TILDADA_E, LETRA_TILDADA_I, 
        LETRA_TILDADA_O, LETRA_TILDADA_U, LETRA_DIERISIS_U, Digito_0, Digito_1, Digito_2, Digito_3, Digito_4, Digito_5, Digito_6, Digito_7, Digito_8, Digito_9, 
        Coma, Punto_y_coma, Punto, Dos_puntos, Parentesis_abre, Parentesis_cierra, Corchetes_abre, Corchetes_cierra, Llaves_abre, Llaves_cierra, Numeral, Signo_peso,
        SIGNO_AMPERSAN, SIGNO_ARROBA, SIGNO_MÁS, SIGNO_MENOS, SIGNO_MULTIPLICACION, SIGNO_DIVISION, PORCENTAJE, SIGNO_IGUAL, BARRA_INVERSA, PALO, COMILLA, 
        ACENTO_CIRCUNFLEJO, EXCLAMACION_ABRE, EXCLAMACION_CIERRA, SIGNO_DE_PREGUNTA_ABRE, SIGNO_DE_PREGUNTA_CIERRA, GUION_BAJO, MAYOR_QUE, MENOR_QUE, 
        SUPERINDICE_A, SUPERINDICE_0, VERGULILLA, COMILLA_ABRE, COMILLA_CIERRA, ESPACIO, COMILLA_SIMPLE, FIN_ARCHIVO, FIN_LINEA
    }
}
