using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatlabMarkovChains
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var formProbabilidades = serviceProvider.GetRequiredService<Probabilidades>();
                Application.Run(formProbabilidades);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<Probabilidades>()
                    .AddLogging(configure => configure.AddConsole());
        }
    }
}
