using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork06
{
    public class GenericClass<T>
    {
        private List<T> listObject { get; set; } = new List<T>();

        public  void Add(T _object)
        {
            listObject.Add(_object);
        }

        public bool Remove(T _object)
        {
            if(_object == null) return false;
          return listObject.Remove(_object);
        }
        public void ChangeProperty(int index,T _object) 
        {
            if(index !=-1 && _object != null)
            {
                listObject[index] = _object;
            }
           
            
        }

        public List<T> FindAll()
        {
            return listObject;
        }

    }
}
