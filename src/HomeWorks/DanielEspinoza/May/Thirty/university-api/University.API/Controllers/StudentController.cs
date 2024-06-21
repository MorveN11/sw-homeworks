using AutoMapper;
using System.ComponentModel.DataAnnotations;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using University.Business.Dtos;
using University.Business.Mediators;
using University.Business.Students;
using University.Domain;
using University.Business.Wrappers;
namespace University.API;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{

    private readonly IMediator _mediator;

    private readonly IMapper _mapper;

    public StudentController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }


    [HttpGet(), Route("page/{pageNumber}/{pageSize}")]
    public async Task<IActionResult> GetStudentsByPage([Required] int pageNumber, [Required] int pageSize)
    {
        var result = await _mediator.Send(new GetByPage<Student>(pageNumber, pageSize));
        
        var estudentRes = _mapper.Map<Pagination<Student>, Pagination<StudentDto>>(result);
        return Ok(estudentRes);
    }

    [HttpGet("{studentId}")]
    public async Task<IActionResult> GetStudentById([Required] Guid studentId)
    {
        var contract = new GetById<Student>(studentId);

        var res = await _mediator.Send(contract);
        var student = _mapper.Map<Student, StudentDto>(res);

        if (student is null)
        {
            return NotFound("Student not found");
        }

        return Ok(student);
    }

    [HttpGet(), Route("careers/{studentId}")]
    public async Task<IActionResult> GetStudentCarers([Required] Guid studentId)
    {

        var result = await _mediator.Send(new GetStudentCareers(studentId));
        if (result is null)
        {
            return NotFound("Student not found");
        }
        var careers = _mapper.Map<IEnumerable<Career>, IEnumerable<CareerDto>>(result);
        return Ok(careers);
    

    }


    [HttpPost("")]
    public async Task<IActionResult> Post([Required] StudentDto studentDto)
    {
        Student student = _mapper.Map<StudentDto, Student>(studentDto);
        Guid result = await _mediator.Send(new CreateStudent(student));

        if (result == Guid.Empty)
        {
            return BadRequest("Student not created");
        }
        return Ok(result);
    }

    [HttpPut("")]
    public async Task<IActionResult> Put([Required] StudentDto studentDto)
    {
        Student student = _mapper.Map<StudentDto, Student>(studentDto);
        var result = await _mediator.Send(new UpdateStudent(student));

        return Ok(result);
    }

    [HttpDelete("{studentId}")]
    public async Task<IActionResult> Delete([Required] Guid studentId)
    {
        var result = await _mediator.Send(new DeleteStudent(studentId));
        return Ok(result);
    }

}


