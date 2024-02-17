// CategoryValidation.cs
public class CategoryValidation : IValidationService<Category>
{
    public bool Validate(Category entity)
    {
        if (entity == null)
        {
            
            return false;
        }

        if (string.IsNullOrWhiteSpace(entity.Name))
        {
          
            return false;
        }

        
        return true;
    }
}
