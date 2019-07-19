using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvs.Models
{
    public class SalesWebMvsContext : DbContext
    {
        public SalesWebMvsContext (DbContextOptions<SalesWebMvsContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvs.Models.Department> Department { get; set; }
    }
}
