using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.DAL
{
    public class OrderRepository<BaseOrder> : IRepository<BaseOrder> 
    {
        
        public void Add(BaseOrder set)
        {
            throw new NotImplementedException();
        }

        public BaseOrder Get(int id)
        {
            throw new NotImplementedException();
        }

        List<BaseOrder> IRepository<BaseOrder>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
