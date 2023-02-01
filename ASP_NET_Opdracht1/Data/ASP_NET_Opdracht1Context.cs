using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_NET_Opdracht1.Models;

namespace ASP_NET_Opdracht1.Data
{
    public class ASP_NET_Opdracht1Context : DbContext
    {
        public ASP_NET_Opdracht1Context (DbContextOptions<ASP_NET_Opdracht1Context> options)
            : base(options)
        {
        }

        public DbSet<ASP_NET_Opdracht1.Models.Leden> Leden { get; set; } = default!;

        public DbSet<ASP_NET_Opdracht1.Models.Verhuur> Verhuur { get; set; }

        public DbSet<ASP_NET_Opdracht1.Models.Verhuurlijn> Verhuurlijn { get; set; }

        public DbSet<ASP_NET_Opdracht1.Models.Films> Films { get; set; }
    }
}
