using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksStoreDAL;
using Entities;

namespace BooksStoreBL
{
    public class BookStoreBL
    {
        public List<BookDetails> ListOfBooks;
        FileConnection fileConnection;

        public BookStoreBL()
        {
            fileConnection = new FileConnection();
            ListOfBooks = fileConnection.ReadAllBooks();
        }

        public IEnumerable<BookDetails> GetAllBooks()
        {
            return ListOfBooks;
        }
        public IEnumerable<BookDetails> BookExpensive()
        {
            return ListOfBooks.Where(book => book.Price > 30);
        }
        public IEnumerable<BookDetails> Arranged()
        {
            return ListOfBooks.OrderBy(book => book.Id);
        }
        public IEnumerable<int> PriceOfComics()
        {
            List<BookDetails> bookDetails = ListOfBooks.Where(book => book.IsComics).ToList();
            List<int> ints = bookDetails.Select(book => int.Parse(book.Price.ToString())).ToList();
            return ints;
        }
        public IEnumerable<string> BooksSuitableForAge9()
        {
            List<BookDetails> bookDetails = ListOfBooks.Where(book => (book.MinAge <= 9 && book.MaxAge >= 9)).ToList();
            List<string> str = bookDetails.Select(book => book.Name.ToString()).ToList();
            return str;
        }
    }
}

