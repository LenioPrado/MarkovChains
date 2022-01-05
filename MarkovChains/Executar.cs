using Common.Helpers;
using MarkovChains.Inferencia;
using Microsoft.Extensions.Logging;
using System;

namespace Common
{
    public class Executar
    {
        public Executar(ILogger<Executar> logger)
        {
            ShowResultsHelper.SetAppLogger(new AppLogger(logger, "MarkovChains.log"));
        }

        public void ExecutarTarefas()
        {
            var estados = LerArquivoExcel.LerArquivo();
            
            EstadosPorUnidade estadosPorUnidade = new EstadosPorUnidade(estados);
            var dadosUGs = estadosPorUnidade.ObterDadosUGsPorEstados();

            //unidadeEstados.ExibirResultados();
            ExecutorInferencia.RodarInferencia(dadosUGs);
            //ExecutorInferencia.RunCyclingTime2();

            Console.ReadKey();
        }        
    }
}
