using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle.DAL
{
    public interface IRepository<T>
    {
        void Add(T moto);

        T GetById(Guid id);

        List<T> GetAll();

        void Delete(Guid id);
    }
}
