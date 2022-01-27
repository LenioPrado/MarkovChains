using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model.Data
{
    public class RepositorioEstados : BaseRepository<Estados, MarkovDbContext, int>
    {
        public RepositorioEstados(MarkovDbContext context) : base(context)
        {
        }
    }
}
