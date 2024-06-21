using MediatR;
using University.API;

namespace University.Test;

public class UnitTest1
{
    private readonly StudentController _studentController;
    private readonly IMediator _mediator;

    public UnitTest1()
    {
        _studentController = new StudentController(_mediator);
    }

    [Fact]
    public void GetUserById()
    {

        var result = _studentController.GetStudentById(Guid.Parse("00000000-0000-0000-0000-000000000001"));
    }
}