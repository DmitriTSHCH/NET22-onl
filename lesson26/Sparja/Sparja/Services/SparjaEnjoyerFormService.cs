using Sparja.Interfaces;
using Sparja.Models;
using Sparja.Persistance.Interfaces;

namespace Sparja.Services
{
    public class SparjaEnjoyerFormService : ISparjaEnjoyerFormService
    {
        private readonly ISparjaEnjoyerFormRepository _repository;
        public SparjaEnjoyerFormService(ISparjaEnjoyerFormRepository repository)
        { 
            _repository = repository;
        }
        public List<SparjaEnjoyerForm>? Get()
        {
            return _repository.Get();
        }
        public void MealSparja(SparjaEnjoyerForm user)
        {
            if (!_repository.CheckAvailability(user))
            { 
                _repository.Add(user);
            }
            _repository.MealSparja(user);
        }
    }
}
