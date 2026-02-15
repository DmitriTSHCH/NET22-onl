using Microsoft.EntityFrameworkCore;
using Sparja.Models;

namespace Sparja.Persistance.Interfaces
{
    public interface ISparjaEnjoyerFormRepository
    {
        public List<SparjaEnjoyerForm> Get();
        public SparjaEnjoyerForm? GetById(Guid Id);
        public SparjaEnjoyerForm? GetByEmail(string Email);
        public void Add(SparjaEnjoyerForm user);
        public void MealSparja(SparjaEnjoyerForm user);
        public bool CheckAvailability(SparjaEnjoyerForm user);
    }
}
