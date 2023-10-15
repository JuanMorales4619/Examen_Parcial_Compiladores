using Examen_Parcial_Compiladores.AnalizadorLexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.TablaComponentes
{
    public class TablaMaestra
    {
        private static TablaMaestra TABLA_MAESTRA = new TablaMaestra();
        private TablaSimbolos tablaSimbolos = new TablaSimbolos();
        private TablaLiteral tablaLiterales = new TablaLiteral();
        private TablaDummy tablaDummy = new TablaDummy();
        private TablaPalabraReservada tablaPalabraReservada = new TablaPalabraReservada();

        public static TablaMaestra ObtenerTablaMaestra()
        {
            return TABLA_MAESTRA;
        }
        public void Limpiar()
        {
            tablaSimbolos.Limpiar();
            tablaLiterales.Limpiar();
            tablaDummy.Limpiar();
            tablaPalabraReservada.Limpiar();        
        }

        public void Agregar(ComponenteLexico componente)
        {
            tablaPalabraReservada.ComprobarPalabraReservada(componente);
            tablaSimbolos.Agregar(componente);
            tablaLiterales.Agregar(componente);
            tablaDummy.Agregar(componente);
            tablaPalabraReservada.Agregar(componente);
        }
        public List<ComponenteLexico> ObtenerSimbolo(TipoComponente tipo, string lexema)
        {
            switch(tipo)
            {
                case TipoComponente.SIMBOLO:
                    return tablaSimbolos.ObtenerSimbolos(lexema);
                case TipoComponente.LITERAL:
                    return tablaLiterales.ObtenerSimbolos(lexema);
                case TipoComponente.PALABRA_RESERVADA:
                    return tablaPalabraReservada.ObtenerSimbolos(lexema);
                case TipoComponente.DUMMY:
                    return tablaDummy.ObtenerSimbolos(lexema);
                default:
                    throw new Exception("Tipo de componente no valido");
            }
        }

        public List<ComponenteLexico> ObtenerTodosSimbolo(TipoComponente tipo)
        {
            switch (tipo)
            {
                case TipoComponente.SIMBOLO:
                    return tablaSimbolos.ObtenerTodosSimbolos();
                case TipoComponente.LITERAL:
                    return tablaLiterales.ObtenerTodosSimbolos();
                case TipoComponente.PALABRA_RESERVADA:
                    return tablaPalabraReservada.ObtenerTodosSimbolos();
                case TipoComponente.DUMMY:
                    return tablaDummy.ObtenerTodosSimbolos();
                default:
                    throw new Exception("Tipo de componente no valido");
            }
        }
    }
}
