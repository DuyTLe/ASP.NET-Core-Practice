using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASPNetTest.Models
{
    public class ASPNetTestContext : DbContext
    {
        public ASPNetTestContext (DbContextOptions<ASPNetTestContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNetTest.Models.Product> Product { get; set; }
    }
}
