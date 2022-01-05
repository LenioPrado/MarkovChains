using Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace Common.Helpers
{
    public class ShowResultsHelper
    {
        private static AppLogger _aappLogger;

        public static void SetAppLogger(AppLogger appLogger)
        {
            _aappLogger = appLogger;
        }

        private static void Log(string content)
        {
            _aappLogger.LogInformation(content);
        }

        public static void ShowAttributesValues(string titleMsg, IEnumerable<DadosUG> dadosUGs)
        {
            if (dadosUGs.Count() > 0)
            {
                dadosUGs = dadosUGs.OrderBy(c => c.UG);
                IEnumerable<int> sizes = new int[] { 10, 13, 10, 14, 10, 10, 9 };
                IEnumerable<string> fields = new string[] { "UG", "Estado Origem", "Nº Origem", "Estado Destino", "Nº Destino", "Percentual", "Formatado" };

                ResultFormatterHelper result = new ResultFormatterHelper(sizes, fields);

                foreach (DadosUG dadoUG in dadosUGs)
                {
                    foreach (var dadoEstadoAtualDestino in dadoUG.DadosEstadoAtualDestino)
                    {
                        string estadoOrigem = dadoEstadoAtualDestino.Key.Key;
                        string estadoDestino = dadoEstadoAtualDestino.Key.Value;
                        DadosOrigemDestino origemDestino = dadoEstadoAtualDestino.Value;

                        if (origemDestino.ContagemEstadoDestino > 0)
                        {
                            IEnumerable<object> contentData = new object[]
                                            {
                            dadoUG.UG, estadoOrigem, origemDestino.ContagemEstadoAtual, estadoDestino, origemDestino.ContagemEstadoDestino, origemDestino.Percentual, $"{origemDestino.PercentualFormatado} %"
                                            };

                            result.AddContentData(contentData.ToArray(), Alignment.Left);      
                        }                   
                    }
                    result.AddDashLine();
                }
                Log(result.GetFormattedHeader(titleMsg, Alignment.Left));
                Log(result.GetFormattedContent());
            }
        }
    }
}
