using Microsoft.EntityFrameworkCore;

namespace SpecsForFormulaOne.Web.Data
{
    public class FormulaOneContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasKey(t => t.Id);
        }
    }
}
