using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Asp_.net_core.Models
{
    public class Asp_net_coreContext : DbContext
    {
        public Asp_net_coreContext (DbContextOptions<Asp_net_coreContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_.net_core.Models.Movies> Movies { get; set; }
    }
}
