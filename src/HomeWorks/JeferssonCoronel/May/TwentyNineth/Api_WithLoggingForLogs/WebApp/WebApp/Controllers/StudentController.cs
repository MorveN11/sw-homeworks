using Microsoft.AspNetCore.Mvc;
using WebApp.Context;
using WebApp.Core.Excepciones.Business;
using WebApp.Core.Handler;
using WebApp.Entity;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private MyDBContext _dbContext;

        private readonly LogHandler _logHandler;

        public StudentController(MyDBContext dbContext, LogHandler logHandler)
        {
            _dbContext = dbContext;
            _logHandler = logHandler;
        }

        [HttpGet]
       public async Task<IActionResult> GetStudents()
        {
            //var i = 0;
            //var j = 0;
            //var x = i / j;
            //throw new TestException();

            try
            {
                // Simular una situación que provoque la excepción
                throw new BusinessException("Hubo un error al obtener la lista de estudiantes.", _logHandler);
            }
            catch (BusinessException ex)
            {
                ex.LogMessage(); // Registra la excepción
                return StatusCode(500, "Se produjo un error en el servidor."); // Devuelve un código de estado 500
            }

            var response = new List<Student> 
            {
                new Student
                {
                    Name = "Andre",
                    LastName = "Perez",
                    Birthdate = new DateTime(2003, 12, 10),
                    Id = Guid.NewGuid()
                }
            };
            return Ok(response);
        }


       // [HttpGet]
       // public IEnumerable<Student> GetStudents() => _dbContext.Students.ToList();

    }
}
