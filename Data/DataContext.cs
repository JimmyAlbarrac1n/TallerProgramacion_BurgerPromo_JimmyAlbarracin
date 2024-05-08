using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerProgramacion.Models;

namespace Taller
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<TallerProgramacion.Models.Burger> Burger { get; set; } = default!;
        public DbSet<TallerProgramacion.Models.Promo> Promo { get; set; } = default!;
    }
}
