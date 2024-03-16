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
        List<BookDetails> ListOfBooks;
        FileConnection fileConnection;
        public BookStoreBL()
        {
            fileConnection = new FileConnection();
            ListOfBooks = fileConnection.ReadAllBooks();
        }
        //1
        public IEnumerable<BookDetails> GetBooksOn30()
        {
            return ListOfBooks.Where(book => book.Price > 30);

        }
        //2
        public IEnumerable<BookDetails> OrderBooks()
        {
            return ListOfBooks.OrderBy(book => book.Id);

        }
        //3
        public IEnumerable<int> OnlyComics()
        {
            return ListOfBooks.Where(book => book.IsComics ==true).Select(book => book.Price);
        }
        //4
        public IEnumerable<string> FitAge9()
        {
            return ListOfBooks.Where(book => book.MaxAge <10).Select(book => book.Name);
        }

        public IEnumerable<BookDetails> GetAllBooks()
        {
            return ListOfBooks;
        }
    }
}
