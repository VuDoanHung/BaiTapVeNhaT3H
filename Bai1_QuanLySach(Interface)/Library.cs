using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_QuanLySach_Interface_
{
    abstract class Library
    {
        public abstract void AddBook();
        public abstract void FindBook();
        public abstract void RemoveBook();
        public abstract void BorrowBook();
        
    }
}
