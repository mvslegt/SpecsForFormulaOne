using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SpecsForFormulaOne.Web.Data
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
    }
}
