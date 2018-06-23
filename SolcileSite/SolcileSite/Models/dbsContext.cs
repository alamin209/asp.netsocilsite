using Microsoft.EntityFrameworkCore;
using SolcileSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocileSIte.Models
{
    public class dbsContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Feature { get; set; }
        public dbsContext(DbContextOptions<dbsContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Userfeature>().HasKey(uf =>
            new { uf.UserId, uf.FeatureId }
            );

        }



    }
}
