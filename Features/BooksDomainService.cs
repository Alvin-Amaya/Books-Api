using Books_Api.Entities;

namespace Books_Api.Features
{
    public class BooksDomainService
    {
        public bool ValidateBook(Book book) 
        {
            if (string.IsNullOrEmpty(book.Title) || string.IsNullOrEmpty(book.Author))
            {
                return false;
            }
            return true;
        }
    }
}
