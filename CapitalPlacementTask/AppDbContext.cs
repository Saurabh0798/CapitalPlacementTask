using CapitalPlacementTask.Models;
using Microsoft.EntityFrameworkCore;

namespace CapitalPlacementTask
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }

        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<ProgramDetails> ProgramDetails { get; set; }
    }
}
