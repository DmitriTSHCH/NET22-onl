using LibraryDb.Models;

namespace LibraryDb.Interfaces
{
    public interface IBookService
    {
        public void Add(int _id, string _title, string _ISBN, DateOnly _publicationYear, float _price, int _authorId, int _publisherId);
        public void Update(int _id, string _title, string _ISBN, DateOnly _publicationYear, float _price, int _authorId, int _publisherId);
        public void Delete(int _id);

    }
}
