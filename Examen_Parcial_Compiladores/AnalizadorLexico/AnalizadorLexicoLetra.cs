using Examen_Parcial_Compiladores.Cache;
using Examen_Parcial_Compiladores.GestorErrores;
using Examen_Parcial_Compiladores.TablaComponentes;
using Examen_Parcial_Compiladores.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.AnalizadorLexico
{
    internal class AnalizadorLexicoLetra
    {
        private int numeroLineaActual = 0;
        private string contenidoLineaActual = "";
        private int puntero = 0;
        private string caracterActual = "";
        private string lexema = "";
        private CategoriaGramatical categoria;
        private string estadoActual = "";
        private int posicionInicial = 0;
        private bool continuarAnalisis = false;
        private ComponenteLexico componente = null;
        private TipoComponente tipo = TipoComponente.SIMBOLO;
        private string falla = "";
        private string causa = "";
        private string solucion = "";

        public AnalizadorLexicoLetra()
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
            categoria = CategoriaGramatical.DEFECTO;
            posicionInicial = 0;
            caracterActual = "";
            continuarAnalisis = true;
            componente = null;
            tipo = TipoComponente.LITERAL;
        }
        private void FormarComponenteLexico()
        {
            posicionInicial = puntero - lexema.Length;
            componente = ComponenteLexico.CREAR_LITERAL(numeroLineaActual, posicionInicial, lexema, categoria);
        }
        private void ReportarErrorLexicoRecuperable()
        {
            posicionInicial = puntero - lexema.Length;
            Error error = Error.CREAR_ERROR_LEXICO_RECUPERABLE(numeroLineaActual, posicionInicial, lexema, falla, causa, solucion);
            ManejadorErrores.ObtenerManejadorErrores().ReportarError(error);
        }
        private void ReportarErrorLexicoStopper()
        {
            posicionInicial = puntero - lexema.Length;
            Error error = Error.CREAR_ERROR_LEXICO_STOPPER(numeroLineaActual, posicionInicial, lexema, falla, causa, solucion);
            ManejadorErrores.ObtenerManejadorErrores().ReportarError(error);
        }
        

        public ComponenteLexico DevolverSiguienteComponente()
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
            TablaMaestra.ObtenerTablaMaestra().Agregar(componente);
            return componente;
        }
        private void ProcesarEstado0()
        {
            LeerSiguienteCaracter();
            if ("a".Equals(caracterActual) || "A".Equals(caracterActual.ToUpper())){ estadoActual = "q1"; }
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
            else if ("\\".Equals(caracterActual))  { estadoActual = "q64"; }
            else if ("|".Equals(caracterActual)) { estadoActual = "q65"; }
            else if ("\"".Equals(caracterActual))  { estadoActual = "q66"; }
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
            categoria = CategoriaGramatical.LETRA_A;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado2() {
            categoria = CategoriaGramatical.LETRA_B;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado3() {
            categoria = CategoriaGramatical.LETRA_C;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado4() {
            categoria = CategoriaGramatical.LETRA_D;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado5() {
            categoria = CategoriaGramatical.LETRA_E;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado6() {
            categoria = CategoriaGramatical.LETRA_F;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado7() {
            categoria = CategoriaGramatical.LETRA_G;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado8() {
            categoria = CategoriaGramatical.LETRA_H;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado9() {
            categoria = CategoriaGramatical.LETRA_I;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado10() {
            categoria = CategoriaGramatical.LETRA_J;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado11() {
            categoria = CategoriaGramatical.LETRA_K;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado12() {
            categoria = CategoriaGramatical.LETRA_L;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado13() {
            categoria = CategoriaGramatical.LETRA_M;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado14() {
            categoria = CategoriaGramatical.LETRA_N;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado15() {
            categoria = CategoriaGramatical.LETRA_O;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado16() {
            categoria = CategoriaGramatical.LETRA_P;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado17() {
            categoria = CategoriaGramatical.LETRA_Q;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado18() {
            categoria = CategoriaGramatical.LETRA_R;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado19() {
            categoria = CategoriaGramatical.LETRA_S;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado20() {
            categoria = CategoriaGramatical.LETRA_T;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado21() {
            categoria = CategoriaGramatical.LETRA_U;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado22() {
            categoria = CategoriaGramatical.LETRA_V;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado23()
        {
            categoria = CategoriaGramatical.LETRA_W;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado24()
        {
            categoria = CategoriaGramatical.LETRA_X;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado25()
        {
            categoria = CategoriaGramatical.LETRA_Y;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado26()
        {
            categoria = CategoriaGramatical.LETRA_Z;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado27()
        {
            categoria = CategoriaGramatical.LETRA_Ñ;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado28()
        {
            categoria = CategoriaGramatical.LETRA_TILDADA_A;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado29() {
            categoria = CategoriaGramatical.LETRA_TILDADA_E;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado30()
        {
            categoria = CategoriaGramatical.LETRA_TILDADA_I;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado31()
        {
            categoria = CategoriaGramatical.LETRA_TILDADA_O;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado32()
        {
            categoria = CategoriaGramatical.LETRA_TILDADA_U;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado33()
        {
            categoria = CategoriaGramatical.LETRA_DIERISIS_U;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado34()
        {
            categoria = CategoriaGramatical.Digito_0;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado35()
        {
            categoria = CategoriaGramatical.Digito_1;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado36()
        {
            categoria = CategoriaGramatical.Digito_2;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado37()
        {
            categoria = CategoriaGramatical.Digito_3;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado38() {
            categoria = CategoriaGramatical.Digito_4;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado39()
        {
            categoria = CategoriaGramatical.Digito_5;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado40() {
            categoria = CategoriaGramatical.Digito_6;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado41()
        {
            categoria = CategoriaGramatical.Digito_7;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado42()
        {
            categoria = CategoriaGramatical.Digito_8;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado43()
        {
            categoria = CategoriaGramatical.Digito_9;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado44() {
            categoria = CategoriaGramatical.Coma;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado45() {
            categoria = CategoriaGramatical.Punto_y_coma;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado46() {
            categoria = CategoriaGramatical.Punto;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado47()
        {
            categoria = CategoriaGramatical.Dos_puntos;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado48()
        {
            categoria = CategoriaGramatical.Parentesis_abre;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado49()
        {
            categoria = CategoriaGramatical.Parentesis_cierra;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado50()
        {
            categoria = CategoriaGramatical.Corchetes_abre;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado51()
        {
            categoria = CategoriaGramatical.Corchetes_cierra;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado52()
        {
            categoria = CategoriaGramatical.Llaves_abre;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado53()
        {
            categoria = CategoriaGramatical.Llaves_cierra;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado54()
        {
            categoria = CategoriaGramatical.Numeral;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado55()
        {
            categoria = CategoriaGramatical.Signo_peso;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado56()
        {
            categoria = CategoriaGramatical.SIGNO_AMPERSAN;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado57()
        {
            categoria = CategoriaGramatical.SIGNO_ARROBA;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado58()
        {
            categoria = CategoriaGramatical.SIGNO_MÁS;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado59()
        {
            categoria = CategoriaGramatical.SIGNO_MENOS;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado60()
        {
            categoria = CategoriaGramatical.SIGNO_MULTIPLICACION;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado61()
        {
            categoria = CategoriaGramatical.SIGNO_DIVISION;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado62()
        {
            categoria = CategoriaGramatical.PORCENTAJE;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado63()
        {
            categoria = CategoriaGramatical.SIGNO_IGUAL;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado64()
        {
            categoria = CategoriaGramatical.BARRA_INVERSA;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado65()
        {
            categoria = CategoriaGramatical.PALO;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado66()
        {
            categoria = CategoriaGramatical.COMILLA;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado67()
        {
            categoria = CategoriaGramatical.ACENTO_CIRCUNFLEJO;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado68()
        {
            categoria = CategoriaGramatical.EXCLAMACION_ABRE;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado69()
        {
            categoria = CategoriaGramatical.EXCLAMACION_CIERRA;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado70()
        {
            categoria = CategoriaGramatical.SIGNO_DE_PREGUNTA_ABRE;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado71()
        {
            categoria = CategoriaGramatical.SIGNO_DE_PREGUNTA_CIERRA;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado72()
        {
            categoria = CategoriaGramatical.GUION_BAJO;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado73()
        {
            categoria = CategoriaGramatical.MAYOR_QUE;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado74()
        {
            categoria = CategoriaGramatical.MENOR_QUE;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado75()
        {
            categoria = CategoriaGramatical.SUPERINDICE_A;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado76()
        {
            categoria = CategoriaGramatical.SUPERINDICE_0;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado77()
        {
            categoria = CategoriaGramatical.VERGULILLA;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado78()
        {
            categoria = CategoriaGramatical.COMILLA_ABRE;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado79()
        {
            categoria = CategoriaGramatical.COMILLA_CIERRA;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado80()
        {
            categoria = CategoriaGramatical.SIGNO_ESPACIO;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado81()
        {
            categoria = CategoriaGramatical.COMILLA_SIMPLE;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }
        private void ProcesarEstado82() {

            falla = "Caracter no valido";
            causa = "El calracter: " + caracterActual + " no esta reconocido por el sistema";
            solucion = "Asegurese de ingresar un digito valido";
            ReportarErrorLexicoStopper();
        }
        private void ProcesarEstado83() 
        {
            CargarNuevaLinea();
            Resetear();

        }
        private void ProcesarEstado84() 
        {
            categoria = CategoriaGramatical.FIN_ARCHIVO;
            Concatenar();
            FormarComponenteLexico();
            continuarAnalisis = false;
        }


    }
}