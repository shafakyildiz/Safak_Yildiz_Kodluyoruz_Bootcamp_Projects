using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class Book
    {
        public Book GetBookById(string bookId);
        public List<Book> GetBook();
        public Book CreateBook(Book book);
        public Book EditBook(Book book);
        public void DeleteBook(string bookId);
    }
}
