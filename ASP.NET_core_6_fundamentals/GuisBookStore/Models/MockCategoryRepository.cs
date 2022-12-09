namespace GuisBookStore.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {        
        public IEnumerable<Category> AllGetCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Scientific fiction books", Description="All scientific fiction books"},
                new Category{CategoryId=2, CategoryName="History books", Description="All history books"},
                new Category{CategoryId=3, CategoryName="Philosophy books", Description="Philosophers everywhere"}
            };

        public IEnumerable<Category> AllCategories => throw new NotImplementedException();
    }
}
