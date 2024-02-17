
public class BusinessManager
{
    private readonly IDataService<Student> studentDataService;
    private readonly IValidationService<Student> studentValidationService;

    private readonly IDataService<Instructor> instructorDataService;
    private readonly IValidationService<Instructor> instructorValidationService;

    private readonly IDataService<Course> courseDataService;
    private readonly IValidationService<Course> courseValidationService;

    private readonly IDataService<Category> categoryDataService;
    private readonly IValidationService<Category> categoryValidationService;

    public BusinessManager(
        IDataService<Student> studentDataService,
        IValidationService<Student> studentValidationService,
        IDataService<Instructor> instructorDataService,
        IValidationService<Instructor> instructorValidationService,
        IDataService<Course> courseDataService,
        IValidationService<Course> courseValidationService,
        IDataService<Category> categoryDataService,
        IValidationService<Category> categoryValidationService)
    {
        this.studentDataService = studentDataService;
        this.studentValidationService = studentValidationService;

        this.instructorDataService = instructorDataService;
        this.instructorValidationService = instructorValidationService;

        this.courseDataService = courseDataService;
        this.courseValidationService = courseValidationService;

        this.categoryDataService = categoryDataService;
        this.categoryValidationService = categoryValidationService;
    }


}