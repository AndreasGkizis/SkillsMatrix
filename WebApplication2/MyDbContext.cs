using Domain;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2
{
    public class MyDbContext : DbContext
    {
        public DbSet<HardSkill> HardSkills { get; set; }
        public DbSet<SoftSkill> SoftSkills { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public MyDbContext(DbContextOptions options)
            :base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}
