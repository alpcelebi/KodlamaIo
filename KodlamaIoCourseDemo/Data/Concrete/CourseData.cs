// CourseData.cs
public class CourseData : IDataService<Course>
{
    private List<Course> _courses;

    public CourseData()
    {
        _courses = new List<Course>
        {
            new Course
            {
                CourseId = 1,
                Title = "C#",
                Category = new Category { CategoryId = 1, Name = "Web Course" },
                Students = new List<Student>
                {
                    new Student { StudentId = 1, Name = "Tuğçe ÇELEBİ" },
                    new Student { StudentId = 2, Name = "Alp Eren ÇELEBİ" },
                    new Student { StudentId = 3, Name = "Yağız Alp ÇELEBİ" }
                },
                Instructors = new List<Instructor>
                {
                    new Instructor { InstructorId = 1, Name = "Engin DEMİROĞ" }
                   
                }
            },
            new Course
            {
                CourseId = 2,
                Title = "Java",
                Category = new Category { CategoryId = 2, Name = "Mobile Course" },
                Students = new List<Student>
                {
                   new Student { StudentId = 1, Name = "Tuğçe ÇELEBİ" },
                    new Student { StudentId = 2, Name = "Alp Eren ÇELEBİ" },
                    new Student { StudentId = 3, Name = "Yağız Alp ÇELEBİ" }
                },
                Instructors = new List<Instructor>
                {
                  new Instructor { InstructorId = 1, Name = "Engin DEMİROĞ" }
                }
            },

              new Course
            {
                CourseId = 3,
                Title = "Phyton",
                Category = new Category { CategoryId = 3, Name = "Machine Learning Corse" },
                Students = new List<Student>
                {
                    new Student { StudentId = 1, Name = "Tuğçe ÇELEBİ" },
                    new Student { StudentId = 2, Name = "Alp Eren ÇELEBİ" },
                    new Student { StudentId = 3, Name = "Yağız Alp ÇELEBİ" }
                  
                    // Öğrenci listesini dilediğiniz gibi genişletebilirsiniz.
                },
                Instructors = new List<Instructor>
                {
                    new Instructor { InstructorId = 1, Name = "Engin DEMİROĞ" }
                  
                }
            },
            new Course
            {
                CourseId = 4,
                Title = "Javascript",
                Category = new Category { CategoryId = 4, Name = "Test Engeneer Course" },
                Students = new List<Student>
                {
                    new Student { StudentId = 1, Name = "Tuğçe ÇELEBİ" },
                    new Student { StudentId = 2, Name = "Alp Eren ÇELEBİ" },
                    new Student { StudentId = 3, Name = "Yağız Alp ÇELEBİ" }
                },
                Instructors = new List<Instructor>
                {
                    new Instructor { InstructorId = 2, Name = "Engin DEMİROĞ" }
                    
                }
            },

        };
    }

    public List<Course> GetAll()
    {
        return _courses.ToList();
    }

    public Course GetById(int id)
    {
        return _courses.FirstOrDefault(course => course.CourseId == id);
    }

    public void Add(Course entity)
    {
        _courses.Add(entity);
    }

    public void Update(Course entity)
    {
        Course existingCourse = GetById(entity.CourseId);
        if (existingCourse != null)
        {
            existingCourse.Students = entity.Students;
            existingCourse.Category = entity.Category;
            existingCourse.Instructors = entity.Instructors;

        }
    }

    public void Delete(int id)
    {
        Course course = GetById(id);
        if (course != null)
        {
            _courses.Remove(course);
        }
    }
}
