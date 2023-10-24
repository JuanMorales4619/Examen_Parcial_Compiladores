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
        public Texto() { }

        public string DevolverCaracterTraducido(CategoriaGramatical categoria, int tipo)
        {
            if (tipo.Equals(3) || tipo.Equals(5))
            {
                TraducirATexto(categoria);
            }
            else if (tipo.Equals(2) || tipo.Equals(6)) 
            {
                TraducirANumero(categoria);
            }
            else if (tipo.Equals(1) || tipo.Equals(4))
            {
                TraducirAPunto(categoria);
            }

                return cadena;
        }

        private void TraducirATexto(CategoriaGramatical lexema)
        {

            if (CategoriaGramatical.LETRA_A.Equals(lexema)) { cadena = "A"; }
            else if (CategoriaGramatical.LETRA_B.Equals(lexema)) { cadena = "B"; }
            else if (CategoriaGramatical.LETRA_C.Equals(lexema)) { cadena = "C"; }
            else if (CategoriaGramatical.LETRA_D.Equals(lexema)) { cadena = "D"; }
            else if (CategoriaGramatical.LETRA_E.Equals(lexema)) { cadena = "E"; }
            else if (CategoriaGramatical.LETRA_F.Equals(lexema)) { cadena = "F"; }
            else if (CategoriaGramatical.LETRA_G.Equals(lexema)) { cadena = "G"; }
            else if (CategoriaGramatical.LETRA_H.Equals(lexema)) { cadena = "H"; }
            else if (CategoriaGramatical.LETRA_I.Equals(lexema)) { cadena = "I"; }
            else if (CategoriaGramatical.LETRA_J.Equals(lexema)) { cadena = "J"; }
            else if (CategoriaGramatical.LETRA_K.Equals(lexema)) { cadena = "K"; }
            else if (CategoriaGramatical.LETRA_L.Equals(lexema)) { cadena = "L"; }
            else if (CategoriaGramatical.LETRA_M.Equals(lexema)) { cadena = "M"; }
            else if (CategoriaGramatical.LETRA_N.Equals(lexema)) { cadena = "N"; }
            else if (CategoriaGramatical.LETRA_O.Equals(lexema)) { cadena = "O"; }
            else if (CategoriaGramatical.LETRA_P.Equals(lexema)) { cadena = "P"; }
            else if (CategoriaGramatical.LETRA_Q.Equals(lexema)) { cadena = "Q"; }
            else if (CategoriaGramatical.LETRA_R.Equals(lexema)) { cadena = "R"; }
            else if (CategoriaGramatical.LETRA_S.Equals(lexema)) { cadena = "S"; }
            else if (CategoriaGramatical.LETRA_T.Equals(lexema)) { cadena = "T"; }
            else if (CategoriaGramatical.LETRA_U.Equals(lexema)) { cadena = "U"; }
            else if (CategoriaGramatical.LETRA_V.Equals(lexema)) { cadena = "V"; }
            else if (CategoriaGramatical.LETRA_W.Equals(lexema)) { cadena = "W"; }
            else if (CategoriaGramatical.LETRA_X.Equals(lexema)) { cadena = "X"; }
            else if (CategoriaGramatical.LETRA_Y.Equals(lexema)) { cadena = "Y"; }
            else if (CategoriaGramatical.LETRA_Z.Equals(lexema)) { cadena = "Z"; }
            else if (CategoriaGramatical.LETRA_Ñ.Equals(lexema)) { cadena = "Ñ"; }
            else if (CategoriaGramatical.LETRA_TILDADA_A.Equals(lexema)) { cadena = "Á"; }
            else if (CategoriaGramatical.LETRA_TILDADA_E.Equals(lexema)) { cadena = "É"; }
            else if (CategoriaGramatical.LETRA_TILDADA_I.Equals(lexema)) { cadena = "Í"; }
            else if (CategoriaGramatical.LETRA_TILDADA_O.Equals(lexema)) { cadena = "Ó"; }
            else if (CategoriaGramatical.LETRA_TILDADA_U.Equals(lexema)) { cadena = "Ú"; }
            else if (CategoriaGramatical.LETRA_DIERISIS_U.Equals(lexema)) { cadena = "Ü"; }
            else if (CategoriaGramatical.Digito_0.Equals(lexema)) { cadena = "0"; }
            else if (CategoriaGramatical.Digito_1.Equals(lexema)) { cadena = "1"; }
            else if (CategoriaGramatical.Digito_2.Equals(lexema)) { cadena = "2"; }
            else if (CategoriaGramatical.Digito_3.Equals(lexema)) { cadena = "3"; }
            else if (CategoriaGramatical.Digito_4.Equals(lexema)) { cadena = "4"; }
            else if (CategoriaGramatical.Digito_5.Equals(lexema)) { cadena = "5"; }
            else if (CategoriaGramatical.Digito_6.Equals(lexema)) { cadena = "6"; }
            else if (CategoriaGramatical.Digito_7.Equals(lexema)) { cadena = "7"; }
            else if (CategoriaGramatical.Digito_8.Equals(lexema)) { cadena = "8"; }
            else if (CategoriaGramatical.Digito_9.Equals(lexema)) { cadena = "9"; }
            else if (CategoriaGramatical.Coma.Equals(lexema)) { cadena = ","; }
            else if (CategoriaGramatical.Punto_y_coma.Equals(lexema)) { cadena = ";"; }
            else if (CategoriaGramatical.Punto.Equals(lexema)) { cadena = "."; }
            else if (CategoriaGramatical.Dos_puntos.Equals(lexema)) { cadena = ":"; }
            else if (CategoriaGramatical.Parentesis_abre.Equals(lexema)) { cadena = "("; }
            else if (CategoriaGramatical.Parentesis_cierra.Equals(lexema)) { cadena = ")"; }
            else if (CategoriaGramatical.Corchetes_abre.Equals(lexema)) { cadena = "["; }
            else if (CategoriaGramatical.Corchetes_cierra.Equals(lexema)) { cadena = "]"; }
            else if (CategoriaGramatical.Llaves_abre.Equals(lexema)) { cadena = "{"; }
            else if (CategoriaGramatical.Llaves_cierra.Equals(lexema)) { cadena = "}"; }
            else if (CategoriaGramatical.Numeral.Equals(lexema)) { cadena = "#"; }
            else if (CategoriaGramatical.Signo_peso.Equals(lexema)) { cadena = "$"; }
            else if (CategoriaGramatical.SIGNO_AMPERSAN.Equals(lexema)) { cadena = "&"; }
            else if (CategoriaGramatical.SIGNO_ARROBA.Equals(lexema)) { cadena = "@"; }
            else if (CategoriaGramatical.SIGNO_MÁS.Equals(lexema)) { cadena = "+"; }
            else if (CategoriaGramatical.SIGNO_MENOS.Equals(lexema)) { cadena = "-"; }
            else if (CategoriaGramatical.SIGNO_MULTIPLICACION.Equals(lexema)) { cadena = "*"; }
            else if (CategoriaGramatical.SIGNO_DIVISION.Equals(lexema)) { cadena = "/"; }
            else if (CategoriaGramatical.PORCENTAJE.Equals(lexema)) { cadena = "%"; }
            else if (CategoriaGramatical.SIGNO_IGUAL.Equals(lexema)) { cadena = "="; }
            else if (CategoriaGramatical.BARRA_INVERSA.Equals(lexema)){cadena = "\\"; }
            else if (CategoriaGramatical.PALO.Equals(lexema)) { cadena = "|"; }
            else if (CategoriaGramatical.COMILLA.Equals(lexema)){cadena = "\""; }
            else if (CategoriaGramatical.ACENTO_CIRCUNFLEJO.Equals(lexema)) { cadena = "^"; }
            else if (CategoriaGramatical.EXCLAMACION_ABRE.Equals(lexema)) { cadena = "¡"; }
            else if (CategoriaGramatical.EXCLAMACION_CIERRA.Equals(lexema)) { cadena = "!"; }
            else if (CategoriaGramatical.SIGNO_DE_PREGUNTA_ABRE.Equals(lexema)) { cadena = "¿"; }
            else if (CategoriaGramatical.SIGNO_DE_PREGUNTA_CIERRA.Equals(lexema)) { cadena = "?"; }
            else if (CategoriaGramatical.GUION_BAJO.Equals(lexema)) { cadena = "_"; }
            else if (CategoriaGramatical.MAYOR_QUE.Equals(lexema)) { cadena = ">"; }
                    else if (CategoriaGramatical.MENOR_QUE.Equals(lexema)) { cadena = "<"; }
                    else if (CategoriaGramatical.SUPERINDICE_A.Equals(lexema)) { cadena = "ª"; }
                    else if (CategoriaGramatical.SUPERINDICE_0.Equals(lexema)) { cadena = "º"; }
                    else if (CategoriaGramatical.VERGULILLA.Equals(lexema)) { cadena = "~"; }
                    else if (CategoriaGramatical.COMILLA_ABRE.Equals(lexema)) { cadena = "«"; }
                    else if (CategoriaGramatical.COMILLA_CIERRA.Equals(lexema)) { cadena = "»"; }
                    else if (CategoriaGramatical.SIGNO_ESPACIO.Equals(lexema)) { cadena = " "; }
                    else if (CategoriaGramatical.COMILLA_SIMPLE.Equals(lexema)) { cadena = "'"; }
            else { throw new Exception("No se reconoce el caracter"); }


        }
        private void TraducirANumero(CategoriaGramatical lexema)
        {
            if (CategoriaGramatical.LETRA_A.Equals(lexema)) { cadena = "11"; }
            else if (CategoriaGramatical.LETRA_B.Equals(lexema)) { cadena = "12"; }
            else if (CategoriaGramatical.LETRA_C.Equals(lexema)) { cadena = "13"; }
            else if (CategoriaGramatical.LETRA_D.Equals(lexema)) { cadena = "14"; }
            else if (CategoriaGramatical.LETRA_E.Equals(lexema)) { cadena = "15"; }
            else if (CategoriaGramatical.LETRA_F.Equals(lexema)) { cadena = "16"; }
            else if (CategoriaGramatical.LETRA_G.Equals(lexema)) { cadena = "17"; }
            else if (CategoriaGramatical.LETRA_H.Equals(lexema)) { cadena = "18"; }
            else if (CategoriaGramatical.LETRA_I.Equals(lexema)) { cadena = "19"; }
            else if (CategoriaGramatical.LETRA_J.Equals(lexema)) { cadena = "21"; }
            else if (CategoriaGramatical.LETRA_K.Equals(lexema)) { cadena = "22"; }
            else if (CategoriaGramatical.LETRA_L.Equals(lexema)) { cadena = "23"; }
            else if (CategoriaGramatical.LETRA_M.Equals(lexema)) { cadena = "24"; }
            else if (CategoriaGramatical.LETRA_N.Equals(lexema)) { cadena = "25"; }
            else if (CategoriaGramatical.LETRA_O.Equals(lexema)) { cadena = "27"; }
            else if (CategoriaGramatical.LETRA_P.Equals(lexema)) { cadena = "28"; }
            else if (CategoriaGramatical.LETRA_Q.Equals(lexema)) { cadena = "29"; }
            else if (CategoriaGramatical.LETRA_R.Equals(lexema)) { cadena = "31"; }
            else if (CategoriaGramatical.LETRA_S.Equals(lexema)) { cadena = "32"; }
            else if (CategoriaGramatical.LETRA_T.Equals(lexema)) { cadena = "33"; }
            else if (CategoriaGramatical.LETRA_U.Equals(lexema)) { cadena = "34"; }
            else if (CategoriaGramatical.LETRA_V.Equals(lexema)) { cadena = "35"; }
            else if (CategoriaGramatical.LETRA_W.Equals(lexema)) { cadena = "36"; }
            else if (CategoriaGramatical.LETRA_X.Equals(lexema)) { cadena = "37"; }
            else if (CategoriaGramatical.LETRA_Y.Equals(lexema)) { cadena = "38"; }
            else if (CategoriaGramatical.LETRA_Z.Equals(lexema)) { cadena = "39"; }
            else if (CategoriaGramatical.LETRA_Ñ.Equals(lexema)) { cadena = "26"; }
            else if (CategoriaGramatical.LETRA_TILDADA_A.Equals(lexema)) { cadena = "41"; }
            else if (CategoriaGramatical.LETRA_TILDADA_E.Equals(lexema)) { cadena = "42"; }
            else if (CategoriaGramatical.LETRA_TILDADA_I.Equals(lexema)) { cadena = "43"; }
            else if (CategoriaGramatical.LETRA_TILDADA_O.Equals(lexema)) { cadena = "44"; }
            else if (CategoriaGramatical.LETRA_TILDADA_U.Equals(lexema)) { cadena = "45"; }
            else if (CategoriaGramatical.LETRA_DIERISIS_U.Equals(lexema)) { cadena = "46"; }
            else if (CategoriaGramatical.Digito_0.Equals(lexema)) { cadena = "47"; }
            else if (CategoriaGramatical.Digito_1.Equals(lexema)) { cadena = "48"; }
            else if (CategoriaGramatical.Digito_2.Equals(lexema)) { cadena = "49"; }
            else if (CategoriaGramatical.Digito_3.Equals(lexema)) { cadena = "51"; }
            else if (CategoriaGramatical.Digito_4.Equals(lexema)) { cadena = "52"; }
            else if (CategoriaGramatical.Digito_5.Equals(lexema)) { cadena = "53"; }
            else if (CategoriaGramatical.Digito_6.Equals(lexema)) { cadena = "54"; }
            else if (CategoriaGramatical.Digito_7.Equals(lexema)) { cadena = "55"; }
            else if (CategoriaGramatical.Digito_8.Equals(lexema)) { cadena = "56"; }
            else if (CategoriaGramatical.Digito_9.Equals(lexema)) { cadena = "57"; }
            else if (CategoriaGramatical.Coma.Equals(lexema)) { cadena = "58"; }
            else if (CategoriaGramatical.Punto_y_coma.Equals(lexema)) { cadena = "59"; }
            else if (CategoriaGramatical.Punto.Equals(lexema)) { cadena = "61"; }
            else if (CategoriaGramatical.Dos_puntos.Equals(lexema)) { cadena = "62"; }
            else if (CategoriaGramatical.Parentesis_abre.Equals(lexema)) { cadena = "63"; }
            else if (CategoriaGramatical.Parentesis_cierra.Equals(lexema)) { cadena = "64"; }
            else if (CategoriaGramatical.Corchetes_abre.Equals(lexema)) { cadena = "65"; }
            else if (CategoriaGramatical.Corchetes_cierra.Equals(lexema)) { cadena = "66"; }
            else if (CategoriaGramatical.Llaves_abre.Equals(lexema)) { cadena = "67"; }
            else if (CategoriaGramatical.Llaves_cierra.Equals(lexema)) { cadena = "68"; }
            else if (CategoriaGramatical.Numeral.Equals(lexema)) { cadena = "69"; }
            else if (CategoriaGramatical.Signo_peso.Equals(lexema)) { cadena = "71"; }
            else if (CategoriaGramatical.SIGNO_AMPERSAN.Equals(lexema)) { cadena = "72"; }
            else if (CategoriaGramatical.SIGNO_ARROBA.Equals(lexema)) { cadena = "73"; }
            else if (CategoriaGramatical.SIGNO_MÁS.Equals(lexema)) { cadena = "74"; }
            else if (CategoriaGramatical.SIGNO_MENOS.Equals(lexema)) { cadena = "75"; }
            else if (CategoriaGramatical.SIGNO_MULTIPLICACION.Equals(lexema)) { cadena = "76"; }
            else if (CategoriaGramatical.SIGNO_DIVISION.Equals(lexema)) { cadena = "77"; }
            else if (CategoriaGramatical.PORCENTAJE.Equals(lexema)) { cadena = "78"; }
            else if (CategoriaGramatical.SIGNO_IGUAL.Equals(lexema)) { cadena = "79"; }
            else if (CategoriaGramatical.BARRA_INVERSA.Equals(lexema)) { cadena = "81"; }
            else if (CategoriaGramatical.PALO.Equals(lexema)) { cadena = "82"; }
            else if (CategoriaGramatical.COMILLA.Equals(lexema)) { cadena = "83"; }
            else if (CategoriaGramatical.ACENTO_CIRCUNFLEJO.Equals(lexema)) { cadena = "85"; }
            else if (CategoriaGramatical.EXCLAMACION_ABRE.Equals(lexema)) { cadena = "86"; }
            else if (CategoriaGramatical.EXCLAMACION_CIERRA.Equals(lexema)) { cadena = "87"; }
            else if (CategoriaGramatical.SIGNO_DE_PREGUNTA_ABRE.Equals(lexema)) { cadena = "88"; }
            else if (CategoriaGramatical.SIGNO_DE_PREGUNTA_CIERRA.Equals(lexema)) { cadena = "89"; }
            else if (CategoriaGramatical.GUION_BAJO.Equals(lexema)) { cadena = "91"; }
            else if (CategoriaGramatical.MAYOR_QUE.Equals(lexema)) { cadena = "92"; }
            else if (CategoriaGramatical.MENOR_QUE.Equals(lexema)) { cadena = "93"; }
            else if (CategoriaGramatical.SUPERINDICE_A.Equals(lexema)) { cadena = "94"; }
            else if (CategoriaGramatical.SUPERINDICE_0.Equals(lexema)) { cadena = "95"; }
            else if (CategoriaGramatical.VERGULILLA.Equals(lexema)) { cadena = "96"; }
            else if (CategoriaGramatical.COMILLA_ABRE.Equals(lexema)) { cadena = "97"; }
            else if (CategoriaGramatical.COMILLA_CIERRA.Equals(lexema)) { cadena = "98"; }
            else if (CategoriaGramatical.SIGNO_ESPACIO.Equals(lexema)) { cadena = "99"; }
            else if (CategoriaGramatical.COMILLA_SIMPLE.Equals(lexema)) { cadena = "84"; }
            else if (CategoriaGramatical.FIN_ARCHIVO.Equals(lexema)) { cadena = " "; }
            else if (CategoriaGramatical.FIN_LINEA.Equals(lexema)) { cadena = " "; }
            else { throw new Exception("No se reconoce el caracter"); }
            cadena = cadena + " ";
        }

        private void TraducirAPunto(CategoriaGramatical lexema)
        {
            if (CategoriaGramatical.LETRA_A.Equals(lexema)) { cadena = ". ."; }
            else if (CategoriaGramatical.LETRA_B.Equals(lexema)) { cadena = ". .."; }
            else if (CategoriaGramatical.LETRA_C.Equals(lexema)) { cadena = ". ..."; }
            else if (CategoriaGramatical.LETRA_D.Equals(lexema)) { cadena = ". ...."; }
            else if (CategoriaGramatical.LETRA_E.Equals(lexema)) { cadena = ". ....."; }
            else if (CategoriaGramatical.LETRA_F.Equals(lexema)) { cadena = ". ......"; }
            else if (CategoriaGramatical.LETRA_G.Equals(lexema)) { cadena = ". ......."; }
            else if (CategoriaGramatical.LETRA_H.Equals(lexema)) { cadena = ". ........"; }
            else if (CategoriaGramatical.LETRA_I.Equals(lexema)) { cadena = ". ........."; }
            else if (CategoriaGramatical.LETRA_J.Equals(lexema)) { cadena = ".. ."; }
            else if (CategoriaGramatical.LETRA_K.Equals(lexema)) { cadena = ".. .."; }
            else if (CategoriaGramatical.LETRA_L.Equals(lexema)) { cadena = ".. ..."; }
            else if (CategoriaGramatical.LETRA_M.Equals(lexema)) { cadena = ".. ...."; }
            else if (CategoriaGramatical.LETRA_N.Equals(lexema)) { cadena = ".. ....."; }
            else if (CategoriaGramatical.LETRA_O.Equals(lexema)) { cadena = ".. ......."; }
            else if (CategoriaGramatical.LETRA_P.Equals(lexema)) { cadena = ".. ........"; }
            else if (CategoriaGramatical.LETRA_Q.Equals(lexema)) { cadena = ".. ........."; }
            else if (CategoriaGramatical.LETRA_R.Equals(lexema)) { cadena = "... ."; }
            else if (CategoriaGramatical.LETRA_S.Equals(lexema)) { cadena = "... .."; }
            else if (CategoriaGramatical.LETRA_T.Equals(lexema)) { cadena = "... ..."; }
            else if (CategoriaGramatical.LETRA_U.Equals(lexema)) { cadena = "... ...."; }
            else if (CategoriaGramatical.LETRA_V.Equals(lexema)) { cadena = "... ....."; }
            else if (CategoriaGramatical.LETRA_W.Equals(lexema)) { cadena = "... ......"; }
            else if (CategoriaGramatical.LETRA_X.Equals(lexema)) { cadena = "... ......."; }
            else if (CategoriaGramatical.LETRA_Y.Equals(lexema)) { cadena = "... ........"; }
            else if (CategoriaGramatical.LETRA_Z.Equals(lexema)) { cadena = "... ........."; }
            else if (CategoriaGramatical.LETRA_Ñ.Equals(lexema)) { cadena = ".. ......"; }
            else if (CategoriaGramatical.LETRA_TILDADA_A.Equals(lexema)) { cadena = ".... ."; }
            else if (CategoriaGramatical.LETRA_TILDADA_E.Equals(lexema)) { cadena = ".... .."; }
            else if (CategoriaGramatical.LETRA_TILDADA_I.Equals(lexema)) { cadena = ".... ..."; }
            else if (CategoriaGramatical.LETRA_TILDADA_O.Equals(lexema)) { cadena = ".... ...."; }
            else if (CategoriaGramatical.LETRA_TILDADA_U.Equals(lexema)) { cadena = ".... ....."; }
            else if (CategoriaGramatical.LETRA_DIERISIS_U.Equals(lexema)) { cadena = ".... ......"; }
            else if (CategoriaGramatical.Digito_0.Equals(lexema)) { cadena = ".... ......."; }
            else if (CategoriaGramatical.Digito_1.Equals(lexema)) { cadena = ".... ........"; }
            else if (CategoriaGramatical.Digito_2.Equals(lexema)) { cadena = ".... ........."; }
            else if (CategoriaGramatical.Digito_3.Equals(lexema)) { cadena = "..... ."; }
            else if (CategoriaGramatical.Digito_4.Equals(lexema)) { cadena = "..... .."; }
            else if (CategoriaGramatical.Digito_5.Equals(lexema)) { cadena = "..... ..."; }
            else if (CategoriaGramatical.Digito_6.Equals(lexema)) { cadena = "..... ...."; }
            else if (CategoriaGramatical.Digito_7.Equals(lexema)) { cadena = "..... ....."; }
            else if (CategoriaGramatical.Digito_8.Equals(lexema)) { cadena = "..... ......"; }
            else if (CategoriaGramatical.Digito_9.Equals(lexema)) { cadena = "..... ......."; }
            else if (CategoriaGramatical.Coma.Equals(lexema)) { cadena = "..... ........"; }
            else if (CategoriaGramatical.Punto_y_coma.Equals(lexema)) { cadena = "..... ........."; }
            else if (CategoriaGramatical.Punto.Equals(lexema)) { cadena = "...... ."; }
            else if (CategoriaGramatical.Dos_puntos.Equals(lexema)) { cadena = "...... .."; }
            else if (CategoriaGramatical.Parentesis_abre.Equals(lexema)) { cadena = "...... ..."; }
            else if (CategoriaGramatical.Parentesis_cierra.Equals(lexema)) { cadena = "...... ...."; }
            else if (CategoriaGramatical.Corchetes_abre.Equals(lexema)) { cadena = "...... ....."; }
            else if (CategoriaGramatical.Corchetes_cierra.Equals(lexema)) { cadena = "...... ......"; }
            else if (CategoriaGramatical.Llaves_abre.Equals(lexema)) { cadena = "...... ......."; }
            else if (CategoriaGramatical.Llaves_cierra.Equals(lexema)) { cadena = "...... ........"; }
            else if (CategoriaGramatical.Numeral.Equals(lexema)) { cadena = "...... ........."; }
            else if (CategoriaGramatical.Signo_peso.Equals(lexema)) { cadena = "....... ."; }
            else if (CategoriaGramatical.SIGNO_AMPERSAN.Equals(lexema)) { cadena = "....... .."; }
            else if (CategoriaGramatical.SIGNO_ARROBA.Equals(lexema)) { cadena = "....... ..."; }
            else if (CategoriaGramatical.SIGNO_MÁS.Equals(lexema)) { cadena = "....... ...."; }
            else if (CategoriaGramatical.SIGNO_MENOS.Equals(lexema)) { cadena = "....... ....."; }
            else if (CategoriaGramatical.SIGNO_MULTIPLICACION.Equals(lexema)) { cadena = "....... ......"; }
            else if (CategoriaGramatical.SIGNO_DIVISION.Equals(lexema)) { cadena = "....... ......."; }
            else if (CategoriaGramatical.PORCENTAJE.Equals(lexema)) { cadena = "....... ........"; }
            else if (CategoriaGramatical.SIGNO_IGUAL.Equals(lexema)) { cadena = "....... ........."; }
            else if (CategoriaGramatical.BARRA_INVERSA.Equals(lexema)) { cadena = "........ ."; }
            else if (CategoriaGramatical.PALO.Equals(lexema)) { cadena = "........ .."; }
            else if (CategoriaGramatical.COMILLA.Equals(lexema)) { cadena = "........ ..."; }
            else if (CategoriaGramatical.ACENTO_CIRCUNFLEJO.Equals(lexema)) { cadena = "........ ....."; }
            else if (CategoriaGramatical.EXCLAMACION_ABRE.Equals(lexema)) { cadena = "........ ......"; }
            else if (CategoriaGramatical.EXCLAMACION_CIERRA.Equals(lexema)) { cadena = "........ ......."; }
            else if (CategoriaGramatical.SIGNO_DE_PREGUNTA_ABRE.Equals(lexema)) { cadena = "........ ........"; }
            else if (CategoriaGramatical.SIGNO_DE_PREGUNTA_CIERRA.Equals(lexema)) { cadena = "........ ........."; }
            else if (CategoriaGramatical.GUION_BAJO.Equals(lexema)) { cadena = "......... ."; }
            else if (CategoriaGramatical.MAYOR_QUE.Equals(lexema)) { cadena = "......... .."; }
            else if (CategoriaGramatical.MENOR_QUE.Equals(lexema)) { cadena = "......... ..."; }
            else if (CategoriaGramatical.SUPERINDICE_A.Equals(lexema)) { cadena = "......... ...."; }
            else if (CategoriaGramatical.SUPERINDICE_0.Equals(lexema)) { cadena = "......... ....."; }
            else if (CategoriaGramatical.VERGULILLA.Equals(lexema)) { cadena = "......... ......"; }
            else if (CategoriaGramatical.COMILLA_ABRE.Equals(lexema)) { cadena = "......... ......."; }
            else if (CategoriaGramatical.COMILLA_CIERRA.Equals(lexema)) { cadena = "......... ........"; }
            else if (CategoriaGramatical.SIGNO_ESPACIO.Equals(lexema)) { cadena = "......... ........."; }
            else if (CategoriaGramatical.COMILLA_SIMPLE.Equals(lexema)) { cadena = "........ ...."; }
            else if (CategoriaGramatical.FIN_ARCHIVO.Equals(lexema)) { cadena = " "; }
            else if (CategoriaGramatical.FIN_LINEA.Equals(lexema)) { cadena = " "; }
            else { throw new Exception("No se reconoce el caracter"); }
            cadena = cadena + "  ";
            
        }

    }
}