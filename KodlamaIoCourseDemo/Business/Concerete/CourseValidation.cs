
public class CourseValidation : IValidationService<Course>
{
    public bool Validate(Course entity)
    {
        if (entity == null)
        {
           
            return false;
        }

     

   
        if (entity.Category == null)
        {
            // Kursun kategori bilgisi null ise geçerli değil.
            return false;
        }

       
        return true;
    }
}
