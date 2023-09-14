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

        /*private void DevorarEspaciosBlanco()
        {
            while ("".Equals(caracterActual.Trim()) || caracterActual.Equals("\t") || caracterActual.Equals(" "))
            {
                LeerSiguienteCaracter();
            }
        }*/

        private void ProcesarEstado99()
        {
            LeerSiguienteCaracter();
            if(" ".Equals(caracterActual))
            {
                throw new Exception("Separacion entre caracteres invalida");
            }
            else
            {
                DevolverPuntero();
                estadoActual = "q0";
            }
        }

        private void ProcesarEstado0()
        {
            LeerSiguienteCaracter();
            //DevorarEspaciosBlanco();
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
        private void ProcesarEstado1()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals("1")) { estadoActual = "q2";}
            else if (caracterActual.Equals("2")){ estadoActual = "q3";}
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
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA A";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado3()
        {
            
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA B";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado4()
        {
            
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA C";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado5()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA D";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado6()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA E";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado7()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA F";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado8()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA G";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado9()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA H";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado10()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA I";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }
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

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA J";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado13()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA K";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado14()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA L";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado15()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA M";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }
        }
        private void ProcesarEstado16()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA N";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado17()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA Ñ";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado18()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA O";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado19()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA P";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado20()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA Q";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

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
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA R";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado23()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA S";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado24()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA T";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado25()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA U";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado26()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA V";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado27()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA W";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado28()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA X";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado29()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA Y";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

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
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA TILDADA A";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado33()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA TILDADA E";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }
            
        }
        private void ProcesarEstado34()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA TILDADA I";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado35()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA TILDADA O";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado36()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA TILDADA U";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado37()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LETRA DIERISIS U";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado38()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "DOGITO 0";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado39()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "DIGITO 1";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado40()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "DIGITO 2";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

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
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "DIGITO 3";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado43()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "DIGITO 4";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado44()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "DIGITO 5";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado45()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "DIGITO 6";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado46()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "DIGITO 7";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado47()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "DIGITO 8";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado48()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "DIGITO 9";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado49()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "COMA";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado50()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "PUNTO Y COMA";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

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

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "PUNTO";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado53()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "DOS PUNTOS";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado54()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "PARENTESIS ABRE";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado55()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "PARENTESIS CIERRA";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado56()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "CORCHETE ABRE";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado57()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "CORCHETE CIERRA";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado58()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LLAVE ABRE";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado59()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "LLAVE CIERRA";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado60()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "NUMERAL";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

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

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "SIGNO PESO";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado63()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "SIGNO AMPERSAD";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado64()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "SIGNO ARROBA";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado65()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "SIGNO MAS";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado66()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "SIGNO MENOS";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado67()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "SIGNO MULTIPLICACION";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado68()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "SIGNO DIVISION";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado69()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "PORCENTAJE";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado70()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "SIGNO IGUAL";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

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

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "BARRA INVERTIDA";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado73()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "PALO";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado74()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "COMILLA";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }
        private void ProcesarEstado75()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "COMILLA SIMPLE";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado76()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "ACENTO CIRCUNFLEJO";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado77()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "EXCLAMACION ABRE";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado78()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "EXCLAMACION CIERRA";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado79()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "SIGNO PREGUNTA ABRE";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado80()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "SIGNO PREGUNTA CIERRA";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

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

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "GUION BAJO";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado86()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "MAYOR QUE";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado87()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "MENOR QUE";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado88()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "SUPERINDICE A";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado89()
        {


            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "SUPERINDICE O";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado90()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "VERGULILLA";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado91()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "COMILLA ABRE";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado92()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "COMILLA CIERRA";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }


        }
        private void ProcesarEstado93()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual) || "@FL@".Equals(caracterActual))
            {
                DevolverPuntero();
                categoria = "ESPACIO BLANCO";
                FormarComponenteLexico();
                continuarAnalisis = false;
            }
            else
            {
                estadoActual = "q82";
            }

        }


    }
}