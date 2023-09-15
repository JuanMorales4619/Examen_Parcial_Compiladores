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
    internal class AnalizadorLexicoNumero
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
        private string resultado = "";

        public AnalizadorLexicoNumero()
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
            resultado = "";
        }
        private void FormarComponenteLexico()
        {
            posicionInicial = puntero - lexema.Length;
            posicionFinal = puntero - 1;

            resultado = "Categoria : " + categoria + Environment.NewLine + "Lexema: " + lexema + Environment.NewLine + "Numeor linea: " + numeroLineaActual
                + Environment.NewLine + "Posicion inicial: " + posicionInicial + Environment.NewLine + "posicion final: " + posicionFinal;
        }

        public string DevolverSiguienteComponente()
        {
            Resetear();
            while (continuarAnalisis)
            {
                if ("q0".Equals(estadoActual)) { ProcesarEstado0(); }
                else if ("q1".Equals(estadoActual)) { ProcesarEstado1(); }
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
                else if ("q85".Equals(estadoActual)) { ProcesarEstado85(); }
                else if ("q86".Equals(estadoActual)) { ProcesarEstado86(); }
                else if ("q87".Equals(estadoActual)) { ProcesarEstado87(); }
                else if ("q88".Equals(estadoActual)) { ProcesarEstado88(); }
                else if ("q89".Equals(estadoActual)) { ProcesarEstado89(); }
                else if ("q90".Equals(estadoActual)) { ProcesarEstado90(); }
                else if ("q91".Equals(estadoActual)) { ProcesarEstado91(); }
                else if ("q92".Equals(estadoActual)) { ProcesarEstado92(); }
                else if ("q93".Equals(estadoActual)) { ProcesarEstado93(); }
                else if ("q99".Equals(estadoActual)) { ProcesarEstado99(); }
                else { ProcesarEstado82(); }


            }
            return resultado;
        }


        private void ProcesarEstado99()
        {
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual))
            {
                throw new Exception("Separacion entre caracteres invalida");
            }
            else
            {
                if ("1".Equals(caracterActual)) { estadoActual = "q1"; }
                else if ("2".Equals(caracterActual)) { estadoActual = "q11"; }
                else if ("3".Equals(caracterActual)) { estadoActual = "q21"; }
                else if ("4".Equals(caracterActual)) { estadoActual = "q31"; }
                else if ("5".Equals(caracterActual)) { estadoActual = "q41"; }
                else if ("6".Equals(caracterActual)) { estadoActual = "q51"; }
                else if ("7".Equals(caracterActual)) { estadoActual = "q61"; }
                else if ("8".Equals(caracterActual)) { estadoActual = "q71"; }
                else if ("9".Equals(caracterActual)) { estadoActual = "q81"; }
                else if (UtilTexto.EsFinLinea(caracterActual)) { estadoActual = "q83"; }
                else if (UtilTexto.EsFinArchivo(caracterActual)) { estadoActual = "q84"; }
                else { estadoActual = "q82"; }
            }
        }

        private void ProcesarEstado0()
        {
            LeerSiguienteCaracter();
            if ("1".Equals(caracterActual)) { estadoActual = "q1"; }
            else if ("2".Equals(caracterActual)) { estadoActual = "q11"; }
            else if ("3".Equals(caracterActual)) { estadoActual = "q21"; }
            else if ("4".Equals(caracterActual)) { estadoActual = "q31"; }
            else if ("5".Equals(caracterActual)) { estadoActual = "q41"; }
            else if ("6".Equals(caracterActual)) { estadoActual = "q51"; }
            else if ("7".Equals(caracterActual)) { estadoActual = "q61"; }
            else if ("8".Equals(caracterActual)) { estadoActual = "q71"; }
            else if ("9".Equals(caracterActual)) { estadoActual = "q81"; }
            else if (UtilTexto.EsFinLinea(caracterActual)) { estadoActual = "q83"; }
            else if (UtilTexto.EsFinArchivo(caracterActual)) { estadoActual = "q84"; }
            else if(" ".Equals(caracterActual)) { estadoActual = "q99"; }
            else { estadoActual = "q82"; }

        }
        private void ProcesarEstado1()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals("1")) { estadoActual = "q2"; }
            else if (caracterActual.Equals("2")) { estadoActual = "q3"; }
            else if (caracterActual.Equals("3")) { estadoActual = "q4"; }
            else if (caracterActual.Equals("4")) { estadoActual = "q5"; }
            else if (caracterActual.Equals("5")) { estadoActual = "q6"; }
            else if (caracterActual.Equals("6")) { estadoActual = "q7"; }
            else if (caracterActual.Equals("7")) { estadoActual = "q8"; }
            else if (caracterActual.Equals("8")) { estadoActual = "q9"; }
            else if (caracterActual.Equals("9")) { estadoActual = "q10"; }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado2()
        {
            categoria = "LETRA A";
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado3()
        {
            categoria = "LETRA B";
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado4()
        {
            categoria = "LETRA C";
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado5()
        {
            categoria = "LETRA D";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado6()
        {
            categoria = "LETRA E";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado7()
        {
            categoria = "LETRA F";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado8()
        {
            categoria = "LETRA G";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado9()
        {
            categoria = "LETRA H";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado10()
        {
            categoria = "LETRA I";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado11()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals("1")) { estadoActual = "q12"; }
            else if (caracterActual.Equals("2")) { estadoActual = "q13"; }
            else if (caracterActual.Equals("3")) { estadoActual = "q14"; }
            else if (caracterActual.Equals("4")) { estadoActual = "q15"; }
            else if (caracterActual.Equals("5")) { estadoActual = "q16"; }
            else if (caracterActual.Equals("6")) { estadoActual = "q17"; }
            else if (caracterActual.Equals("7")) { estadoActual = "q18"; }
            else if (caracterActual.Equals("8")) { estadoActual = "q19"; }
            else if (caracterActual.Equals("9")) { estadoActual = "q20"; }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado12()
        {
            categoria = "LETRA J";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado13()
        {
            categoria = "LETRA K";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado14()
        {
            categoria = "LETRA L";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado15()
        {
            categoria = "LETRA M";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado16()
        {
            categoria = "LETRA N";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado17()
        {
            categoria = "LETRA Ñ";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado18()
        {
            categoria = "LETRA O";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado19()
        {
            categoria = "LETRA P";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado20()
        {
            categoria = "LETRA Q";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado21()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals("1")) { estadoActual = "q22"; }
            else if (caracterActual.Equals("2")) { estadoActual = "q23"; }
            else if (caracterActual.Equals("3")) { estadoActual = "q24"; }
            else if (caracterActual.Equals("4")) { estadoActual = "q25"; }
            else if (caracterActual.Equals("5")) { estadoActual = "q26"; }
            else if (caracterActual.Equals("6")) { estadoActual = "q27"; }
            else if (caracterActual.Equals("7")) { estadoActual = "q28"; }
            else if (caracterActual.Equals("8")) { estadoActual = "q29"; }
            else if (caracterActual.Equals("9")) { estadoActual = "q30"; }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado22()
        {
            categoria = "LETRA R";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado23()
        {
            categoria = "LETRA S";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado24()
        {
            categoria = "LETRA T";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado25()
        {
            categoria = "LETRA U";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado26()
        {
            categoria = "LETRA V";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado27()
        {
            categoria = "LETRA W";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado28()
        {
            categoria = "LETRA X";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado29()
        {
            categoria = "LETRA Y";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado30()
        {
            categoria = "LETRA Z";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado31()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals("1")) { estadoActual = "q31"; }
            else if (caracterActual.Equals("2")) { estadoActual = "q32"; }
            else if (caracterActual.Equals("3")) { estadoActual = "q33"; }
            else if (caracterActual.Equals("4")) { estadoActual = "q34"; }
            else if (caracterActual.Equals("5")) { estadoActual = "q35"; }
            else if (caracterActual.Equals("6")) { estadoActual = "q36"; }
            else if (caracterActual.Equals("7")) { estadoActual = "q37"; }
            else if (caracterActual.Equals("8")) { estadoActual = "q38"; }
            else if (caracterActual.Equals("9")) { estadoActual = "q39"; }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado32()
        {
            categoria = "LETRA TILDADA A";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado33()
        {
            categoria = "LETRA TILDADA E";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado34()
        {
            categoria = "LETRA TILDADA I";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado35()
        {
            categoria = "LETRA TILDADA O";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado36()
        {
            categoria = "LETRA TILDADA U";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado37()
        {
            categoria = "LETRA DIERISIS U";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado38()
        {
            categoria = "DOGITO 0";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado39()
        {
            categoria = "DIGITO 1";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado40()
        {
            categoria = "DIGITO 2";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado41()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals("1")) { estadoActual = "q42"; }
            else if (caracterActual.Equals("2")) { estadoActual = "q43"; }
            else if (caracterActual.Equals("3")) { estadoActual = "q44"; }
            else if (caracterActual.Equals("4")) { estadoActual = "q45"; }
            else if (caracterActual.Equals("5")) { estadoActual = "q46"; }
            else if (caracterActual.Equals("6")) { estadoActual = "q47"; }
            else if (caracterActual.Equals("7")) { estadoActual = "q48"; }
            else if (caracterActual.Equals("8")) { estadoActual = "q49"; }
            else if (caracterActual.Equals("9")) { estadoActual = "q50"; }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado42()
        {
            categoria = "DIGITO 3";
            Concatenar();
            // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado43()
        {
            categoria = "DIGITO 4";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado44()
        {
            categoria = "DIGITO 5";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado45()
        {
            categoria = "DIGITO 6";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado46()
        {
            categoria = "DIGITO 7";
            Concatenar();
            // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado47()
        {
            categoria = "DIGITO 8";
            Concatenar();
            // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado48()
        {
            categoria = "DIGITO 9";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado49()
        {
            categoria = "COMA";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado50()
        {
            categoria = "PUNTO Y COMA";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado51()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals("1")) { estadoActual = "q45"; }
            else if (caracterActual.Equals("2")) { estadoActual = "q53"; }
            else if (caracterActual.Equals("3")) { estadoActual = "q54"; }
            else if (caracterActual.Equals("4")) { estadoActual = "q55"; }
            else if (caracterActual.Equals("5")) { estadoActual = "q56"; }
            else if (caracterActual.Equals("6")) { estadoActual = "q57"; }
            else if (caracterActual.Equals("7")) { estadoActual = "q58"; }
            else if (caracterActual.Equals("8")) { estadoActual = "q59"; }
            else if (caracterActual.Equals("9")) { estadoActual = "q60"; }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado52()
        {
            categoria = "PUNTO";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado53()
        {
            categoria = "DOS PUNTOS";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado54()
        {
            categoria = "PARENTESIS ABRE";
            Concatenar();
            // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado55()
        {
            categoria = "PARENTESIS CIERRA";
            Concatenar();
            //LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado56()
        {
            categoria = "CORCHETE ABRE";
            Concatenar();
            // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado57()
        {
            categoria = "CORCHETE CIERRA";
            Concatenar();
            // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado58()
        {
            categoria = "LLAVE ABRE";
            Concatenar();
            // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado59()
        {
            categoria = "LLAVE CIERRA";
            Concatenar();
            // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado60()
        {
            categoria = "NUMERAL";
            Concatenar();
            // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado61()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals("1")) { estadoActual = "q62"; }
            else if (caracterActual.Equals("2")) { estadoActual = "q63"; }
            else if (caracterActual.Equals("3")) { estadoActual = "q64"; }
            else if (caracterActual.Equals("4")) { estadoActual = "q65"; }
            else if (caracterActual.Equals("5")) { estadoActual = "q66"; }
            else if (caracterActual.Equals("6")) { estadoActual = "q67"; }
            else if (caracterActual.Equals("7")) { estadoActual = "q68"; }
            else if (caracterActual.Equals("8")) { estadoActual = "q69"; }
            else if (caracterActual.Equals("9")) { estadoActual = "q70"; }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado62()
        {
            categoria = "SIGNO PESO";
            Concatenar();
            // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado63()
        {
            categoria = "SIGNO AMPERSAD";
            Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado64()
        {
            categoria = "SIGNO ARROBA";
            Concatenar();
            // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado65()
        {
            categoria = "SIGNO MAS";
            Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado66()
        {
            categoria = "SIGNO MENOS";
            Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado67()
        {
            categoria = "SIGNO MULTIPLICACION";
            Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado68()
        {
            categoria = "SIGNO DIVISION";
            Concatenar();
            // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado69()
        {
            categoria = "PORCENTAJE";
            Concatenar();
            // LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado70()
        {
            categoria = "SIGNO IGUAL";
            Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado71()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals("1")) { estadoActual = "q72"; }
            else if (caracterActual.Equals("2")) { estadoActual = "q73"; }
            else if (caracterActual.Equals("3")) { estadoActual = "q74"; }
            else if (caracterActual.Equals("4")) { estadoActual = "q75"; }
            else if (caracterActual.Equals("5")) { estadoActual = "q76"; }
            else if (caracterActual.Equals("6")) { estadoActual = "q77"; }
            else if (caracterActual.Equals("7")) { estadoActual = "q78"; }
            else if (caracterActual.Equals("8")) { estadoActual = "q79"; }
            else if (caracterActual.Equals("9")) { estadoActual = "q80"; }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado72()
        {
            categoria = "BARRA INVERTIDA";
            Concatenar();
            //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado73()
        {
            categoria = "PALO";
            Concatenar();
            //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado74()
        {
            categoria = "COMILLA";
            Concatenar();
            //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado75()
        {
            categoria = "COMILLA SIMPLE";
            Concatenar();
            //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado76()
        {
            categoria = "ACENTO CIRCUNFLEJO";
            Concatenar();
            //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado77()
        {
            categoria = "EXCLAMACION ABRE";
            Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado78()
        {
            categoria = "EXCLAMACION CIERRA";
            Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado79()
        {
            categoria = "SIGNO PREGUNTA ABRE";
            Concatenar();
            //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado80()
        {
            categoria = "SIGNO PREGUNTA CIERRA";
            Concatenar();
            //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado81()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals("1")) { estadoActual = "q85"; }
            else if (caracterActual.Equals("2")) { estadoActual = "q86"; }
            else if (caracterActual.Equals("3")) { estadoActual = "q87"; }
            else if (caracterActual.Equals("4")) { estadoActual = "q88"; }
            else if (caracterActual.Equals("5")) { estadoActual = "q89"; }
            else if (caracterActual.Equals("6")) { estadoActual = "q90"; }
            else if (caracterActual.Equals("7")) { estadoActual = "q91"; }
            else if (caracterActual.Equals("8")) { estadoActual = "q92"; }
            else if (caracterActual.Equals("9")) { estadoActual = "q93"; }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado82()
        {
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

        private void ProcesarEstado85()
        {
            categoria = "GUION BAJO";
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado86()
        {
            categoria = "MAYOR QUE";
            Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado87()
        {
            categoria = "MENOR QUE";
            Concatenar();
            //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado88()
        {
            categoria = "SUPERINDICE A";
            Concatenar();
            //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado89()
        {
            categoria = "SUPERINDICE O";
            Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado90()
        {
            categoria = "VERGULILLA";
            Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado91()
        {
            categoria = "COMILLA ABRE";
            Concatenar();
            //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado92()
        {
            categoria = "COMILLA CIERRA";
            Concatenar();
            //   LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado93()
        {
            categoria = "SIGNO ESPACIO";
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }


    }
}