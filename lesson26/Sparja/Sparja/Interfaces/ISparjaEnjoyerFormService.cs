using Sparja.Models;

namespace Sparja.Interfaces
{
    public interface ISparjaEnjoyerFormService
    {
        public List<SparjaEnjoyerForm>? Get();
        public void MealSparja(SparjaEnjoyerForm user);
    }
}
