using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public class InterpretadorMatlab
    {
        private static string SCRIPT_PATH = @"D:\Develop\AspNetCore\Markov Chains\Common\Scripts\";
        private static int OUTPUT_PARAMS = 4;

        public static CadeiaMarkov ExecutarMatlab(double[,] matriz, IEnumerable<string> estados, int iteracoes, int estadoAtual)
        {
            MLApp.MLApp matlab = new MLApp.MLApp();

            matlab.Execute($"cd '{SCRIPT_PATH}'");

            matlab.Feval("CadeiaMarkov", OUTPUT_PARAMS, out object result, matriz, estados.ToArray(), iteracoes, estadoAtual);

            matlab.Quit();

            return new CadeiaMarkov(result);
        }
    }
}
