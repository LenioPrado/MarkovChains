using Common.Model;
using System;
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

                        if (origemDestino.SomaDuracaoEstadoDestino > 0)
                        {
                            IEnumerable<object> contentData = new object[]
                                            {
                            dadoUG.UG, estadoOrigem, origemDestino.SomaDuracaoEstadoAtual, estadoDestino, origemDestino.SomaDuracaoEstadoDestino, origemDestino.Percentual, $"{origemDestino.PercentualFormatado} %"
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

        public static void ShowEstadosValues(string titleMsg, IEnumerable<Estados> estados)
        {
            if (estados.Count() > 0)
            {
                estados = estados.OrderBy(c => c.UG).ThenBy(c => c.Inicio);
                IEnumerable<int> sizes = new int[] { 9, 10, 6, 7, 20, 20, 14 };
                IEnumerable<string> fields = new string[] { "UG", "Ocorrencia", "Origem", "Destino", "Inicio", "Fim", "Duracao" };

                ResultFormatterHelper result = new ResultFormatterHelper(sizes, fields);

                string currentUG = "";
                foreach (Estados estado in estados)
                {
                    IEnumerable<object> contentData = new object[]
                    { estado.UG, estado.Ocorrencia, estado.EstadoOrigem, estado.EstadoDestino, estado.Inicio, estado.Fim, Math.Round(estado.Duracao, 3) };
                                        

                    if (!currentUG.Equals(estado.UG))
                    {
                        if (!string.IsNullOrEmpty(currentUG))
                            result.AddDashLine();
                        
                        currentUG = estado.UG;                        
                    }
                    result.AddContentData(contentData.ToArray(), Alignment.Left);
                }
                Log(result.GetFormattedHeader(titleMsg, Alignment.Left));
                Log(result.GetFormattedContent());
            }
        }
    }
}
