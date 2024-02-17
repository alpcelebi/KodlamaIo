
public class InstructorValidation : IValidationService<Instructor>
{
    
    public bool Validate(Instructor entity)
    {
        if (entity==null)
        {
            return false;

        }

        return true;
    }
}
