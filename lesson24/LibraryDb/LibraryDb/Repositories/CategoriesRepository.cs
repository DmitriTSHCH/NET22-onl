using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryDb.Repositories
{
    public class CategoriesRepository
    {
        private readonly LibraryDbContext _dbContext;
        public CategoriesRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(int _id, string _name, string _description)
        {
            var category = new Category
            {
                Id = _id,
                Name = _name,
                Description = _description
            };
            _dbContext.Add(category);
            _dbContext.SaveChanges();
        }

        public void Update(int _id, string _name, string _description)
        {
            _dbContext.Categories
                .Where(e => e.Id == _id)
                .ExecuteUpdate(e => e
                .SetProperty(e => e.Name, _name)
                .SetProperty(e => e.Description, _description)
                );
        }

        public void Delete(int _id)
        {
            _dbContext.Categories
                .Where(e => e.Id == _id)
                .ExecuteDelete();
        }
    }
}
