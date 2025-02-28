﻿using Examen_Parcial_Compiladores.AnalizadorLexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_Compiladores.TablaComponentes
{
    public class TablaDummy
    {
        private Dictionary<string, List<ComponenteLexico>> tabla = new Dictionary<string, List<ComponenteLexico>>();

        public void Limpiar()
        {
            tabla.Clear();
        }
        public void Agregar(ComponenteLexico componente)
        {
            if (componente != null && TipoComponente.DUMMY.Equals(componente.Tipo))
            {
                ObtenerSimbolos(componente.Lexema).Add(componente);
            }
        }
        public List<ComponenteLexico> ObtenerSimbolos(string lexema)
        {
            if (!tabla.ContainsKey(lexema))
            {
                tabla.Add(lexema, new List<ComponenteLexico>());
            }
            return tabla[lexema];
        }
        public List<ComponenteLexico> ObtenerTodosSimbolos()
        {
            List<ComponenteLexico> listaRetorno = new List<ComponenteLexico>();
            foreach (List<ComponenteLexico> lista in tabla.Values)
            {
                listaRetorno.AddRange(lista);
            }
            return listaRetorno;
        }
    }
}
