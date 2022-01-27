using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Model
{
    public class DadosOrigemDestino
    {
        public IEnumerable<Estados> ListaEstadoAtual { get; set; }
        public double SomaDuracaoEstadoAtual { get { return ListaEstadoAtual.Sum(c => c.Duracao); } }
        public IEnumerable<Estados> ListaEstadoDestino { get; set; }
        public double SomaDuracaoEstadoDestino { get { return ListaEstadoDestino.Sum(c => c.Duracao); } }
        public double Percentual { get { return Math.Round(SomaDuracaoEstadoDestino / SomaDuracaoEstadoAtual, 3); } }
        public double PercentualFormatado { get { return Math.Round(Percentual * 100, 3); } }
    }
}
