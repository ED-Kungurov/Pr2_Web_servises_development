using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase{
    private static List<Student> students = new(){
        new Student { Id = 1, Name = "Alex", Group = "SE-301" },
        new Student { Id = 2, Name = "Anna", Group = "SE-302" },
        new Student { Id = 3, Name = "Max", Group = "SE-301" }
    };
    [HttpGet]
    public ActionResult<List<Student>> Get(){
        return Ok(students);
    }
    [HttpGet("{id}")]
    public ActionResult<Student> GetById(int id){
        foreach (Student i in students){
            if(i.Id == id){
                return Ok(i);
            }
        }
        return NotFound("Не нашлось");
    }
    [HttpPost]
    public ActionResult<Student> addNew(Student st)
    {
        students.Add(st);
        return Ok(st);
    }
}
