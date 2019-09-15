using System.Collections.Generic;

namespace IntlFcStoneCodeChallenge.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        bool Get(int id, out TEntity entity);
        bool Delete(int id, out TEntity entity);
        bool Update(int id, TEntity updatedEntity);
        bool Create(TEntity newEntity, int id = 0);
        Dictionary<int, TEntity> GetAllEntities();
    }
}
