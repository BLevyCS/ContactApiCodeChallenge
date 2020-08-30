using System.Collections.Generic;

namespace ContactApiCodeChallenge.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        bool Get(int id, out TEntity entity);
        bool Delete(int id, out TEntity entity);
        bool Update(int id, TEntity updatedEntity);
        bool Create(TEntity newEntity);
        Dictionary<int, TEntity> GetAllEntities();
    }
}
