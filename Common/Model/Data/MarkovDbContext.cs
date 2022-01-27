using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model.Data
{
    public partial class MarkovDbContext : DbContext
    {
        public MarkovDbContext(DbContextOptions<MarkovDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estados> Estados { get; set; }        
    }
}
