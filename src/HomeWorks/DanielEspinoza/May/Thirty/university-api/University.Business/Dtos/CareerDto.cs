namespace University.Business.Dtos;
public class CareerDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Code { get; set; }
}