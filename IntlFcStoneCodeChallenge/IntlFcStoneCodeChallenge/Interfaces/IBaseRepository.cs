using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntlFcStoneCodeChallenge.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        bool Get(int id, out TEntity entity);
    }
}
