using System.Collections.Generic;

namespace SpecsForFormulaOne.Mvc.Data
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);
        void Add(TEntity entity);
        IEnumerable<TEntity> GetAll();
        int SaveChanges();
    }
}
