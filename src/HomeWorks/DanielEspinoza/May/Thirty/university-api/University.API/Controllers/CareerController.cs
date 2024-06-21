using AutoMapper;
using System.ComponentModel.DataAnnotations;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using University.Business.Dtos;
using University.Business.Mediators;
using University.Business.Students;
using University.Domain;

namespace University.API;

[ApiController]
[Route("api/[controller]")]
public class CareerController:ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public CareerController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

   [HttpGet(), Route("page/{pageNumber}/{pageSize}")]
   public async Task<IActionResult> GetCareersByPage([Required] int pageNumber, [Required] int pageSize)
   {
        var result = await _mediator.Send( new GetByPage<Career>(pageNumber,pageSize));
        var careerRes = _mapper.Map<Pagination<Career>, Pagination<CareerDto>>(result);
        return Ok(careerRes);
   }
     
   [HttpGet("{careerId}")]
   public async Task<IActionResult> GetCareerById([Required]Guid careerId)
   {
       var contract = new GetById<Career>(careerId);
       var student = await _mediator.Send(contract);
       CareerDto  careerDto= _mapper.Map<Career, CareerDto>(student);
       if (careerDto is null)
       {
           return NotFound();
       }
       return Ok(careerDto);
   }

   [HttpPut(), Route("careers/{careerId}/{studentId}")]
   public async Task<IActionResult> RegisterStudentInCareer([Required] Guid careerId, [Required] Guid studentId)
   {
       
       var res = await _mediator.Send(new RegisterStudentInCareer(careerId,studentId));
       var students = _mapper.Map<IList<Student>, IList<StudentDto>>(res);
       if (!students)
       {
           return BadRequest();
       }
       return Ok(students);
   }


   [HttpPost("")]
   public async Task<IActionResult> Post([Required] CareerDto careerDto)
   {
       Career career=  _mapper.Map<CareerDto, Career>(careerDto);
       Guid result = await _mediator.Send(new CreateCareer(career));

        if (result == Guid.Empty){
            return BadRequest();
        }
        return Ok(result);
   }

   [HttpPut("")]
   public async Task<IActionResult> Put([Required] Career Career)
   {
       var result = await _mediator.Send(new UpdateCareer(Career));
       if (!result)
       {
           return BadRequest();
       }
       return Ok(result);
   }
   
   [HttpDelete("{careerId}")]
   public async Task<IActionResult> Delete([Required] Guid careerId)
   {
       var result = await _mediator.Send(new DeleteCareer(careerId));
       if (!result)
       {
           return BadRequest();
       }
       return Ok(result);
   }
   
}


