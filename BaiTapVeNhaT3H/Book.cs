using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVeNhaT3H
{
    public struct Book
    {
        public string Tittle { get; set; }
        public string Author { get; set;}
        public DateTime YearOfPublication { get; set;}
        public Book(string _title,string _author,DateTime _yearOfPublication)
        {
            Tittle = _title;
            Author = _author;
            YearOfPublication = _yearOfPublication;
        }
    }
   
}
public enum FunctionBook
{
    AddBook = 1,
    ShowBook,
    SearchBook,
    Exit,

}
