using AutoMapper;
using MediatR;
using University.Domain;

namespace University.Business.Mediators;


public class GetStudentByIdHandler : IRequestHandler<GetById<Student>, Student?>
{
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;
    public GetStudentByIdHandler(IStudentRepository studentRepository,IMapper mapper)
    {
        _studentRepository = studentRepository;
        _mapper = mapper;
    }

    public async Task<Student?> Handle(GetById<Student> request, CancellationToken cancellationToken)
    {
        Task<Student?> task =  _studentRepository.GetById(request.EntityId);

        return  await Task.FromResult(task.Result);
    }

}