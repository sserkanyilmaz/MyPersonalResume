using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IBaseService<TEntity> where TEntity:class,IEntity,new()
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        List<TEntity> GetAll();
        TEntity Get(int id);
    }
}
