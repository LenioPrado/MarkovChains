using Octave.NET;
using System.IO;
using System.Text.RegularExpressions;

namespace Common.Helpers
{
    public class InterpretadorOctave
    {
        private string script;
        private readonly AppLogger _appLogger;
        private readonly string INTERPRETER_PATH = @"C:\\Program Files\\GNU Octave\\Octave-6.2.0\\mingw64\\bin\\octave-cli.exe";

        public InterpretadorOctave(string arquivoScript, AppLogger appLogger)
        {
            script = File.ReadAllText(arquivoScript);
            _appLogger = appLogger;
        }

        public void AdicionarParametro(string parametro, double[][] matriz)
        {
            Replace(parametro, matriz.ToOctave());
        }

        public void AdicionarParametro(string parametro, double[] vetor)
        {
            Replace(parametro, vetor.ToOctave());
        }

        public void AdicionarParametro(string parametro, double escalar)
        {
            Replace(parametro, escalar.ToString().Replace(",", "."));
        }

        public void AdicionarParametro(string parametro, string valor)
        {
            Replace(parametro, $"'{valor}'");
        }

        public void AdicionarParametro(string parametro, bool[] vetor)
        {
            string join = $"[ {string.Join(" ", vetor)} ]".ToLowerInvariant();
            Replace(parametro, join);
        }

        private void Replace(string parametro, string valor)
        {
            script = Regex.Replace(script, $@"@\b{parametro}\b", valor);
        }

        public double[][] Executar()
        {
            OctaveContext.OctaveSettings.OctaveCliPath = INTERPRETER_PATH;
            using (var octave = new OctaveContext())
            {
                string resposta = octave.Execute(script, int.MaxValue);

                string startString = "valor =";
                int indexStart = resposta.IndexOf(startString) + startString.Length;

                string respostaProcessada = resposta.Substring(indexStart, resposta.Length - indexStart);

                _appLogger.LogInformation($"Resultado Otimizador: {respostaProcessada}");

                return respostaProcessada.AsMatrix();                
            }                
        }
    }
}
