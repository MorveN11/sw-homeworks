using Project.Business.DTOs.Student;
using WebApp.Entity;
using AutoMapper;

namespace WebApp.Business
{
    public class UniversityProfile : Profile
    {
        public UniversityProfile()
        {
            CreateMap<Student, StudentDTO>();
            CreateMap<Career, CareerDTO>();

            CreateMap<StudentDTO, Student>();
            CreateMap<CareerDTO, Career>();
        }
    }
}
