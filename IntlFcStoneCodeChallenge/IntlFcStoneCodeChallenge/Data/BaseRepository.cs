using IntlFcStoneCodeChallenge.Interfaces;
using System.Collections.Generic;

namespace IntlFcStoneCodeChallenge.Data
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

        public bool Get(int id, out TEntity entity)
        {
            entity = null;
            return _entities.TryGetValue(id, out entity);
        }

        public bool Delete(int id, out TEntity entity)
        {
            entity = null;
            if (!_entities.TryGetValue(id, out entity))
                return false;
            return _entities.Remove(id);
        }

        public bool Update(int id, TEntity updatedEntity)
        {
            TEntity entity;
            if (!_entities.TryGetValue(id, out entity))
                return false;
            _entities[id] = updatedEntity;
            return true;
        }

        public bool Create(TEntity newEntity, int id = 0)
        {
            if (id == 0)
            {
                id = lastId;
                lastId++;
            }
            if (_entities.ContainsKey(id))
                _entities.Add(id++, newEntity);
            else
                _entities.Add(id, newEntity);
            lastId = id;
            return true;
        }

        public Dictionary<int, TEntity> GetAllEntities()
        {
            return _entities;
        }
    }
}
