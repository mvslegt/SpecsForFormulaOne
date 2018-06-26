using System.Collections.Generic;
using System.Data.Entity;

namespace SpecsForFormulaOne.Mvc.Data
{
    public class TeamsRepository : IRepository<Team>
    {
        private readonly FormulaOneContext context;

        public TeamsRepository(DbContext context)
        {
            this.context = context as FormulaOneContext;
        }

        public void Add(Team entity)
        {
            context.Teams.Add(entity);
        }

        public IEnumerable<Team> GetAll()
        {
            return context.Teams;
        }

        public Team GetById(int id)
        {
            return context.Teams.Find(id);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
