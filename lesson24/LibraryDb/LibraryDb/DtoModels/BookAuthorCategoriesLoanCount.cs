namespace LibraryDb.DtoModels
{
    public class BookAuthorCategoriesLoanCount
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public Dictionary<string, DateOnly> CategoriesAddedDatePair { get; set; }
        public int LoanCount { get; set; }
    }
}
