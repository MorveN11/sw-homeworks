using System.ComponentModel.DataAnnotations;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Business.DTOs.Student;
using Project.Business.Students;
using WebApp.Business.Validator.Concretes;
using WebApp.Context;
using WebApp.Entity;

[ApiController]
[Route("Project.Api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    private readonly StudentValidator _studentValidator;
    private readonly MyDBContext _dbContext;

    public StudentController(MyDBContext dbContext, IMediator mediator, IMapper mapper, StudentValidator studentValidator)
    {
        _dbContext = dbContext;
        _mediator = mediator;
        _mapper = mapper;
        _studentValidator = studentValidator;
    }

    [HttpGet]
    public async Task<IActionResult> GetStudents()
    {
        var students = await _dbContext.Students.ToListAsync();
        return Ok(students);
    }

    /*public async Task<IActionResult> GetStudents()
    {
        var i = 0;
        var j = 0;
        var x = i / j;
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
    }*/

    [HttpGet("{studentId}")]
    public async Task<IActionResult> GetStudentById([Required] Guid studentId)
    {
        var contract = new GetStudentByIdRequest(studentId);

        var student = await _mediator.Send(contract);
        return Ok(student);
    }

    [HttpPost("CareerCode")]
    public async Task<IActionResult> RegisterStudentToCareer([Required] Student student, [Required] string careerCode)
    {

    }


    [HttpGet(), Route("Careers/{studentId}")]
    public async Task<IActionResult> GetStudentCarers([Required] Guid studentId)
    {
        var contract = new GetStudentCareerRequest(studentId);

        var model = await _mediator.Send(contract);
        var careers = _mapper.Map<IList<CareerDTO>>(model);
        return Ok(careers);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Student studentDTO)
    {
        var validationResult = await _studentValidator.ValidateAsync(studentDTO);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }

        var student = _mapper.Map<Student>(studentDTO);
        var command = new CreateStudentRequest(student);
        var result = await _mediator.Send(command);
        return Ok(result);
    }


    [HttpPut("{studentId}")]
    public async Task<IActionResult> Put([Required] Guid studentId, [FromBody] Student studentDTO)
    {
        var validationResult = await _studentValidator.ValidateAsync(studentDTO);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }

        var student = _mapper.Map<Student>(studentDTO);
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