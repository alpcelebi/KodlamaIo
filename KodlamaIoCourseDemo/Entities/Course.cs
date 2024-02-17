
public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();
    public List<Instructor> Instructors { get; set; } = new List<Instructor>();
    public Category Category { get; set; }

}
