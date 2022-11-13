using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1.Persistence.Contexts
{
    public class MsDbContext : BaseDbContext
    {
        public MsDbContext(DbContextOptions<MsDbContext> options, IConfiguration configuration)
              : base(options, configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder.UseSqlServer(Configuration.GetConnectionString("MsContext")));
            }
        }
    }
}
