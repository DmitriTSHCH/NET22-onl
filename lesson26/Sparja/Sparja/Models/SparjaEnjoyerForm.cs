namespace Sparja.Models
{
    public class SparjaEnjoyerForm
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int? MealSparjaCount { get; set; }
        //public List<DateTime> MealDateTimeLast { get; set; }
    }
}
