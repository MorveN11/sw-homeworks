using MediatR;
using Project.Business.Students;
using WebApp.Entity;
using WebApp.Repositories.Interfaces;

namespace WebApp.Business.Careers
{
    public class GetCareersStudentsHandler : IRequestHandler<GetCareersStudentsRequest, IList<Student>>
    {
        private readonly ICareerRepository _repository;

        public GetCareersStudentsHandler(ICareerRepository repository)
        {
            _repository = repository;
        }

        public async Task<IList<Student>> Handle(GetCareersStudentsRequest request, CancellationToken cancellationToken)
        {
            var students = await _repository.GetStudents(request.IdCareer);
            return students;
        }
    }
}