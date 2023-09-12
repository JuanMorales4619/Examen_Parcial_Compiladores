using Examen_Parcial_Compiladores.Cache;
using Examen_Parcial_Compiladores.Util;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.AnalizadorLexico
{
    internal class AnalizadorTextoNumero
    {
        private int numeroLineaActual = 0;
        private string contenidoLineaActual = "";
        private int puntero = 0;
        private string caracterActual = "";
        private string lexema = "";
        private string categoria = "";
        private string estadoActual = "";
        private int posicionInicial = 0;
        private int posicionFinal = 0;
        private bool continuarAnalisis = false;

        public AnalizadorTextoNumero()
        {
            CargarNuevaLinea();
        }

        private void CargarNuevaLinea()
        {
            if (!"@EOF@".Equals(contenidoLineaActual))
            {
                numeroLineaActual += 1;
                contenidoLineaActual = DataCache.ObtenerLinea(numeroLineaActual).Contenido;
                numeroLineaActual = DataCache.ObtenerLinea(numeroLineaActual).NumeroLinea;
                puntero = 1;
            }

        }
        private void LeerSiguienteCaracter()
        {
            if ("@EOF@".Equals(contenidoLineaActual))
            {
                caracterActual = "@EOF@";
            }
            else if (puntero > contenidoLineaActual.Length)
            {
                caracterActual = "@FL@";
            }
            else
            {
                caracterActual = contenidoLineaActual.Substring(puntero - 1, 1);
                puntero += 1;
            }
        }
        private void DevolverPuntero()
        {
            if (!"@FL@".Equals(caracterActual))
            {
                puntero = puntero - 1;
            }
        }
        private void Concatenar()
        {
            lexema = lexema + caracterActual;
        }
        private void Resetear()
        {
            estadoActual = "q0";
            lexema = "";
            categoria = "";
            posicionInicial = 0;
            posicionFinal = 0;
            caracterActual = "";
            continuarAnalisis = true;
        }
        private void FormarComponenteLexico()
        {
            posicionInicial = puntero - lexema.Length;
            posicionFinal = puntero - 1;
            Console.WriteLine("Categoria : " + categoria);
            Console.WriteLine("Lexema: " + lexema);
            Console.WriteLine("Numeor linea: " + numeroLineaActual);
            Console.WriteLine("Posicion inicial: " + posicionInicial);
            Console.WriteLine("posicion final: " + posicionFinal);
        }

        public string DevolverSiguienteComponente()
        {
            Resetear();
            while (continuarAnalisis)
            {
                if("q0".Equals(estadoActual)) { ProcesarEstado0(); }
                else if("q1".Equals(estadoActual)) { ProcesarEstado1();}
                else if ("q2".Equals(estadoActual)) { ProcesarEstado2(); }
                else if ("q3".Equals(estadoActual)) { ProcesarEstado3(); }
                else if ("q4".Equals(estadoActual)) { ProcesarEstado4(); }
                else if ("q5".Equals(estadoActual)) { ProcesarEstado5(); }
                else if ("q6".Equals(estadoActual)) { ProcesarEstado6(); }
                else if ("q7".Equals(estadoActual)) { ProcesarEstado7(); }
                else if ("q8".Equals(estadoActual)) { ProcesarEstado8(); }
                else if ("q9".Equals(estadoActual)) { ProcesarEstado9(); }
                else if ("q10".Equals(estadoActual)) { ProcesarEstado10(); }
                else if ("q11".Equals(estadoActual)) { ProcesarEstado11(); }
                else if ("q12".Equals(estadoActual)) { ProcesarEstado12(); }
                else if ("q13".Equals(estadoActual)) { ProcesarEstado13(); }
                else if ("q14".Equals(estadoActual)) { ProcesarEstado14(); }
                else if ("q15".Equals(estadoActual)) { ProcesarEstado15(); }
                else if ("q16".Equals(estadoActual)) { ProcesarEstado16(); }
                else if ("q17".Equals(estadoActual)) { ProcesarEstado17(); }
                else if ("q18".Equals(estadoActual)) { ProcesarEstado18(); }
                else if ("q19".Equals(estadoActual)) { ProcesarEstado19(); }
                else if ("q20".Equals(estadoActual)) { ProcesarEstado20(); }
                else if ("q21".Equals(estadoActual)) { ProcesarEstado21(); }
                else if ("q22".Equals(estadoActual)) { ProcesarEstado22(); }
                else if ("q23".Equals(estadoActual)) { ProcesarEstado23(); }
                else if ("q24".Equals(estadoActual)) { ProcesarEstado24(); }
                else if ("q25".Equals(estadoActual)) { ProcesarEstado25(); }
                else if ("q26".Equals(estadoActual)) { ProcesarEstado26(); }
                else if ("q27".Equals(estadoActual)) { ProcesarEstado27(); }
                else if ("q28".Equals(estadoActual)) { ProcesarEstado28(); }
                else if ("q29".Equals(estadoActual)) { ProcesarEstado29(); }
                else if ("q30".Equals(estadoActual)) { ProcesarEstado30(); }
                else if ("q31".Equals(estadoActual)) { ProcesarEstado31(); }
                else if ("q32".Equals(estadoActual)) { ProcesarEstado32(); }
                else if ("q33".Equals(estadoActual)) { ProcesarEstado33(); }
                else if ("q34".Equals(estadoActual)) { ProcesarEstado34(); }
                else if ("q35".Equals(estadoActual)) { ProcesarEstado35(); }
                else if ("q36".Equals(estadoActual)) { ProcesarEstado36(); }
                else if ("q37".Equals(estadoActual)) { ProcesarEstado37(); }
                else if ("q38".Equals(estadoActual)) { ProcesarEstado38(); }
                else if ("q39".Equals(estadoActual)) { ProcesarEstado39(); }
                else if ("q40".Equals(estadoActual)) { ProcesarEstado40(); }
                else if ("q41".Equals(estadoActual)) { ProcesarEstado41(); }
                else if ("q42".Equals(estadoActual)) { ProcesarEstado42(); }
                else if ("q43".Equals(estadoActual)) { ProcesarEstado43(); }
                else if ("q44".Equals(estadoActual)) { ProcesarEstado44(); }
                else if ("q45".Equals(estadoActual)) { ProcesarEstado45(); }
                else if ("q46".Equals(estadoActual)) { ProcesarEstado46(); }
                else if ("q47".Equals(estadoActual)) { ProcesarEstado47(); }
                else if ("q48".Equals(estadoActual)) { ProcesarEstado48(); }
                else if ("q49".Equals(estadoActual)) { ProcesarEstado49(); }
                else if ("q50".Equals(estadoActual)) { ProcesarEstado50(); }
                else if ("q51".Equals(estadoActual)) { ProcesarEstado51(); }
                else if ("q52".Equals(estadoActual)) { ProcesarEstado52(); }
                else if ("q53".Equals(estadoActual)) { ProcesarEstado53(); }
                else if ("q54".Equals(estadoActual)) { ProcesarEstado54(); }
                else if ("q55".Equals(estadoActual)) { ProcesarEstado55(); }
                else if ("q56".Equals(estadoActual)) { ProcesarEstado56(); }
                else if ("q57".Equals(estadoActual)) { ProcesarEstado57(); }
                else if ("q58".Equals(estadoActual)) { ProcesarEstado58(); }
                else if ("q59".Equals(estadoActual)) { ProcesarEstado59(); }
                else if ("q60".Equals(estadoActual)) { ProcesarEstado60(); }
                else if ("q61".Equals(estadoActual)) { ProcesarEstado61(); }
                else if ("q62".Equals(estadoActual)) { ProcesarEstado62(); }
                else if ("q63".Equals(estadoActual)) { ProcesarEstado63(); }
                else if ("q64".Equals(estadoActual)) { ProcesarEstado64(); }
                else if ("q65".Equals(estadoActual)) { ProcesarEstado65(); }
                else if ("q66".Equals(estadoActual)) { ProcesarEstado66(); }
                else if ("q67".Equals(estadoActual)) { ProcesarEstado67(); }
                else if ("q68".Equals(estadoActual)) { ProcesarEstado68(); }
                else if ("q69".Equals(estadoActual)) { ProcesarEstado69(); }
                else if ("q70".Equals(estadoActual)) { ProcesarEstado70(); }
                else if ("q71".Equals(estadoActual)) { ProcesarEstado71(); }
                else if ("q72".Equals(estadoActual)) { ProcesarEstado72(); }
                else if ("q73".Equals(estadoActual)) { ProcesarEstado73(); }
                else if ("q74".Equals(estadoActual)) { ProcesarEstado74(); }
                else if ("q75".Equals(estadoActual)) { ProcesarEstado75(); }
                else if ("q76".Equals(estadoActual)) { ProcesarEstado76(); }
                else if ("q77".Equals(estadoActual)) { ProcesarEstado77(); }
                else if ("q78".Equals(estadoActual)) { ProcesarEstado78(); }
                else if ("q79".Equals(estadoActual)) { ProcesarEstado79(); }
                else if ("q80".Equals(estadoActual)) { ProcesarEstado80(); }
                else if ("q81".Equals(estadoActual)) { ProcesarEstado81(); }
                else if ("q82".Equals(estadoActual)) { ProcesarEstado82(); }
                else if ("q83".Equals(estadoActual)) { ProcesarEstado83(); }
                else if ("q84".Equals(estadoActual)) { ProcesarEstado84(); }
                else { ProcesarEstado82(); }


            }
            return categoria;
        }
        private void ProcesarEstado0()
        {
            LeerSiguienteCaracter();
            if ("a".Equals(caracterActual) || "A".Equals(caracterActual)){ estadoActual = "q1"; }
            else if ("b".Equals(caracterActual)|| "B".Equals(caracterActual)) { estadoActual = "q2"; }
            else if ("C".Equals(caracterActual) || "c".Equals(caracterActual)) { estadoActual = "q3"; }
            else if ("D".Equals(caracterActual) || "d".Equals(caracterActual)) { estadoActual = "q4"; }
            else if ("E".Equals(caracterActual) || "e".Equals(caracterActual)) { estadoActual = "q5"; }
            else if ("F".Equals(caracterActual) || "f".Equals(caracterActual)) { estadoActual = "q6"; }
            else if ("G".Equals(caracterActual) || "g".Equals(caracterActual)) { estadoActual = "q7"; }
            else if ("H".Equals(caracterActual) || "h".Equals(caracterActual)) { estadoActual = "q8"; }
            else if ("I".Equals(caracterActual) || "i".Equals(caracterActual)) { estadoActual = "q9"; }
            else if ("J".Equals(caracterActual) || "j".Equals(caracterActual)) { estadoActual = "q10"; }
            else if ("K".Equals(caracterActual) || "k".Equals(caracterActual)) { estadoActual = "q11"; }
            else if ("L".Equals(caracterActual) || "l".Equals(caracterActual)) { estadoActual = "q12"; }
            else if ("M".Equals(caracterActual) || "m".Equals(caracterActual)) { estadoActual = "q13"; }
            else if ("N".Equals(caracterActual) || "n".Equals(caracterActual)) { estadoActual = "q14"; }
            else if ("O".Equals(caracterActual) || "o".Equals(caracterActual)) { estadoActual = "q15"; }
            else if ("P".Equals(caracterActual) || "p".Equals(caracterActual)) { estadoActual = "q16"; }
            else if ("Q".Equals(caracterActual) || "q".Equals(caracterActual)) { estadoActual = "q17"; }
            else if ("R".Equals(caracterActual) || "r".Equals(caracterActual)) { estadoActual = "q18"; }
            else if ("S".Equals(caracterActual) || "s".Equals(caracterActual)) { estadoActual = "q19"; }
            else if ("T".Equals(caracterActual) || "t".Equals(caracterActual)) { estadoActual = "q20"; }
            else if ("U".Equals(caracterActual) || "u".Equals(caracterActual)) { estadoActual = "q21"; }
            else if ("V".Equals(caracterActual) || "v".Equals(caracterActual)) { estadoActual = "q22"; }
            else if ("W".Equals(caracterActual) || "w".Equals(caracterActual)) { estadoActual = "q23"; }
            else if ("X".Equals(caracterActual) || "x".Equals(caracterActual)) { estadoActual = "q24"; }
            else if ("Y".Equals(caracterActual) || "y".Equals(caracterActual)) { estadoActual = "q25"; }
            else if ("Z".Equals(caracterActual) || "z".Equals(caracterActual)) { estadoActual = "q26"; }
            else if ("Ñ".Equals(caracterActual) || "ñ".Equals(caracterActual)) { estadoActual = "q27"; }
            else if ("Á".Equals(caracterActual) || "á".Equals(caracterActual)) { estadoActual = "q28"; }
            else if ("É".Equals(caracterActual) || "é".Equals(caracterActual)) { estadoActual = "q29"; }
            else if ("Í".Equals(caracterActual) || "í".Equals(caracterActual)) { estadoActual = "q30"; }
            else if ("Ó".Equals(caracterActual) || "ó".Equals(caracterActual)) { estadoActual = "q31"; }
            else if ("Ú".Equals(caracterActual) || "ú".Equals(caracterActual)) { estadoActual = "q32"; }
            else if ("Ü".Equals(caracterActual) || "ü".Equals(caracterActual)) { estadoActual = "q33"; }
            else if ("0".Equals(caracterActual)) { estadoActual = "q34"; }
            else if ("1".Equals(caracterActual)) { estadoActual = "q35"; }
            else if ("2".Equals(caracterActual)) { estadoActual = "q36"; }
            else if ("3".Equals(caracterActual)) { estadoActual = "q37"; }
            else if ("4".Equals(caracterActual)) { estadoActual = "q38"; }
            else if ("5".Equals(caracterActual)) { estadoActual = "q39"; }
            else if ("6".Equals(caracterActual)) { estadoActual = "q40"; }
            else if ("7".Equals(caracterActual)) { estadoActual = "q41"; }
            else if ("8".Equals(caracterActual)) { estadoActual = "q42"; }
            else if ("9".Equals(caracterActual)) { estadoActual = "q43"; }
            else if (",".Equals(caracterActual)) { estadoActual = "q44"; }
            else if (";".Equals(caracterActual)) { estadoActual = "q45"; }
            else if (".".Equals(caracterActual)) { estadoActual = "q46"; }
            else if (":".Equals(caracterActual)) { estadoActual = "q47"; }
            else if ("(".Equals(caracterActual)) { estadoActual = "q48"; }
            else if (")".Equals(caracterActual)) { estadoActual = "q49"; }
            else if ("[".Equals(caracterActual)) { estadoActual = "q50"; }
            else if ("]".Equals(caracterActual)) { estadoActual = "q51"; }
            else if ("{".Equals(caracterActual)) { estadoActual = "q52"; }
            else if ("}".Equals(caracterActual)) { estadoActual = "q53"; }
            else if ("#".Equals(caracterActual)) { estadoActual = "q54"; }
            else if ("$".Equals(caracterActual)) { estadoActual = "q55"; }
            else if ("&".Equals(caracterActual)) { estadoActual = "q56"; }
            else if ("@".Equals(caracterActual)) { estadoActual = "q57"; }
            else if ("+".Equals(caracterActual)) { estadoActual = "q58"; }
            else if ("-".Equals(caracterActual)) { estadoActual = "q59"; }
            else if ("*".Equals(caracterActual)) { estadoActual = "q60"; }
            else if ("/".Equals(caracterActual)) { estadoActual = "q61"; }
            else if ("%".Equals(caracterActual)) { estadoActual = "q62"; }
            else if ("=".Equals(caracterActual)) { estadoActual = "q63"; }
            else if ('\\'.Equals(caracterActual))  { estadoActual = "q64"; }
            else if ("|".Equals(caracterActual)) { estadoActual = "q65"; }
            else if ('"'.Equals(caracterActual))  { estadoActual = "q66"; }
            else if ("^".Equals(caracterActual)) { estadoActual = "q67"; }
            else if ("¡".Equals(caracterActual)) { estadoActual = "q68"; }
            else if ("!".Equals(caracterActual)) { estadoActual = "q69"; }
            else if ("¿".Equals(caracterActual)) { estadoActual = "q70"; }
            else if ("?".Equals(caracterActual)) { estadoActual = "q71"; }
            else if ("_".Equals(caracterActual)) { estadoActual = "q72"; }
            else if (">".Equals(caracterActual)) { estadoActual = "q73"; }
            else if ("<".Equals(caracterActual)) { estadoActual = "q74"; }
            else if ("ª".Equals(caracterActual)) { estadoActual = "q75"; }
            else if ("º".Equals(caracterActual)) { estadoActual = "q76"; }
            else if ("~".Equals(caracterActual)) { estadoActual = "q77"; }
            else if ("«".Equals(caracterActual)) { estadoActual = "q78"; }
            else if ("»".Equals(caracterActual)) { estadoActual = "q79"; }
            else if (" ".Equals(caracterActual)) { estadoActual = "q80"; }
            else if ("'".Equals(caracterActual)) { estadoActual = "q81"; }
            else if (UtilTexto.EsFinLinea(caracterActual)){ estadoActual = "q83"; }
            else if (UtilTexto.EsFinArchivo(caracterActual)) { estadoActual = "q84"; }
            else{ estadoActual = "q82"; }

        }
        private void ProcesarEstado1()
        {
            categoria = "LETRA A";
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado2() {
            categoria = "LETRA B";
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado3() {
            categoria = "LETRA C";
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado4() {
            categoria = "LETRA D";
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado5() {
            categoria = "LETRA E";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado6() {
            categoria = "LETRA F";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado7() {
            categoria = "LETRA G";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado8() {
            categoria = "LETRA H";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado9() {
            categoria = "LETRA I";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado10() {
            categoria = "LETRA J";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado11() {
            categoria = "LETRA K";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado12() {
            categoria = "LETRA L";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado13() {
            categoria = "LETRA M";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado14() {
            categoria = "LETRA N";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado15() {
            categoria = "LETRA O";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado16() {
            categoria = "LETRA P";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado17() {
            categoria = "LETRA Q";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado18() {
            categoria = "LETRA R";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado19() {
            categoria = "LETRA S";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado20() {
            categoria = "LETRA T";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado21() {
            categoria = "LETRA U";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado22() {
            categoria = "LETRA V";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado23()
        {
            categoria = "LETRA W";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado24()
        {
            categoria = "LETRA X";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado25()
        {
            categoria = "LETRA Y";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado26()
        {
            categoria = "LETRA Z";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado27()
        {
            categoria = "LETRA Ñ";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado28()
        {
            categoria = "LETRA TILDADA A";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado29() {
            categoria = "LETRA TILDADA E";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado30()
        {
            categoria = "LETRA TILDADA I";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado31()
        {
            categoria = "LETRA TILDADA O";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado32()
        {
            categoria = "LETRA TILDADA U";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado33()
        {
            categoria = "LETRA DIERISIS U";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado34()
        {
            categoria = "DOGITO 0";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado35()
        {
            categoria = "DIGITO 1";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado36()
        {
            categoria = "DIGITO 2";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado37()
        {
            categoria = "DIGITO 3";
            Concatenar();
           // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado38() {
            categoria = "DIGITO 4";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado39()
        {
            categoria = "DIGITO 5";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado40() {
            categoria = "DIGITO 6";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado41()
        {
            categoria = "DIGITO 7";
            Concatenar();
           // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado42()
        {
            categoria = "DIGITO 8";
            Concatenar();
           // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado43()
        {
            categoria = "DIGITO 9";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado44() {
            categoria = "COMA";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado45() {
            categoria = "PUNTO Y COMA";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado46() {
            categoria = "PUNTO";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado47()
        {
            categoria = "DOS PUNTOS";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado48()
        {
            categoria = "PARENTESIS ABRE";
            Concatenar();
           // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado49()
        {
            categoria = "PARENTESIS CIERRA";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado50()
        {
            categoria = "CORCHETE ABRE";
            Concatenar();
           // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado51()
        {
            categoria = "CORCHETE CIERRA";
            Concatenar();
           // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado52()
        {
            categoria = "LLAVE ABRE";
            Concatenar();
           // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado53()
        {
            categoria = "LLAVE CIERRA";
            Concatenar();
           // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado54()
        {
            categoria = "NUMERAL";
            Concatenar();
           // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado55()
        {
            categoria = "SIGNO PESO";
            Concatenar();
           // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado56()
        {
            categoria = "SIGNO AMPERSAD";
            Concatenar();
          //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado57()
        {
            categoria = "SIGNO ARROBA";
            Concatenar();
           // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado58()
        {
            categoria = "SIGNO MAS";
            Concatenar();
          //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado59()
        {
            categoria = "SIGNO MENOS";
            Concatenar();
          //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado60()
        {
            categoria = "SIGNO MULTIPLICACION";
            Concatenar();
          //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado61()
        {
            categoria = "SIGNO DIVISION";
            Concatenar();
           // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado62()
        {
            categoria = "PORCENTAJE";
            Concatenar();
           // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado63()
        {
            categoria = "SIGNO IGUAL";
            Concatenar();
          //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado64()
        {
            categoria = "BARRA INVERTIDA";
            Concatenar();
         //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado65()
        {
            categoria = "PALO";
            Concatenar();
         //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado66()
        {
            categoria = "COMILLA";
            Concatenar();
         //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado67()
        {
            categoria = "ACENTO CIRCUNFLEJO";
            Concatenar();
         //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado68()
        {
            categoria = "EXCLAMACION ABRE";
            Concatenar();
          //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado69()
        {
            categoria = "EXCLAMACION CIERRA";
            Concatenar();
          //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado70()
        {
            categoria = "SIGNO PREGUNTA ABRE";
            Concatenar();
         //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado71()
        {
            categoria = "SIGNO PREGUNTA CIERRA";
            Concatenar();
         //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado72()
        {
            categoria = "GUION BAJO";
            Concatenar();
          //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado73()
        {
            categoria = "MAYOR QUE";
            Concatenar();
          //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado74()
        {
            categoria = "MENOR QUE";
            Concatenar();
         //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado75()
        {
            categoria = "SUPERINDICE A";
            Concatenar();
         //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado76()
        {
            categoria = "SUPERINDICE O";
            Concatenar();
          //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado77()
        {
            categoria = "VERGULILLA";
            Concatenar();
          //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado78()
        {
            categoria = "COMILLA ABRE";
            Concatenar();
         //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado79()
        {
            categoria = "COMILLA CIERRA";
            Concatenar();
         //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado80()
        {
            categoria = "SIGNO ESPACIO";
            Concatenar();
         //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado81()
        {
            categoria = "COMILLA SIMPLE";
            Concatenar();
         //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado82() {
            throw new Exception("Caracter no reconocido por el sistema");
        }
        private void ProcesarEstado83() 
        {
            CargarNuevaLinea();
            Resetear();
        }
        private void ProcesarEstado84() 
        {
            categoria = "FIN ARCHIVO";
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


    }
}