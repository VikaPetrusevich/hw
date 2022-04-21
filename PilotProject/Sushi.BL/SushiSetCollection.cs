using Sushi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.BL
{
    public class SushiSetCollection : ISushiSetCollection
    {
        private IRepository<SushiSet> _sushiRepository = new ListRepository<SushiSet>();

        public void AddSet(SushiSet sushiSet)
        {
            _sushiRepository.Add(sushiSet);
        }

        public List<SushiSet> GetSushiList()
        {
            var allSushiSet = _sushiRepository.GetAll();
            return allSushiSet.Select(s => (SushiSet)s).ToList();
        }
    }
}