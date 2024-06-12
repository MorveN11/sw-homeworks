using Moq;
using Project.Business.Students;
using WebApp.Entity;
using Xunit;

namespace WebApp.Project.Tests
{
    public class GetStudentByIdHandlerTest
    {
        [Fact]
        public async Task Handle_ValidRequest_ReturnsStudent()
        {
            // Arrange
            var mockRepository = new Mock<IStudentRepository>();
            var studentId = Guid.NewGuid();
            var student = new Student
            {
                Id = studentId,
                Name = "Jane",
                LastName = "Doe",
                BirthDate = new DateTime(2000, 1, 1),
                Careers = new List<Career>()
            };

            var request = new GetStudentByIdRequest(studentId);

            mockRepository.Setup(repo => repo.GetById(studentId)).ReturnsAsync(student);

            var handler = new GetStudentByIdHandler(mockRepository.Object);

            // Act
            var result = await handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.Equal(student, result);
            mockRepository.Verify(repo => repo.GetById(studentId), Times.Once);
        }

        [Fact]
        public async Task Handle_InvalidStudentId_ReturnsNull()
        {
            // Arrange
            var mockRepository = new Mock<IStudentRepository>();
            var studentId = Guid.NewGuid();
            var request = new GetStudentByIdRequest(studentId);    

            mockRepository.Setup(repo => repo.GetById(studentId)).ReturnsAsync((Student)null);

            var handler = new GetStudentByIdHandler(mockRepository.Object);

            // Act
            var result = await handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.Null(result);
            mockRepository.Verify(repo => repo.GetById(studentId), Times.Once);
        }
    }
}