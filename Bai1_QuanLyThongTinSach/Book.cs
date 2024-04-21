using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_QuanLyThongTinSach
{
    internal struct Book
    {
        public string Tittle { get; set; }
        public string Author { get; set; }
        public DateTime YearOfPublication { get; set; }
        public Book(string _title, string _author, DateTime _yearOfPublication)
        {
            Tittle = _title;
            Author = _author;
            YearOfPublication = _yearOfPublication;
        }
        void asd()
        {

        }
    }

}
public enum FunctionApp
{
    Add = 1,
    Show,
    Search,
    Exit,
    
}

