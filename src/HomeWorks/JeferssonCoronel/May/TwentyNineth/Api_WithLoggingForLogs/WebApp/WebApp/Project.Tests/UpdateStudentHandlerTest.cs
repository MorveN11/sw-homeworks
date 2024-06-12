using Moq;
using Project.Business.Students;
using WebApp.Entity;
using Xunit;

namespace WebApp.Project.Tests
{
    public class UpdateStudentHandlerTest
    {
        [Fact]
        public async Task Handle_ValidRequest_UpdatesStudent()
        {
            // Arrange
            var mockRepository = new Mock<IStudentRepository>();
            var student = new Student
            {
                Id = Guid.NewGuid(),
                Name = "Jane",
                LastName = "Doe",
                BirthDate = new DateTime(2000, 1, 1),
                Careers = new List<Career>()
            };

            var request = new UpdateStudentRequest(student);    

            mockRepository.Setup(repo => repo.Update(student)).ReturnsAsync(1);

            var handler = new UpdateStudentHandler(mockRepository.Object);

            // Act
            var result = await handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.Equal(1, result);
            mockRepository.Verify(repo => repo.Update(student), Times.Once);
        }

      
    }
}
