using Examen_Parcial_Compiladores.Cache;
using Examen_Parcial_Compiladores.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.AnalizadorLexico
{
    internal class AnalizadorLexicoPunto
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

        public AnalizadorLexicoPunto()
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
                else if ("q996".Equals(estadoActual)) { ProcesarEstado996(); }
                else if ("q995".Equals(estadoActual)) { ProcesarEstado995(); }
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
                else if ("q997".Equals(estadoActual)) { ProcesarEstado997(); }
                else if ("q998".Equals(estadoActual)) { ProcesarEstado998(); }
                else if ("q999".Equals(estadoActual)) { ProcesarEstado999(); }
                else if ("q91".Equals(estadoActual)) { ProcesarEstado91(); }
                else if ("q92".Equals(estadoActual)) { ProcesarEstado92(); }
                else if ("q93".Equals(estadoActual)) { ProcesarEstado93(); }
                else if ("q94".Equals(estadoActual)) { ProcesarEstado94(); }
                else if ("q95".Equals(estadoActual)) { ProcesarEstado95(); }
                else if ("q96".Equals(estadoActual)) { ProcesarEstado96(); }
                else if ("q97".Equals(estadoActual)) { ProcesarEstado97(); }
                else if ("q98".Equals(estadoActual)) { ProcesarEstado98(); }
                else if ("q99".Equals(estadoActual)) { ProcesarEstado99(); }
                else if ("q100".Equals(estadoActual)) { ProcesarEstado100(); }
                else if ("q101".Equals(estadoActual)) { ProcesarEstado101(); }
                else if ("q102".Equals(estadoActual)) { ProcesarEstado102(); }
                else if ("q103".Equals(estadoActual)) { ProcesarEstado103(); }
                else if ("q104".Equals(estadoActual)) { ProcesarEstado104(); }
                else if ("q105".Equals(estadoActual)) { ProcesarEstado105(); }
                else if ("q106".Equals(estadoActual)) { ProcesarEstado106(); }
                else if ("q107".Equals(estadoActual)) { ProcesarEstado107(); }
                else if ("q108".Equals(estadoActual)) { ProcesarEstado108(); }
                else if ("q109".Equals(estadoActual)) { ProcesarEstado109(); }
                else if ("q110".Equals(estadoActual)) { ProcesarEstado110(); }
                else if ("q111".Equals(estadoActual)) { ProcesarEstado111(); }
                else if ("q112".Equals(estadoActual)) { ProcesarEstado112(); }
                else if ("q113".Equals(estadoActual)) { ProcesarEstado113(); }
                else if ("q114".Equals(estadoActual)) { ProcesarEstado114(); }
                else if ("q115".Equals(estadoActual)) { ProcesarEstado115(); }
                else if ("q116".Equals(estadoActual)) { ProcesarEstado116(); }
                else if ("q117".Equals(estadoActual)) { ProcesarEstado117(); }
                else if ("q118".Equals(estadoActual)) { ProcesarEstado118(); }
                else if ("q119".Equals(estadoActual)) { ProcesarEstado119(); }
                else if ("q120".Equals(estadoActual)) { ProcesarEstado120(); }
                else if ("q121".Equals(estadoActual)) { ProcesarEstado121(); }
                else if ("q122".Equals(estadoActual)) { ProcesarEstado122(); }
                else if ("q123".Equals(estadoActual)) { ProcesarEstado123(); }
                else if ("q124".Equals(estadoActual)) { ProcesarEstado124(); }
                else if ("q125".Equals(estadoActual)) { ProcesarEstado125(); }
                else if ("q126".Equals(estadoActual)) { ProcesarEstado126(); }
                else if ("q127".Equals(estadoActual)) { ProcesarEstado127(); }
                else if ("q128".Equals(estadoActual)) { ProcesarEstado128(); }
                else if ("q129".Equals(estadoActual)) { ProcesarEstado129(); }
                else if ("q130".Equals(estadoActual)) { ProcesarEstado130(); }
                else if ("q131".Equals(estadoActual)) { ProcesarEstado131(); }
                else if ("q132".Equals(estadoActual)) { ProcesarEstado132(); }
                else if ("q133".Equals(estadoActual)) { ProcesarEstado133(); }
                else if ("q134".Equals(estadoActual)) { ProcesarEstado134(); }
                else if ("q135".Equals(estadoActual)) { ProcesarEstado135(); }
                else if ("q136".Equals(estadoActual)) { ProcesarEstado136(); }
                else if ("q137".Equals(estadoActual)) { ProcesarEstado137(); }
                else if ("q138".Equals(estadoActual)) { ProcesarEstado138(); }
                else if ("q139".Equals(estadoActual)) { ProcesarEstado139(); }
                else if ("q140".Equals(estadoActual)) { ProcesarEstado140(); }
                else if ("q141".Equals(estadoActual)) { ProcesarEstado141(); }
                else if ("q142".Equals(estadoActual)) { ProcesarEstado142(); }
                else if ("q143".Equals(estadoActual)) { ProcesarEstado143(); }
                else if ("q144".Equals(estadoActual)) { ProcesarEstado144(); }
                else if ("q145".Equals(estadoActual)) { ProcesarEstado145(); }
                else if ("q146".Equals(estadoActual)) { ProcesarEstado146(); }
                else if ("q147".Equals(estadoActual)) { ProcesarEstado147(); }
                else if ("q148".Equals(estadoActual)) { ProcesarEstado148(); }
                else if ("q149".Equals(estadoActual)) { ProcesarEstado149(); }
                else if ("q150".Equals(estadoActual)) { ProcesarEstado150(); }
                else if ("q151".Equals(estadoActual)) { ProcesarEstado151(); }
                else if ("q152".Equals(estadoActual)) { ProcesarEstado152(); }
                else if ("q153".Equals(estadoActual)) { ProcesarEstado153(); }
                else if ("q154".Equals(estadoActual)) { ProcesarEstado154(); }
                else if ("q155".Equals(estadoActual)) { ProcesarEstado155(); }
                else if ("q156".Equals(estadoActual)) { ProcesarEstado156(); }
                else if ("q157".Equals(estadoActual)) { ProcesarEstado157(); }
                else if ("q158".Equals(estadoActual)) { ProcesarEstado158(); }
                else if ("q159".Equals(estadoActual)) { ProcesarEstado159(); }
                else if ("q160".Equals(estadoActual)) { ProcesarEstado160(); }
                else if ("q161".Equals(estadoActual)) { ProcesarEstado161(); }
                else if ("q162".Equals(estadoActual)) { ProcesarEstado162(); }
                else if ("q163".Equals(estadoActual)) { ProcesarEstado163(); }
                else if ("q164".Equals(estadoActual)) { ProcesarEstado164(); }
                else if ("q165".Equals(estadoActual)) { ProcesarEstado165(); }
                else if ("q166".Equals(estadoActual)) { ProcesarEstado166(); }
                else if ("q167".Equals(estadoActual)) { ProcesarEstado167(); }
                else if ("q168".Equals(estadoActual)) { ProcesarEstado168(); }
                else if ("q169".Equals(estadoActual)) { ProcesarEstado169(); }
                else if ("q170".Equals(estadoActual)) { ProcesarEstado170(); }
                else if ("q171".Equals(estadoActual)) { ProcesarEstado171(); }
                else if ("q172".Equals(estadoActual)) { ProcesarEstado172(); }
                else if ("q173".Equals(estadoActual)) { ProcesarEstado173(); }
                else if ("q174".Equals(estadoActual)) { ProcesarEstado174(); }
                else if ("q175".Equals(estadoActual)) { ProcesarEstado175(); }
                else if ("q176".Equals(estadoActual)) { ProcesarEstado176(); }
                else if ("q177".Equals(estadoActual)) { ProcesarEstado177(); }
                else if ("q178".Equals(estadoActual)) { ProcesarEstado178(); }
                else if ("q179".Equals(estadoActual)) { ProcesarEstado179(); }
                else if ("q180".Equals(estadoActual)) { ProcesarEstado180(); }
                
                else { ProcesarEstado82(); }


            }
            return resultado;
        }
        private void ProcesarEstado998()
        {
            categoria = "FIN ARCHIVO";
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado997()
        {
            CargarNuevaLinea();
            Resetear();
        }


        private void ProcesarEstado999()
        {
            throw new Exception("Caracter no reconocido por el sistema");
        }

        private void ProcesarEstado996()
        {
            if(" ".Equals(caracterActual)) { estadoActual = "q995"; }
            else
            {
                throw new Exception("Separacion entre caracteres invalida");
            }
        }

        private void ProcesarEstado995()
        {
            LeerSiguienteCaracter();
            if (" ".Equals(caracterActual)) { throw new Exception("Separacion entre caracteres invalida"); }
            else
            {
                DevolverPuntero();
                estadoActual = "q0";
            }
        }

        private void ProcesarEstado0()
        {
            LeerSiguienteCaracter();
            if (".".Equals(caracterActual)) { estadoActual = "q1"; }
            else if (UtilTexto.EsFinLinea(caracterActual)) { estadoActual = "q997"; }
            else if (UtilTexto.EsFinArchivo(caracterActual)) { estadoActual = "q998"; }
            else if (" ".Equals(caracterActual)) { estadoActual = "q996"; }
            else { estadoActual = "q999"; }

        }
        private void ProcesarEstado1()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q2"; }
            else if (caracterActual.Equals(" ")) { estadoActual = "q10"; }

            else
            {
                estadoActual = "q999";
            }
        }
        private void ProcesarEstado2()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q3"; }
            else if (caracterActual.Equals(" ")) { estadoActual = "q29"; }
            else
            {
                estadoActual = "q999";
            }
        }
        private void ProcesarEstado3()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q4"; }
            else if (caracterActual.Equals(" ")) { estadoActual = "q48"; }
            else
            {
                estadoActual = "q999";
            }
        }
        private void ProcesarEstado4()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q5"; }
            else if (caracterActual.Equals(" ")) { estadoActual = "q67"; }
            else
            {
                estadoActual = "q999";
            }
        }
        private void ProcesarEstado5()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q6"; }
            else if (caracterActual.Equals(" ")) { estadoActual = "q86"; }
            else
            {
                estadoActual = "q999";
            }
        }
        private void ProcesarEstado6()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q7"; }
            else if (caracterActual.Equals(" ")) { estadoActual = "q105"; }
            else
            {
                estadoActual = "q999";
            }
        }
        private void ProcesarEstado7()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q8"; }
            else if (caracterActual.Equals(" ")) { estadoActual = "q124"; }
            else
            {
                estadoActual = "q999";
            }
        }
        private void ProcesarEstado8()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q9"; }
            else if (caracterActual.Equals(" ")) { estadoActual = "q143"; }
            else
            {
                estadoActual = "q999";
            }
        }
        private void ProcesarEstado9()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(" ")) { estadoActual = "q162"; }
            else
            {
                estadoActual = "q999";
            }
        }
        private void ProcesarEstado10()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q11"; }
            //else if(caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q"; }
            else
            {
                estadoActual = "q999";
            }
        }
        private void ProcesarEstado11()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q12"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q20"; }
            else
            {
                estadoActual = "q999";
            }
        }
        private void ProcesarEstado12()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q13"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q21"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado13()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q14"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@") || caracterActual.Equals("@EOF@")) { estadoActual = "q22"; }
            else
            {
                estadoActual = "q999";
            };

        }
        private void ProcesarEstado14()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q15"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q23"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado15()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q16"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q24"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado16()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q17"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q25"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado17()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q18"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q26"; }
            else
            {
                estadoActual = "q999";
            }


        }
        private void ProcesarEstado18()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q19"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q27"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado19()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q28"; }
            else
            {
                estadoActual = "q999";
            }


        }
        private void ProcesarEstado20()
        {
            categoria = "LETRA A";
            //Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado21()
        {
            categoria = "LETRA B";
            //Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado22()
        {
            categoria = "LETRA C";
            //Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado23()
        {
            categoria = "LETRA D";
            //Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado24()
        {
            categoria = "LETRA E";
            //Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado25()
        {
            categoria = "LETRA F";
            //Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado26()
        {
            categoria = "LETRA G";
            //Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado27()
        {
            categoria = "LETRA H";
            //Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado28()
        {
            categoria = "LETRA I";
            //Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado29()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q30"; }
            // if (caracterActual.Equals(" ")) { estadoActual = "q21"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado30()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q31"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q39"; }
            else
            {
                estadoActual = "q999";
            }
        }
        private void ProcesarEstado31()
        {

            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q32"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q40"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado32()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q33"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q41"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado33()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q34"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q42"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado34()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q35"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q43"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado35()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q36"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q44"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado36()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q37"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q45"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado37()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q38"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q46"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado38()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = ""; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q47"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado39()
        {
            categoria = "LETRA J";
            //();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado40()
        {
            categoria = "LETRA K";
            //Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado41()
        {
            categoria = "LETRA L";
            //Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado42()
        {
            categoria = "LETRA M";
           // Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado43()
        {
            categoria = "LETRA N";
          //  Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado44()
        {
            categoria = "LETRA Ñ";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado45()
        {
            categoria = "LETRA O";
          //  Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado46()
        {
            categoria = "LETRA P";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado47()
        {
            categoria = "LETRA Q";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado48()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q49"; }
            else if (caracterActual.Equals(" ")) { estadoActual = "q58"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado49()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q50"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q58"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado50()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q51"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q59"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado51()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q52"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q60"; }
            else
            {
                estadoActual = "q999";
            }
        }
        
        private void ProcesarEstado52()
        {
        Concatenar();
        LeerSiguienteCaracter();
        if (caracterActual.Equals(".")) { estadoActual = "q53"; }
        else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q61"; }
        else
        {
            estadoActual = "q999";
        }

    }
        private void ProcesarEstado53()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q54"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q62"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado54()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q55"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q63"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado55()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q56"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q64"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado56()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q57"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q65"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado57()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q66"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado58()
        {
            categoria = "LETRA R";
           // Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado59()
        {
            categoria = "LETRA S";
           // Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado60()
        {
            categoria = "LETRA T";
           // Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado61()
        {
            categoria = "LETRA U";
           // Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado62()
        {
            categoria = "LETRA V";
           // Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado63()
        {
            categoria = "LETRA W";
          //  Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado64()
        {
            categoria = "LETRA X";
          //  Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado65()
        {
            categoria = "LETRA Y";
           // Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado66()
        {
            categoria = "LETRA Z";
           // Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado67()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q68"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado68()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q69"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q77"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado69()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q70"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q78"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado70()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q70"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q79"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado71()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q71"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q80"; }
            else
            {
                estadoActual = "q999";
            }
        }
        private void ProcesarEstado72()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q72"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q81"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado73()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q73"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q82"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado74()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q74"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q83"; }
            else
            {
                estadoActual = "q999";
            }

        }
        private void ProcesarEstado75()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q75"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q84"; }
            else
            {
                estadoActual = "q999";
            }


        }
        private void ProcesarEstado76()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q76"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q85"; }
            else
            {
                estadoActual = "q999";
            }


        }
        private void ProcesarEstado77()
        {
            categoria = "LETRA TILDADA A";
          //  Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado78()
        {
            categoria = "LETRA TILDADA E";
        //    Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado79()
        {
            categoria = "LETRA TILDADA I";
        //    Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado80()
        {
            categoria = "LETRA TILDADA O";
         //   Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;

        }
        private void ProcesarEstado81()
        {
            categoria = "LETRA TILDADA U";
         //   Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado82()
        {
            categoria = "LETRA DIERISIS U";
        //    Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado83()
        {
            categoria = "DIGITO 0";
        //    Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado84()
        {
            categoria = "DIGITO 1";
        //    Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }

        private void ProcesarEstado85()
        {
            categoria = "DIGITO 2";
         //   Concatenar();
            //  LeerSiguienteCaracter();
            FormarComponenteLexico();
            continuarAnalisis = false;


        }
        private void ProcesarEstado86()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q87"; }
            else if (caracterActual.Equals(" ")) { estadoActual = "q85"; }
            else
            {
                estadoActual = "q999";
            }


        }
        private void ProcesarEstado87()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q88"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q96"; }
            else
            {
                estadoActual = "q999";
            }


        }
        private void ProcesarEstado88()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q89"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q97"; }
            else
            {
                estadoActual = "q999";
            }


        }
        private void ProcesarEstado89()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q90"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q98"; }
            else
            {
                estadoActual = "q999";
            }


        }
        private void ProcesarEstado90()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q91"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q99"; }
            else
            {
                estadoActual = "q999";
            }


        }
        private void ProcesarEstado91()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q92"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q100"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado92()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q93"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q101"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado93()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q94"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q102"; }
            else
            {
                estadoActual = "q999";
            }

        }

        private void ProcesarEstado94()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q95"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q103"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado95()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q104"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado96()
        {
            categoria = "DIGITO 3";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado97()
        {
            categoria = "DIGITO 4";
          //  Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado98()
        {
            categoria = "DIGITO 5";
        //    Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado99()
        {
            categoria = "DIGITO 6";
        //    Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado100()
        {
            categoria = "DIGITO 7";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado101()
        {
            categoria = "DIGITO 8";
        //    Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado102()
        {
            categoria = "DIGITO 9";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado103()
        {
            categoria = "COMA";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado104()
        {
            categoria = "PUNTO Y COMA";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado105()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q106"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado106()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q107"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q115"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado107()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q108"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q116"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado108()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q109"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q117"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado109()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q110"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q118"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado110()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q111"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q119"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado111()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q112"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q120"; }
            else
            {
                estadoActual = "q999";
            }

        }



        private void ProcesarEstado112()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q113"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q121"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado113()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q114"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q122"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado114()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q123"; }
            else
            {
                estadoActual = "q999";
            }

        }



        private void ProcesarEstado115()
        {
            categoria = "PUNTO";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado116()
        {
            categoria = "DOS PUNTOS";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado117()
        {
            categoria = "PARENTESIS ABRE";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado118()
        {
            categoria = "PARENTESIS CIERRA";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado119()
        {
            categoria = "CORCHETES ABRE";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado120()
        {
            categoria = "CORCHETES CIERRA";
          //  Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado121()
        {
            categoria = "LLAVES ABRE";
          //  Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado122()
        {
            categoria = "LLAVES CIERRA";
          //  Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado123()
        {
            categoria = "NUMERAL";
          //  Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado124()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q125"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado125()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q126"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q134"; }
            else
            {
                estadoActual = "q999";
            }

        }



        private void ProcesarEstado126()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q127"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q135"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado127()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q128"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q136"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado128()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q129"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q137"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado129()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q130"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q138"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado130()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q131"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q139"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado131()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q132"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q140"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado132()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q133"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q141"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado133()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q142"; }
            else
            {
                estadoActual = "q999";
            }

        }



        private void ProcesarEstado134()
        {
            categoria = "SIGNO PESO";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado135()
        {
            categoria = "SIGNO AMPERSAN";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado136()
        {
            categoria = "SIGNO ARROBA";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado137()
        {
            categoria = "SIGNO MAS";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado138()
        {
            categoria = "SIGNO MENOS";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado139()
        {
            categoria = "SIGNO MULTIPLICACION";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado140()
        {
            categoria = "SIGNO DIVISION";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado141()
        {
            categoria = "PORCENTAJE";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado142()
        {
            categoria = "SIGNO IGUAL";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado143()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q144"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado144()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q145"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q153"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado145()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q146"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q154"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado146()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q147"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q155"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado147()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q148"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q156"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado148()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q149"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q157"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado149()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q150"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q158"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado150()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q151"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q159"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado151()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q152"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q160"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado152()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q161"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado153()
        {

            categoria = "BARRA INVERSA";
        //    Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado154()
        {

            categoria = "PALO";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado155()
        {
            categoria = "COMILLA";
        //    Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado156()
        {
            categoria = "COMILLA SIMPLE";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado157()
        {
            categoria = "ACENTO CIRCUNFLEJO";
        //    Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado158()
        {
            categoria = "EXCLAMACION ABRE";
        //    Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado159()
        {
            categoria = "EXCLAMACION CIERRA";
        //    Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado160()
        {
            categoria = "SIGNO DE PREGUNTA ABRE";
        //    Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado161()
        {
            categoria = "SIGNO DE PREGUNTA CIERRA";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado162()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q163"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado163()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q164"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q172"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado164()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q165"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q173"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado165()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q166"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q174"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado166()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q167"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q175"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado167()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q168"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q176"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado168()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q169"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q177"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado169()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q170"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q178"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado170()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(".")) { estadoActual = "q171"; }
            else if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q179"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado171()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (caracterActual.Equals(" ") || caracterActual.Equals("@FL@")) { estadoActual = "q180"; }
            else
            {
                estadoActual = "q999";
            }

        }


        private void ProcesarEstado172()
        {
            categoria = "GUION BAJO";
        //    Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado173()
        {
            categoria = "MAYOR QUE";
        //    Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado174()
        {
            categoria = "MENOR QUE";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }

        private void ProcesarEstado175()
        {
            categoria = "SUPERINDICE A";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado176()
        {
            categoria = "SUPERINDICE O";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado177()
        {
            categoria = "VERGULILLA";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado178()
        {
            categoria = "COMILLA ABRE";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado179()
        {
            categoria = "COMILLA CIERRA";
         //   Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


        private void ProcesarEstado180()
        {
            categoria = "ESPACIO";
        //    Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


    }
}