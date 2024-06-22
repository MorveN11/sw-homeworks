using AutoMapper;
using University.Domain;
using University.Business.Dtos;
using University.Business.Wrappers;
namespace University.Business;

public class UniversityProfile : Profile 
{
	public UniversityProfile()
	{
		CreateMap<Student , StudentDto>().ReverseMap();
		CreateMap<Career,CareerDto>().ReverseMap();
		CreateMap<Pagination<Student>,Pagination<StudentDto>>().ReverseMap();
		CreateMap<Pagination<Career>,Pagination<CareerDto>>().ReverseMap();
	}
}
