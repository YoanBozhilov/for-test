using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace for_test.Models
{
    public class SQLDbContext : DbContext
    {
        public SQLDbContext(DbContextOptions<SQLDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Event> Events { get; set; }

    }
}
