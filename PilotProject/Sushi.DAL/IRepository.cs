using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.DAL
{
    public interface IRepository<T>
    {
        void Add(T set);

        List<T> GetAll();

        T Get(int id);
    }
}
