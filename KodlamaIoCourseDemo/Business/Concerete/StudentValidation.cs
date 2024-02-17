
public class StudentValidation : IValidationService<Student>
{
    public bool Validate(Student entity)
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
