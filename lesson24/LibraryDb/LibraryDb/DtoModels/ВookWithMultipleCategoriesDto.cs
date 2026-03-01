namespace LibraryDb.DtoModels
{
    public class ВookWithMultipleCategoriesDto
    {
        public string Title { get; set; }
        public Dictionary<string, DateOnly> CategoriesAddedDatePair { get; set; }
    }
}
