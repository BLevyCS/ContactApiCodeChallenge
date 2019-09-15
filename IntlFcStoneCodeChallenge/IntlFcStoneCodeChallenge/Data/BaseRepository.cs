using IntlFcStoneCodeChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntlFcStoneCodeChallenge.Data
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected Dictionary<int, TEntity> _entities;

        public BaseRepository()
        {
            _entities = new Dictionary<int, TEntity>();
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

        public bool Create(int id, TEntity newEntity)
        {
            if (_entities.ContainsKey(id))
                _entities.Add(id++, newEntity);
            else
                _entities.Add(id, newEntity);
            return true;
        }

        public Dictionary<int, TEntity> GetAllEntities()
        {
            return _entities;
        }
    }
}
