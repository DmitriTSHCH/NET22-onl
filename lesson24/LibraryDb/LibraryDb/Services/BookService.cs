using LibraryDb.Interfaces;
using LibraryDb.Repositories;

namespace LibraryDb.Services
{
    public class BookService : IBookService
    {
        private readonly BooksRepository _booksRepository;               //надо бы через IBookRepository но его нет(
        public BookService(BooksRepository BooksRepository)
        { 
            _booksRepository = BooksRepository;
        }
        public void Add(int _id, string _title, string _ISBN, DateOnly _publicationYear, float _price, int _authorId, int _publisherId)
        {
            _booksRepository.Add(_id, _title, _ISBN, _publicationYear, _price, _authorId, _publisherId);
        }
        public void Update(int _id, string _title, string _ISBN, DateOnly _publicationYear, float _price, int _authorId, int _publisherId)
        {
            _booksRepository.Update(_id, _title, _ISBN, _publicationYear, _price, _authorId, _publisherId);
        }
        public void Delete(int _id)
        {
            _booksRepository.Delete(_id);
        }
    }
}
