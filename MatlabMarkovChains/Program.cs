using Common.Model;
using Common.Model.Data;
using MatlabMarkovChains;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
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
            services.AddDbContextPool<MarkovDbContext>(options =>
            {
                options.UseSqlServer(DatabaseInfo.ObterDadosConexaoBanco(),
                    b => b.MigrationsAssembly("Common"));
                options.UseLazyLoadingProxies(true);
            });

            services.AddScoped<IRepositorio<Estados>, RepositorioEstados>();

            services.AddSingleton<Probabilidades>()
                    .AddLogging(configure => configure.AddConsole());
        }
    }
}
