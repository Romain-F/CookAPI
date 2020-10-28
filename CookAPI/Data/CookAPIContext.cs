using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CookModel;

namespace CookAPI.Data
{
    public class CookAPIContext : DbContext
    {
        public CookAPIContext (DbContextOptions<CookAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Recipes> Recipes { get; set; }
    }
}
