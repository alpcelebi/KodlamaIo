// InstructorData.cs
public class InstructorData : IDataService<Instructor>
{
    private List<Instructor> _instructors;

    public InstructorData()
    {
        _instructors = new List<Instructor>
        {
            new Instructor { InstructorId = 1, Name = "Engin DEMİROĞ" }
           
        };
    }

    public List<Instructor> GetAll()
    {
        return _instructors.ToList();
    }

    public Instructor GetById(int id)
    {
        return _instructors.FirstOrDefault(instructor => instructor.InstructorId == id);
    }

    public void Add(Instructor entity)
    {
        _instructors.Add(entity);
    }

    public void Update(Instructor entity)
    {
        Instructor existingInstructor = GetById(entity.InstructorId);
        if (existingInstructor != null)
        {
            existingInstructor.Name = entity.Name;
           
        }
    }

    public void Delete(int id)
    {
        Instructor instructor = GetById(id);
        if (instructor != null)
        {
            _instructors.Remove(instructor);
        }
    }
}
