using Moq;
using Project.Business.Students;
using WebApp.Entity;
using Xunit;

namespace WebApp.Project.Tests
{
    public class CreateStudentHandlerTest
    {
        [Fact]
        public async Task Handle_ValidRequest_CreatesStudent()
        {
            // Arrange
            var mockRepository = new Mock<IStudentRepository>();
            var student = new Student
            {
                Id = Guid.NewGuid(),
                Name = "John",
                LastName = "Doe",
                BirthDate = new DateTime(2000, 1, 1),
                Careers = new List<Career>()
            };

            var request = new CreateStudentRequest(student);

            mockRepository.Setup(repo => repo.Create(student)).ReturnsAsync(1);

            var handler = new CreateStudentHandler(mockRepository.Object);

            // Act
            var result = await handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.Equal(1, result);
            mockRepository.Verify(repo => repo.Create(student), Times.Once);
        }
    }
}
