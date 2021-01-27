using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
   public interface IRepositoryService<T>
    {       
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
