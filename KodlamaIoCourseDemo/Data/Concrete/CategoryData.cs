// CategoryData.cs
public class CategoryData : IDataService<Category>
{
    private List<Category> _categories;

    public CategoryData()
    {
        _categories = new List<Category>
        {
            new Category { CategoryId = 1, Name = "Web Corse" },
            new Category { CategoryId = 2, Name = "Mobile Course" },
               new Category { CategoryId = 3, Name = "Machine Learning Corse" },
            new Category { CategoryId = 4, Name = "Test Engeneer Course" }

        };
    }

    public List<Category> GetAll()
    {
        return _categories.ToList();
    }

    public Category GetById(int id)
    {
        return _categories.FirstOrDefault(category => category.CategoryId == id);
    }

    public void Add(Category entity)
    {
        _categories.Add(entity);
    }

    public void Update(Category entity)
    {
        Category existingCategory = GetById(entity.CategoryId);
        if (existingCategory != null)
        {
            existingCategory.Name = entity.Name;
            
        }
    }

    public void Delete(int id)
    {
        Category category = GetById(id);
        if (category != null)
        {
            _categories.Remove(category);
        }
    }
}
