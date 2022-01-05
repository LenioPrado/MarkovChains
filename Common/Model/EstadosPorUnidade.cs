using Common.Helpers;
using Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class EstadosPorUnidade
    {
        private readonly IEnumerable<Estados> _estados;
        private readonly IList<DadosUG> _dadosUGs = new List<DadosUG>();
        
        public EstadosPorUnidade(IEnumerable<Estados> estados)
        {
            _estados = estados;
        }

        public IEnumerable<DadosUG> ObterDadosUGsPorEstados()
        {
            var filtered = _estados.Where(c => !string.IsNullOrEmpty(c.Sigla));

            var grupoUGsComEstados = filtered.GroupBy(c => c.UG,
                            (ug, listaEstados) => new
                            {
                                UG = ug,
                                Estados = listaEstados
                            });

            foreach (var ugComEstados in grupoUGsComEstados)
            {
                _dadosUGs.Add(new DadosUG(ugComEstados.UG, ugComEstados.Estados));
            }

            return _dadosUGs;
        }        

        public void ExibirResultados()
        {
            ShowResultsHelper.ShowAttributesValues("Mostrando informações da tabela de probabilidades", _dadosUGs);
        }        
    }
}
