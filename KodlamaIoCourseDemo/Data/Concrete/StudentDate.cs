// StudentData.cs
public class StudentData : IDataService<Student>
{
    private List<Student> _students;

    public StudentData()
    {
        _students = new List<Student>
        {
            new Student { StudentId = 1, Name = "Alp Eren ÇELEBİ" },
            new Student { StudentId = 2, Name = "Yagız Alp ÇELEBİ" },
             new Student { StudentId = 2, Name = "Tuğçe ÇELEBİ" }
            
        };
    }

    public List<Student> GetAll()
    {
        return _students.ToList();
    }

    public Student GetById(int id)
    {
        return _students.FirstOrDefault(student => student.StudentId == id);
    }

    public void Add(Student entity)
    {
        _students.Add(entity);
    }

    public void Update(Student entity)
    {
        Student existingStudent = GetById(entity.StudentId);
        if (existingStudent != null)
        {
            existingStudent.Name = entity.Name;
            
        }
    }

    public void Delete(int id)
    {
        Student student = GetById(id);
        if (student != null)
        {
            _students.Remove(student);
        }
    }
}
