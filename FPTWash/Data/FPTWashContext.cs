using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FPTWash.Models;

namespace FPTWash.Data
{
    public class FPTWashContext : DbContext
    {
        public FPTWashContext (DbContextOptions<FPTWashContext> options)
            : base(options)
        {
        }

        public DbSet<FPTWash.Models.Customer> Customer { get; set; } = default!;
    }
}
