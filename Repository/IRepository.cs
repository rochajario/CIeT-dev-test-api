using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_ciet.Repository
{
    public interface IRepository<T>
    {
        void Create(T item);
        List<T> Read();
        void Update(T item);
        void Delete(T item);
    }
}
