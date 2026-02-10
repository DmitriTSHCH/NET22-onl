namespace LibraryDb.Models
{
    public class AuthorBiography
    {
        public int Id { get; set; }
        public string Education { get; set; }
        public string Awards { get; set; }
        public string BiographyText { get; set; }
        public int AuthorId { get; set; }
    }
}
string Education, string Awards, string BiographyText, int AuthorId