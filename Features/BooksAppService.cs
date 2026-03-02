using Books_Api.Entities;

namespace Books_Api.Features
{
    public class BooksAppService
    {
        private List<Book> _books = new();

        public BooksAppService() 
        {
            _books.Add(new Book
            {
                Id = 1,
                Title = "Design Patterns",
                Author = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides",
                Date = new DateTime(1994, 10, 31),
                Description = "A book about software design patterns and best practices."
            });
            _books.Add(new Book
            {
                Id = 2,
                Title = "Design Thinking",
                Author = "Tim Brown",
                Date = new DateTime(2009, 9, 1),
                Description = "A book about the design thinking process and how to apply it to solve complex problems."
            });
            _books.Add(new Book
            {
                Id = 3,
                Title = "1984",
                Author = "George Orwell",
                Date = new DateTime(1949, 6, 8),
                Description = "A dystopian novel about totalitarianism and surveillance."
            });
            _books.Add(new Book
            {
                Id = 4,
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                Date = new DateTime(1813, 1, 28),
                Description = "A romantic novel about manners and marriage in early 19th century England."
            });
            _books.Add(new Book
            {
                Id = 5,
                Title = "Structure and Interpretation of Computer Programs",
                Author = "Harold Abelson and Gerald Jay Sussman",
                Date = new DateTime(1985, 7, 1),
                Description = "A textbook on computer programming and software engineering."
            });
        }

        public List<Book> GetBooks()
        {
            return _books;
        }

        public Book GetBookById(int id)
        {
            return _books.Where(x => x.Id == id).FirstOrDefault();
        }
    
        public void AddBook(Book book)
        {
            if (string.IsNullOrEmpty(book.Title)) return;
            _books.Add(book);
        }
    
        public void UpdateBook(int id, Book updatedBook)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                book.Title = updatedBook.Title;
                book.Author = updatedBook.Author;
                book.Date = updatedBook.Date;
                book.Description = updatedBook.Description;
            }
        }
    
        public void DeleteBook(int id)
        {
            _books.RemoveAll(b => b.Id == id);
        }
    }
}
