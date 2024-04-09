using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork06
{
    public class CollectionClass<T,A>
    {
        private Dictionary<T,A> _dicObject = new Dictionary<T,A>();
        public void AddItem(T key, A value)
        {
            _dicObject.Add(key, value);
        }

        public Dictionary<T,A> GetItem()
        {
            return _dicObject;
        }
    }
}
