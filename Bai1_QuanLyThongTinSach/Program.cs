﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_QuanLyThongTinSach
{
    public class Program
    {
        static List<Book> _books;
        static void Main(string[] args)
        {
            _books = new List<Book>();

            while (true)
            {
                Console.WriteLine("Choose Function:(1:Add Book;2:Show List Book, 3: Search Book, 4:Exit Application)");
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int funtion);
                if (!CheckinputCondition)
                {
                    Console.WriteLine("You choose wrong Format of Function!");
                    Console.WriteLine("Please choose option again!");
                    continue;
                }
                switch (funtion)
                {
                    case (int)FunctionApp.Add:
                        AddBook(); break;
                    case (int)FunctionApp.Show:
                        ShowListBook(); break;
                    case (int)FunctionApp.Search:
                        SearchBook(); break;
                    case (int)FunctionApp.Exit:
                        Environment.Exit(0); break;
                    default:
                        Console.WriteLine("You choose wrong Function!");
                        Console.WriteLine("Please choose option again!");
                        Console.WriteLine("-----------------------------");

                        break;
                }

            }

        }

        private static void AddBook()
        {
            var book = new Book();
            Console.WriteLine("Please input information of Book:");
            Console.WriteLine("---------------------------------");
            while (true)
            {
                Console.WriteLine("Name Of Book:");
                book.Tittle = Console.ReadLine();

                Console.WriteLine("Author Of Book:");
                book.Author = Console.ReadLine();

                while (true)
                {
                    CultureInfo provider = CultureInfo.InvariantCulture;

                    string format = "dd-MM-yyyy";
                    Console.WriteLine("Year Of Publication:dd-MM-yyyy");
                    var dateTimeCheck = DateTime.TryParseExact(Console.ReadLine(), format, provider, DateTimeStyles.None, out DateTime yearOfPublication);
                    if (!dateTimeCheck)
                    {
                        Console.WriteLine("Type Wrong Format DateTime!");
                        Console.WriteLine("Please Input DateTime Again!");
                        Console.WriteLine("-----------------------------");
                        continue;
                    }
                    else
                    {
                        book.YearOfPublication = yearOfPublication;
                        if (CheckBookDuplicate(book) || _books.Count == 0)
                        {
                            _books.Add(book);
                            Console.WriteLine("Add Book Successful!");
                            Console.WriteLine("----------------------------------------------");
                            return;
                        }
                        break;
                    }
                }
            }


        }
        private static void ShowListBook()
        {
            if (_books.Count > 0)
            {
                Console.WriteLine("Book in ListBook:");
                int count = 1;
                foreach (var showbook in _books)
                {

                    Console.WriteLine($"{count}.Tittle: {showbook.Tittle}\nAuthor: {showbook.Author}\nYear of Publication: {showbook.YearOfPublication.ToString("dd-MM-yyyy")}");
                    Console.WriteLine("-----------------------------");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("Have no any book in ListBook");
                Console.WriteLine("---------------------------------------------------");
            }

        }
        private static void SearchBook()
        {
            while (true)
            {
                Console.WriteLine("Input Name of Book you want to find:");
                string tittleSearch = Console.ReadLine();
                if (!string.IsNullOrEmpty(tittleSearch))
                {
                    if (_books.Count > 0)
                    {
                        Console.WriteLine("Book in ListBook:");
                        int count = 1;
                        foreach (var book in _books)
                        {
                            if (book.Tittle.ToUpper() == tittleSearch.ToUpper())
                            {
                                Console.WriteLine($"{count}.Tittle: {book.Tittle}\nAuthor: {book.Author}\nYear of Publication: {book.YearOfPublication.ToString("dd-MM-yyyy")}");
                                Console.WriteLine("-----------------------------");
                            }


                        }
                    }
                    else
                    {
                        Console.WriteLine("Have no any book in ListBook");
                        Console.WriteLine("---------------------------------------------------");
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Tittle cannot be empty!");
                    Console.WriteLine("-----------------------------");
                    continue;
                }

            }


        }

        private static bool CheckBookDuplicate(Book BookCheck)
        {
            if (_books.Count > 0)
            {
                foreach (var book in _books)
                {
                    if (BookCheck.Tittle == book.Tittle && BookCheck.Author == book.Author && BookCheck.YearOfPublication == book.YearOfPublication)
                    {
                        Console.WriteLine("Book is exist!Please Add Book Again!");
                        Console.WriteLine("-----------------------------------");
                        return false;
                    }

                }

                return true;
            }
            else { return false; }

        }

    }
}
