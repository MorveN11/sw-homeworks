using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Business.DTOs.Student;
using Project.Business.Students;

[ApiController]
[Route("Project.Api/[controller]")]
public class StudentController: ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    
    public StudentController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
    
   [HttpGet] 
   public async Task<IActionResult> GetStudents()
   {
        /*var i = 0;
        var j = 0;
        var x = i / j;*/
        // throw new TestException();
        var response = new List<Student>
        {
            new Student
            {
                Name = "Gustavo",
                LastName = "Gonzales",
                BirthDate = new DateTime(2003, 01, 01),
                Id = Guid.NewGuid()
            }
        };
        return Ok(response); 
   }
    
   [HttpGet("{studentId}")]
   public async Task<IActionResult> GetStudentById([Required]Guid studentId)
   {
       var contract = new GetStudentById(studentId);
       
       var student = await _mediator.Send(contract);
       return Ok(student);
   }

   [HttpGet(), Route("careers/{studentId}")]
   public async Task<IActionResult> GetStudentCarers([Required] Guid studentId)
   {
       var contract = new GetStudentCareer(studentId);

       var model = await _mediator.Send(contract);
       var careers = _mapper.Map<IList<CareerDTO>>(model); 
       return Ok(careers);
   }

   [HttpPost()]
   public async Task<IActionResult> Post([Required] Student student)
   {
    Console.WriteLine(student.ToString());
       var command = new CreateStudentRequest(student);
       var result = await _mediator.Send(command);
       return Ok(result);
   }
   
   [HttpPut("{student}")]
   public async Task<IActionResult> Put([Required] Student student)
   {
       var command = new UpdateStudentRequest(student);
       var result = await _mediator.Send(command);
       return Ok(result);
   }
   
   [HttpDelete("{studentId}")]
   public async Task<IActionResult> Delete([Required] Guid studentId)
   {
       var command = new DeleteStudentRequest(studentId);
       var result = await _mediator.Send(command);
       return Ok(result);
   }
   
} 