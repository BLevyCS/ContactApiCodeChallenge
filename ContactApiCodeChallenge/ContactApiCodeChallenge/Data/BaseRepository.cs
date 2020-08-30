using ContactApiCodeChallenge.Interfaces;
using System.Collections.Generic;

namespace ContactApiCodeChallenge.Data
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected Dictionary<int, TEntity> _entities;
        protected int lastId;

        public BaseRepository()
        {
            _entities = new Dictionary<int, TEntity>();
            lastId = 0;
        }

        public virtual bool Get(int id, out TEntity entity)
        {
            entity = null;
            return _entities.TryGetValue(id, out entity);
        }

        public virtual bool Delete(int id, out TEntity entity)
        {
            entity = null;
            if (!_entities.TryGetValue(id, out entity))
                return false;
            return _entities.Remove(id);
        }

        public virtual bool Update(int id, TEntity updatedEntity)
        {
            TEntity entity;
            if (!_entities.TryGetValue(id, out entity))
                return false;
            _entities[id] = updatedEntity;
            return true;
        }

        public virtual bool Create(TEntity newEntity)
        {
            _entities.Add(lastId, newEntity);
            lastId++;
            return true;
        }

        public Dictionary<int, TEntity> GetAllEntities()
        {
            return _entities;
        }
    }
}
