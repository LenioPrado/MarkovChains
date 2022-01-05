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

            PreencherEstadoDestino();
            VerificarIntervalosDataEstados();
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

        private void PreencherEstadoDestino()
        {
            for (int index = 0; index < Estados.Count(); index++)
            {
                if (index > 0)
                {
                    Estados estadoAtual = Estados.ElementAt(index);
                    Estados[index - 1].EstadoDestino = estadoAtual;
                }
            }

            Estados = Estados.Where(estado => estado.EstadoDestino != null && !string.IsNullOrEmpty(estado.Sigla)).ToList();
        }

        private void VerificarIntervalosDataEstados()
        {
            IList<string> erros = new List<string>();

            foreach (var estado in Estados)
            {
                if (estado.EstadoDestino != null && estado.EstadoDestino.Inicio != estado.Fim)
                {                    
                    erros.Add(estado.ToString());
                }
            }

            if (erros.Count > 0)
            {
                erros.ToList().ForEach(erro => Console.WriteLine(erro));
            }           
        }

        private void DividirEstadosPorOrigemDestino()
        {
            foreach (var estadoAtual in ObterListaDistintadeEstadosAtuais())
            {
                var listaUGEstadoAtual = Estados.Where(c => c.Sigla.Equals(estadoAtual));

                foreach (var estadoDestino in ObterListaDistintadeEstadosDestino())
                {
                    var listaUGEstadoDestino = listaUGEstadoAtual.Where(c => c.EstadoDestino.Sigla.Equals(estadoDestino));

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
            return Estados.Select(c => c.Sigla).OrderBy(c => c).Distinct();
        }

        private IEnumerable<string> ObterListaDistintadeEstadosDestino()
        {
            return Estados.Where(c => c.EstadoDestino != null).Select(c => c.EstadoDestino.Sigla).OrderBy(c => c).Distinct();
        }
    }
}
