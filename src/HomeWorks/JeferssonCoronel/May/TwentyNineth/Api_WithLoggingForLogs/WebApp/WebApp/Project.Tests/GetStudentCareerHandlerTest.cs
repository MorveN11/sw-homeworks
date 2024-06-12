using Moq;
using Project.Business.Students;
using WebApp.Entity;
using Xunit;

namespace WebApp.Project.Tests
{
    public class GetStudentCareerHandlerTest
    {
        [Fact]
        public async Task Handle_ValidRequest_ReturnsCareers()
        {
            // Arrange
            var mockRepository = new Mock<IStudentRepository>();
            var studentId = Guid.NewGuid();
            var careers = new List<Career>
            {
                new Career { Id = Guid.NewGuid(), Name = "Computer Science" },
                new Career { Id = Guid.NewGuid(), Name = "Mathematics" }
            };

            var request = new GetStudentCareerRequest(studentId);

            mockRepository.Setup(repo => repo.GetCareers(studentId)).ReturnsAsync(careers);

            var handler = new GetStudentCareerHandler(mockRepository.Object);

            // Act
            var result = await handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.Equal(careers, result);
            mockRepository.Verify(repo => repo.GetCareers(studentId), Times.Once);
        }

        [Fact]
        public async Task Handle_InvalidStudentId_ReturnsEmptyList()
        {
            // Arrange
            var mockRepository = new Mock<IStudentRepository>();
            var studentId = Guid.NewGuid();
            var request = new GetStudentCareerRequest(studentId);

            mockRepository.Setup(repo => repo.GetCareers(studentId)).ReturnsAsync(new List<Career>());

            var handler = new GetStudentCareerHandler(mockRepository.Object);

            // Act
            var result = await handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.Empty(result);
            mockRepository.Verify(repo => repo.GetCareers(studentId), Times.Once);
        }
    }
}
