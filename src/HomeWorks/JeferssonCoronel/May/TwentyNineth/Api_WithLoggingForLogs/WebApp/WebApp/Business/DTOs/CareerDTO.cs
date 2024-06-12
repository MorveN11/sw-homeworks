using WebApp.Entity;

namespace Project.Business.DTOs.Student;

public class CareerDTO : IEntityBase
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
}