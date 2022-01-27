using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Common.Model.Data
{    
    public class MarkovDbContextFactory : IDesignTimeDbContextFactory<MarkovDbContext>
    {
        public MarkovDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MarkovDbContext>();
            optionsBuilder.UseSqlServer(DatabaseInfo.ObterDadosConexaoBanco(),
                    b => b.MigrationsAssembly("Common"));

            return new MarkovDbContext(optionsBuilder.Options);
        }
    }
}
