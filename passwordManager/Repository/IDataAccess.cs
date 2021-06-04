using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IDataAccess<T>
    {
        T Get(T entity);

        IEnumerable<T> GetAll();

        void Add(T entity);

        void Delete(T entity);

        void Modify(T entity);
    }
}
