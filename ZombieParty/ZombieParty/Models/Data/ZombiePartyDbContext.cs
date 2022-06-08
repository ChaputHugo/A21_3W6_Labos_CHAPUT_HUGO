using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty.Models.Data
{
    public class ZombiePartyDbContext: DbContext
    {


        public ZombiePartyDbContext(DbContextOptions<ZombiePartyDbContext> options) : base(options)
        {

        }

        public DbSet<Zombie> Zombie { get; set; }
        public DbSet<ZombieType> ZombieType { get; set; }
        public DbSet<HuntingLog> HuntingLog { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            if (modelBuilder == null)
                return;

            modelBuilder.Entity<Zombie>().HasKey(p => p.Id);
            modelBuilder.Entity<ZombieType>().HasKey(p => p.Id);
            modelBuilder.Entity<HuntingLog>().HasKey(p => p.Id);

            modelBuilder.GenerateData();
        }
    }
}
