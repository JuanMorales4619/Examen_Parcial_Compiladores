using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.Traduccion
{
    internal class Texto
    {
        public Texto() { }
        public static string TraducirTextoNumero(string lexema)
        {
            string cadena = "";
            if ("LETRA A".Equals(lexema)) { cadena = "11"; }
            else if ("LETRA B".Equals(lexema)) { cadena = "12"; }
            else if ("LETRA C".Equals(lexema)) { cadena = "13"; }
            else if ("LETRA D".Equals(lexema)) { cadena = "14"; }
            else if ("LETRA E".Equals(lexema)) { cadena = "15"; }
            else if ("LETRA F".Equals(lexema)) { cadena = "16"; }
            else if ("LETRA G".Equals(lexema)) { cadena = "17"; }
            else if ("LETRA H".Equals(lexema)) { cadena = "18"; }
            else if ("LETRA I".Equals(lexema)) { cadena = "19"; }
            else if ("LETRA J".Equals(lexema)) { cadena = "21"; }
            else if ("LETRA K".Equals(lexema)) { cadena = "22"; }
            else if ("LETRA L".Equals(lexema)) { cadena = "23"; }
            else if ("LETRA M".Equals(lexema)) { cadena = "24"; }
            else if ("LETRA N".Equals(lexema)) { cadena = "25"; }
            else if ("LETRA O".Equals(lexema)) { cadena = "27"; }
            else if ("LETRA P".Equals(lexema)) { cadena = "28"; }
            else if ("LETRA Q".Equals(lexema)) { cadena = "29"; }
            else if ("LETRA R".Equals(lexema)) { cadena = "31"; }
            else if ("LETRA S".Equals(lexema)) { cadena = "32"; }
            else if ("LETRA T".Equals(lexema)) { cadena = "33"; }
            else if ("LETRA U".Equals(lexema)) { cadena = "34"; }
            else if ("LETRA V".Equals(lexema)) { cadena = "35"; }
            else if ("LETRA W".Equals(lexema)) { cadena = "36"; }
            else if ("LETRA X".Equals(lexema)) { cadena = "37"; }
            else if ("LETRA Y".Equals(lexema)) { cadena = "38"; }
            else if ("LETRA Z".Equals(lexema)) { cadena = "39"; }
            else if ("LETRA Ñ".Equals(lexema)) { cadena = "26"; }
            else if ("LETRA TILDADA A".Equals(lexema)) { cadena = "41"; }
            else if ("LETRA TILDADA E".Equals(lexema)) { cadena = "42"; }
            else if ("LETRA TILDADA I".Equals(lexema)) { cadena = "43"; }
            else if ("LETRA TILDADA O".Equals(lexema)) { cadena = "44"; }
            else if ("LETRA TILDADA U".Equals(lexema)) { cadena = "45"; }
            else if ("LETRA DIERISIS U".Equals(lexema)) { cadena = "46"; }
            else if ("DIGITO 0".Equals(lexema)) { cadena = "47"; }
            else if ("DIGITO 1".Equals(lexema)) { cadena = "48"; }
            else if ("DIGITO 2".Equals(lexema)) { cadena = "49"; }
            else if ("DIGITO 3".Equals(lexema)) { cadena = "51"; }
            else if ("DIGITO 4".Equals(lexema)) { cadena = "52"; }
            else if ("DIGITO 5".Equals(lexema)) { cadena = "53"; }
            else if ("DIGITO 6".Equals(lexema)) { cadena = "54"; }
            else if ("DIGITO 7".Equals(lexema)) { cadena = "55"; }
            else if ("DIGITO 8".Equals(lexema)) { cadena = "56"; }
            else if ("DIGITO 9".Equals(lexema)) { cadena = "57"; }
            else if ("COMA".Equals(lexema)) { cadena = "58"; }
            else if ("PUNTO Y COMA".Equals(lexema)) { cadena = "59"; }
            else if ("PUNTO".Equals(lexema)) { cadena = "61"; }
            else if ("DOS PUNTOS".Equals(lexema)) { cadena = "62"; }
            else if ("PARENTESIS ABRE".Equals(lexema)) { cadena = "63"; }
            else if ("PARENTESIS CIERRA".Equals(lexema)) { cadena = "64"; }
            else if ("CORCHETE ABRE".Equals(lexema)) { cadena = "65"; }
            else if ("CORCHETE CIERRA".Equals(lexema)) { cadena = "66"; }
            else if ("LLAVE ABRE".Equals(lexema)) { cadena = "67"; }
            else if ("LLAVE CIERRA".Equals(lexema)) { cadena = "68"; }
            else if ("NUMERAL".Equals(lexema)) { cadena = "69"; }
            else if ("SIGNO PESO".Equals(lexema)) { cadena = "71"; }
            else if ("SIGNO AMPERSAN".Equals(lexema)) { cadena = "72"; }
            else if ("SIGNO ARROBA".Equals(lexema)) { cadena = "73"; }
            else if ("SIGNO MÁS".Equals(lexema)) { cadena = "74"; }
            else if ("SIGNO MENOS".Equals(lexema)) { cadena = "75"; }
            else if ("SIGNO MULTIPLICACION".Equals(lexema)) { cadena = "76"; }
            else if ("SIGNO DIVISION".Equals(lexema)) { cadena = "77"; }
            else if ("PORCENTAJE".Equals(lexema)) { cadena = "78"; }
            else if ("SIGNO IGUAL".Equals(lexema)) { cadena = "79"; }
            else if ("BARRA INVERSA".Equals(lexema)) { cadena = "81"; }
            else if ("PALO".Equals(lexema)) { cadena = "82"; }
            else if ("COMILLA".Equals(lexema)) { cadena = "83"; }
            else if ("ACENTO CIRCUNFLEJO".Equals(lexema)) { cadena = "85"; }
            else if ("EXCLAMACION ABRE".Equals(lexema)) { cadena = "86"; }
            else if ("EXCLAMACION CIERRA".Equals(lexema)) { cadena = "87"; }
            else if ("SIGNO DE PREGUNTA ABRE".Equals(lexema)) { cadena = "88"; }
            else if ("SIGNO DE PREGUNTA CIERRA".Equals(lexema)) { cadena = "89"; }
            else if ("GUION BAJO".Equals(lexema)) { cadena = "91"; }
            else if ("MAYOR QUE".Equals(lexema)) { cadena = "92"; }
            else if ("MENOR QUE".Equals(lexema)) { cadena = "93"; }
            else if ("SUPERINDICE A".Equals(lexema)) { cadena = "94"; }
            else if ("SUPERINDICE O".Equals(lexema)) { cadena = "95"; }
            else if ("VERGULILLA".Equals(lexema)) { cadena = "96"; }
            else if ("COMILLA ABRE".Equals(lexema)) { cadena = "97"; }
            else if ("COMILLA CIERRA".Equals(lexema)) { cadena = "98"; }
            else if ("ESPACIO".Equals(lexema)) { cadena = "99"; }
            else if ("COMILLA SIMPLE".Equals(lexema)) { cadena = "84"; }
            else if ("FIN ARCHIVO".Equals(lexema)) { cadena = " "; }
            else if ("FIN LINEA".Equals(lexema)) { cadena = " "; }
            else { throw new Exception("No se reconoce el caracter"); }
            return cadena;
        }

        public static string TraducirTextoPunto(string lexema)
        {
            string cadena = "";
            if ("LETRA A".Equals(lexema)) { cadena = ". ."; }
            else if ("LETRA B".Equals(lexema)) { cadena = ". .."; }
            else if ("LETRA C".Equals(lexema)) { cadena = ". ..."; }
            else if ("LETRA D".Equals(lexema)) { cadena = ". ...."; }
            else if ("LETRA E".Equals(lexema)) { cadena = ". ....."; }
            else if ("LETRA F".Equals(lexema)) { cadena = ". ......"; }
            else if ("LETRA G".Equals(lexema)) { cadena = ". ......."; }
            else if ("LETRA H".Equals(lexema)) { cadena = ". ........"; }
            else if ("LETRA I".Equals(lexema)) { cadena = ". ........."; }
            else if ("LETRA J".Equals(lexema)) { cadena = ".. ."; }
            else if ("LETRA K".Equals(lexema)) { cadena = ".. .."; }
            else if ("LETRA L".Equals(lexema)) { cadena = ".. ..."; }
            else if ("LETRA M".Equals(lexema)) { cadena = ".. ...."; }
            else if ("LETRA N".Equals(lexema)) { cadena = ".. ....."; }
            else if ("LETRA O".Equals(lexema)) { cadena = ".. ......."; }
            else if ("LETRA P".Equals(lexema)) { cadena = ".. ........"; }
            else if ("LETRA Q".Equals(lexema)) { cadena = ".. ........."; }
            else if ("LETRA R".Equals(lexema)) { cadena = "... ."; }
            else if ("LETRA S".Equals(lexema)) { cadena = "... .."; }
            else if ("LETRA T".Equals(lexema)) { cadena = "... ..."; }
            else if ("LETRA U".Equals(lexema)) { cadena = "... ...."; }
            else if ("LETRA V".Equals(lexema)) { cadena = "... ....."; }
            else if ("LETRA W".Equals(lexema)) { cadena = "... ......"; }
            else if ("LETRA X".Equals(lexema)) { cadena = "... ......."; }
            else if ("LETRA Y".Equals(lexema)) { cadena = "... ........"; }
            else if ("LETRA Z".Equals(lexema)) { cadena = "... ........."; }
            else if ("LETRA Ñ".Equals(lexema)) { cadena = ".. ......"; }
            else if ("LETRA TILDADA A".Equals(lexema)) { cadena = ".... ."; }
            else if ("LETRA TILDADA E".Equals(lexema)) { cadena = ".... .."; }
            else if ("LETRA TILDADA I".Equals(lexema)) { cadena = ".... ..."; }
            else if ("LETRA TILDADA O".Equals(lexema)) { cadena = ".... ...."; }
            else if ("LETRA TILDADA U".Equals(lexema)) { cadena = ".... ....."; }
            else if ("LETRA DIERISIS U".Equals(lexema)) { cadena = ".... ......"; }
            else if ("DIGITO 0".Equals(lexema)) { cadena = ".... ......."; }
            else if ("DIGITO 1".Equals(lexema)) { cadena = ".... ........"; }
            else if ("DIGITO 2".Equals(lexema)) { cadena = ".... ........."; }
            else if ("DIGITO 3".Equals(lexema)) { cadena = "..... ."; }
            else if ("DIGITO 4".Equals(lexema)) { cadena = "..... .."; }
            else if ("DIGITO 5".Equals(lexema)) { cadena = "..... ..."; }
            else if ("DIGITO 6".Equals(lexema)) { cadena = "..... ...."; }
            else if ("DIGITO 7".Equals(lexema)) { cadena = "..... ....."; }
            else if ("DIGITO 8".Equals(lexema)) { cadena = "..... ......"; }
            else if ("DIGITO 9".Equals(lexema)) { cadena = "..... ......."; }
            else if ("COMA".Equals(lexema)) { cadena = "..... ........"; }
            else if ("PUNTO Y COMA".Equals(lexema)) { cadena = "..... ........."; }
            else if ("PUNTO".Equals(lexema)) { cadena = "...... ."; }
            else if ("DOS PUNTOS".Equals(lexema)) { cadena = "...... .."; }
            else if ("PARENTESIS ABRE".Equals(lexema)) { cadena = "...... ..."; }
            else if ("PARENTESIS CIERRA".Equals(lexema)) { cadena = "...... ...."; }
            else if ("CORCHETE ABRE".Equals(lexema)) { cadena = "...... ....."; }
            else if ("CORCHETE CIERRA".Equals(lexema)) { cadena = "...... ......"; }
            else if ("LLAVE ABRE".Equals(lexema)) { cadena = "...... ......."; }
            else if ("LLAVE CIERRA".Equals(lexema)) { cadena = "...... ........"; }
            else if ("NUMERAL".Equals(lexema)) { cadena = "...... ........."; }
            else if ("SIGNO PESO".Equals(lexema)) { cadena = "....... ."; }
            else if ("SIGNO AMPERSAN".Equals(lexema)) { cadena = "....... .."; }
            else if ("SIGNO ARROBA".Equals(lexema)) { cadena = "....... ..."; }
            else if ("SIGNO MÁS".Equals(lexema)) { cadena = "....... ...."; }
            else if ("SIGNO MENOS".Equals(lexema)) { cadena = "....... ....."; }
            else if ("SIGNO MULTIPLICACION".Equals(lexema)) { cadena = "....... ......"; }
            else if ("SIGNO DIVISION".Equals(lexema)) { cadena = "....... ......."; }
            else if ("PORCENTAJE".Equals(lexema)) { cadena = "....... ........"; }
            else if ("SIGNO IGUAL".Equals(lexema)) { cadena = "....... ........."; }
            else if ("BARRA INVERSA".Equals(lexema)) { cadena = "........ ."; }
            else if ("PALO".Equals(lexema)) { cadena = "........ .."; }
            else if ("COMILLA".Equals(lexema)) { cadena = "........ ..."; }
            else if ("ACENTO CIRCUNFLEJO".Equals(lexema)) { cadena = "........ ....."; }
            else if ("EXCLAMACION ABRE".Equals(lexema)) { cadena = "........ ......"; }
            else if ("EXCLAMACION CIERRA".Equals(lexema)) { cadena = "........ ......."; }
            else if ("SIGNO DE PREGUNTA ABRE".Equals(lexema)) { cadena = "........ ........"; }
            else if ("SIGNO DE PREGUNTA CIERRA".Equals(lexema)) { cadena = "........ ........."; }
            else if ("GUION BAJO".Equals(lexema)) { cadena = "......... ."; }
            else if ("MAYOR QUE".Equals(lexema)) { cadena = "......... .."; }
            else if ("MENOR QUE".Equals(lexema)) { cadena = "......... ..."; }
            else if ("SUPERINDICE A".Equals(lexema)) { cadena = "......... ...."; }
            else if ("SUPERINDICE O".Equals(lexema)) { cadena = "......... ....."; }
            else if ("VERGULILLA".Equals(lexema)) { cadena = "......... ......"; }
            else if ("COMILLA ABRE".Equals(lexema)) { cadena = "......... ......."; }
            else if ("COMILLA CIERRA".Equals(lexema)) { cadena = "......... ........"; }
            else if ("ESPACIO".Equals(lexema)) { cadena = "......... ........."; }
            else if ("COMILLA SIMPLE".Equals(lexema)) { cadena = "........ ...."; }
            else if ("FIN ARCHIVO".Equals(lexema)) { cadena = " "; }
            else if ("FIN LINEA".Equals(lexema)) { cadena = " "; }
            else { throw new Exception("No se reconoce el caracter"); }
            return cadena;
        }

    }
}