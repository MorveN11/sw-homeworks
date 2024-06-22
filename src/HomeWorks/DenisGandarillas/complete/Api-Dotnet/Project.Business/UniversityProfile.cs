using AutoMapper;
using Project.Business.DTOs.Student;

namespace Project.Business;

public class UniversityProfile : Profile
{
    public UniversityProfile()
    {
        CreateMap<Student, StudentDTO>();
        CreateMap<Career, CareerDTO>();
    }
}