// using Microsoft.EntityFrameWorkCore;
// using Microsoft.EntityFrameworkCore;

// public class BasicDbContext : DbContext
// {
//     public DBset<Teacher> Teachers { get; set; }
//     protected override void OnConfiguring(BasicDbContextOptionBuilder optionBuilder)
//     {
//         optionBuilder.UseSqite("Data Source=College.db");
//     }
//}

using System;

namespace NetStarter.Basics.DataAccess
{
    public class BasicDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=College.db");
        }
    }
}