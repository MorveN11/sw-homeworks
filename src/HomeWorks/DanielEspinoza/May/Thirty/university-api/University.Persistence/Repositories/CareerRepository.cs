using University.Domain;

namespace University.Persistence;

public class CareerRepository : BaseRepository<Career>, ICareerRepository
{
    public CareerRepository(PostgresContext context) : base(context){}

}
