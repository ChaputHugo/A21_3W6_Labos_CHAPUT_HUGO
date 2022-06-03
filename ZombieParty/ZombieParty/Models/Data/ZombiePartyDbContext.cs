using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty.Models.Data
{
    public class ZombiePartyDbContext : DbContext
    {
        public ZombiePartyDbContext(DbContextOptions<ZombiePartyDbContext> options) : base(options)
        {

        }
        public DbSet<Zombie> zombie { get; set; }
        public DbSet<ZombieType> zombieTypes { get; set; }
        public DbSet<HuntingLog> HuntingLog { get; set; }
    }
}
