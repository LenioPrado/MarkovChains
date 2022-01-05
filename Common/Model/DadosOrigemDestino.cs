using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Model
{
    public class DadosOrigemDestino
    {
        public IEnumerable<Estados> ListaEstadoAtual { get; set; }
        public int ContagemEstadoAtual { get { return ListaEstadoAtual.Count(); } }
        public IEnumerable<Estados> ListaEstadoDestino { get; set; }
        public int ContagemEstadoDestino { get { return ListaEstadoDestino.Count(); } }
        public double Percentual { get { return Math.Round((double)ListaEstadoDestino.Count() / (double)ListaEstadoAtual.Count(), 3); } }
        public double PercentualFormatado { get { return Math.Round(Percentual * 100, 3); } }
    }
}
