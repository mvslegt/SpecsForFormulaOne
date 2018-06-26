using System.Data.Entity;

namespace SpecsForFormulaOne.Mvc.Data
{
    public class FormulaOneContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasKey(t => t.Id);
        }
    }
}
