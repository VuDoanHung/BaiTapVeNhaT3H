using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_SwapData
{
    public class Swap<T>
    {
        public void SwapData(ref T item1,ref T item2) 
        {
            var teampSwap = item1;
            item1 = item2;
            item2 = teampSwap;
        }

    }
}
