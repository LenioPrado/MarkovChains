using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Model
{
    public class DadosUG
    {
        public string UG { get; set; }
        public IList<Estados> Estados { get; set; }
        public IDictionary<KeyValuePair<string, string>, DadosOrigemDestino> DadosEstadoAtualDestino { get; set; }

        public DadosUG(string ug, IEnumerable<Estados> estados)
        {
            UG = ug;
            Estados = estados.ToList();
            DadosEstadoAtualDestino = new Dictionary<KeyValuePair<string, string>, DadosOrigemDestino>();

            DividirEstadosPorOrigemDestino();           
        }

        public DadosOrigemDestino ObterDadosOrigemDestino(string estadoOrigem, string estadoDestino)
        {
            var parOrigemDestino = new KeyValuePair<string, string>(estadoOrigem, estadoDestino);

            if (DadosEstadoAtualDestino.ContainsKey(parOrigemDestino))
            {
                return DadosEstadoAtualDestino[parOrigemDestino];
            }

            return null;
        }

        private void DividirEstadosPorOrigemDestino()
        {
            foreach (var estadoAtual in ObterListaDistintadeEstadosAtuais())
            {
                var listaUGEstadoAtual = Estados.Where(c => c.EstadoOrigem.Equals(estadoAtual));

                foreach (var estadoDestino in ObterListaDistintadeEstadosDestino())
                {
                    var listaUGEstadoDestino = listaUGEstadoAtual.Where(c => !string.IsNullOrEmpty(c.EstadoDestino) && c.EstadoDestino.Equals(estadoDestino));

                    DadosOrigemDestino dadosOrigemDestino = new() 
                    { 
                        ListaEstadoAtual = listaUGEstadoAtual,
                        ListaEstadoDestino = listaUGEstadoDestino
                    };

                    var parEstadoOrigemDestino = new KeyValuePair<string, string>(estadoAtual, estadoDestino);
                                        
                    if (DadosEstadoAtualDestino.ContainsKey(parEstadoOrigemDestino))
                    {
                        DadosEstadoAtualDestino[parEstadoOrigemDestino] = dadosOrigemDestino;
                    }
                    else
                    {                        
                        DadosEstadoAtualDestino.Add(parEstadoOrigemDestino, dadosOrigemDestino);
                    }
                }
            }
        }

        private IEnumerable<string> ObterListaDistintadeEstadosAtuais()
        {
            return Estados.Select(c => c.EstadoOrigem).OrderBy(c => c).Distinct();
        }

        private IEnumerable<string> ObterListaDistintadeEstadosDestino()
        {
            return Estados.Where(c => c.EstadoDestino != null).Select(c => c.EstadoDestino).OrderBy(c => c).Distinct();
        }
    }
}
