using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebApp.Business.Validator.Concretes;
using WebApp.Context;
using WebApp.Entity;
using Project.Business.DTOs.Student;
using WebApp.Business.Careers;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("Project.Api/[controller]")]
    public class CareerController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly CareerValidator _careerValidator;
        private readonly MyDBContext _dbContext;

        public CareerController(MyDBContext dbContext, IMediator mediator, IMapper mapper, CareerValidator careerValidator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
            _mapper = mapper;
            _careerValidator = careerValidator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCareers()
        {
            var careers = await _dbContext.Careers.ToListAsync();
            return Ok(careers);
        }

        [HttpGet("{careerId}")]
        public async Task<IActionResult> GetCareertById([Required] Guid careerId)
        {
            var contract = new GetCareerByIDRequest(careerId);

            var Career = await _mediator.Send(contract);
            return Ok(Career);
        }

        [HttpGet(), Route("Students/{careerId}")]
        public async Task<IActionResult> GetCareerStudents([Required] Guid careerId)
        {
            var contract = new GetCareersStudentsRequest(careerId);

            var model = await _mediator.Send(contract);
            var students = _mapper.Map<IList<StudentDTO>>(model);
            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Career careerDTO)
        {
            var validationResult = await _careerValidator.ValidateAsync(careerDTO);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var Career = _mapper.Map<Career>(careerDTO);
            var command = new CreateCareerRequest(Career);
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpPut("{careerId}")]
        public async Task<IActionResult> Put([Required] Guid careerId, [FromBody] Career careerDTO)
        {
            var validationResult = await _careerValidator.ValidateAsync(careerDTO);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var Career = _mapper.Map<Career>(careerDTO);
            var command = new UpdateCareerRequest(Career);
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpDelete("{careerId}")]
        public async Task<IActionResult> Delete([Required] Guid careerId)
        {
            var command = new DeleteCareerRequest(careerId);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}