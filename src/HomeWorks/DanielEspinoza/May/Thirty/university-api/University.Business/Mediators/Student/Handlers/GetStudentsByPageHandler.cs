using AutoMapper;
using MediatR;
using University.Business.Wrappers;
using University.Domain;

namespace University.Business.Mediators
{
    public class GetStudentByPageHandler : IRequestHandler<GetByPage<Student>, Pagination<Student>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentByPageHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Pagination<Student>> Handle(GetByPage<Student> request, CancellationToken cancellationToken)
        {

            var students = await _studentRepository.GetByPage(s => true, request.PageNumber, request.PageSize);
            return new Pagination<Student>(request.PageNumber, request.PageSize, students);
        }
    }
}
