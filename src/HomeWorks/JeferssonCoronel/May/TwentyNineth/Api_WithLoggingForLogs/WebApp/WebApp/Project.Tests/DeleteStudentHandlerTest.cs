using Moq;
using Project.Business.Students;
using WebApp.Entity;
using Xunit;

namespace WebApp.Project.Tests
{
    public class DeleteStudentHandlerTest
    {
        [Fact]
        public async Task Handle_ValidRequest_DeletesStudent()
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

            var request = new DeleteStudentRequest(studentId);

            mockRepository.Setup(repo => repo.GetById(studentId)).ReturnsAsync(student);
            mockRepository.Setup(repo => repo.Delete(student)).ReturnsAsync(1);

            var handler = new DeleteStudentHandler(mockRepository.Object);

            // Act
            var result = await handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.Equal(1, result);
            mockRepository.Verify(repo => repo.GetById(studentId), Times.Once);
            mockRepository.Verify(repo => repo.Delete(student), Times.Once);
        }

        [Fact]
        public async Task Handle_InvalidStudentId_ThrowsException()
        {
            // Arrange
            var mockRepository = new Mock<IStudentRepository>();
            var studentId = Guid.NewGuid();
            var request = new DeleteStudentRequest(studentId);

            mockRepository.Setup(repo => repo.GetById(studentId)).ReturnsAsync((Student)null);

            var handler = new DeleteStudentHandler(mockRepository.Object);

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(() => handler.Handle(request, CancellationToken.None));
            mockRepository.Verify(repo => repo.GetById(studentId), Times.Once);
            mockRepository.Verify(repo => repo.Delete(It.IsAny<Student>()), Times.Never);
        }
    }
}
