using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalSeries.D.Interfaces
{
    interface IRepository<T>
    {
        List<T> List();

        T ReturnsById(int id);

        void Insert(T obj);

        void Erase(int id);

        void Update(int id, T obj);
        int NextId();
    }
}
