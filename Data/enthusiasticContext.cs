using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using enthusiastic.Models;

namespace enthusiastic.Data
{
    public class enthusiasticContext : DbContext
    {
        public enthusiasticContext (DbContextOptions<enthusiasticContext> options)
            : base(options)
        {
        }

        public DbSet<enthusiastic.Models.Post> Post { get; set; } = default!;
    }
}
