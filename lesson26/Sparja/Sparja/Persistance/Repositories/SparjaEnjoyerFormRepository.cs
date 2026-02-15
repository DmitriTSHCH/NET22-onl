using Sparja.Models;
using Microsoft.EntityFrameworkCore;

namespace Sparja.Persistance.Interfaces
{
    public class SparjaEnjoyerFormRepository : ISparjaEnjoyerFormRepository
    {
        private readonly SparjaDbContext _dbContext;

        public SparjaEnjoyerFormRepository(SparjaDbContext context)
        {
            _dbContext = context;
        }

        public List<SparjaEnjoyerForm> Get()
        {
            return _dbContext.SparjaEnjoyerForms
                .AsNoTracking()
                .ToList();
        }
        public SparjaEnjoyerForm? GetById(Guid Id)
        {
            return _dbContext.SparjaEnjoyerForms
                .AsNoTracking()
                .FirstOrDefault(e => e.Id == Id);
        }
        public SparjaEnjoyerForm? GetByEmail(string Email)
        {
            return _dbContext.SparjaEnjoyerForms
                .AsNoTracking()
                .FirstOrDefault(e => e.Email == Email);
        }

        public void Add(SparjaEnjoyerForm user)
        {
            _dbContext.Add(user);
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                
            }
        }

        public void MealSparja(SparjaEnjoyerForm user)
        {
             _dbContext.SparjaEnjoyerForms
                 .Where(e => e.Email == user.Email)
                 .ExecuteUpdate(e => e
                     .SetProperty(e => e.MealSparjaCount, e => e.MealSparjaCount + 1)
                 );
        }

        public bool CheckAvailability(SparjaEnjoyerForm user)
        {
            return _dbContext.SparjaEnjoyerForms.Any(e => e.Email == user.Email);
        }
    }
}
