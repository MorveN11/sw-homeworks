using AutoMapper;
using System.ComponentModel.DataAnnotations;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using University.Business.Dtos;
using University.Business.Mediators;
using University.Business.Students;
using University.Domain;
using University.Business.Wrappers;
using University.Business.Validators;
using Microsoft.VisualBasic;

namespace University.API;

[ApiController]
[Route("api/[controller]")]
public class CareerController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    private readonly CareerDtoValidator _validator;
    public CareerController(IMediator mediator, IMapper mapper, CareerDtoValidator validator)
    {
        _mediator = mediator;
        _mapper = mapper;
        _validator = validator;
    }

    [HttpGet(), Route("page/{pageNumber}/{pageSize}")]
    public async Task<IActionResult> GetCareersByPage([Required] int pageNumber, [Required] int pageSize)
    {
        var result = await _mediator.Send(new GetByPage<Career>(pageNumber, pageSize));
        var careerRes = _mapper.Map<Pagination<Career>, Pagination<CareerDto>>(result);
        return Ok(careerRes);
    }

    [HttpGet("{careerId}")]
    public async Task<IActionResult> GetCareerById([Required] Guid careerId)
    {
        var contract = new GetById<Career>(careerId);
        var student = await _mediator.Send(contract);
        CareerDto careerDto = _mapper.Map<Career, CareerDto>(student);
        if (careerDto is null)
        {
            return NotFound();
        }
        return Ok(careerDto);
    }

    [HttpPut(), Route("careers/{careerId}/{studentId}")]
    public async Task<IActionResult> RegisterStudentInCareer([Required] Guid careerId, [Required] Guid studentId)
    {
        var res = await _mediator.Send(new RegisterStudentInCareer(careerId, studentId));
        return Ok(res);
    }


    [HttpPost("")]
    public async Task<IActionResult> Post([Required] CareerDto careerDto)
    {
        var res = _validator.Validate(careerDto);
        if (res.IsValid)
        {
            return BadRequest(res.Errors);
        }
        Career career = _mapper.Map<CareerDto, Career>(careerDto);
        Guid result = await _mediator.Send(new CreateCareer(career));

        if (result == Guid.Empty)
        {
            return BadRequest();
        }
        return Ok(result);
    }

    [HttpPut("")]
    public async Task<IActionResult> Put([Required] CareerDto careerDto)
    {
        var res = _validator.Validate(careerDto);
        if (res.IsValid)
        {
            return BadRequest(res.Errors);
        }
        var career = _mapper.Map<CareerDto, Career>(careerDto);
        var result = await _mediator.Send(new UpdateCareer(career));
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


