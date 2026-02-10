using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryDb.Repositories
{
    public class PublishersRepository
    {
        private readonly LibraryDbContext _dbContext;
        public PublishersRepository(LibraryDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public void Add(int _id, string _name, string _address, string _website)
        {
            var publisher = new Publisher
            { 
                Id = _id,
                Name = _name,
                Address = _address,
                Website = _website
            };
            _dbContext.Add(publisher);
            _dbContext.SaveChanges();
        }

        public void Update(int _id, string _name, string _address, string _website)
        {
            _dbContext.Publishers
                .Where(e => e.Id == _id)
                .ExecuteUpdate(e => e
                .SetProperty(e => e.Name, _name)
                .SetProperty(e => e.Address, _address)
                .SetProperty(e => e.Website, _website)
                );
        }

        public void Delete(int _id)
        {
            _dbContext.Publishers
                .Where(e => e.Id == _id)
                .ExecuteDelete();
        }
    }
}
