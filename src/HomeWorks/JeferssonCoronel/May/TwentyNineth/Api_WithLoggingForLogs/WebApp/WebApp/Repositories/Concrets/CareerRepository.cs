using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Entity;
using WebApp.Repositories.Interfaces;

namespace WebApp.Repositories.Concrets
{
    public class CareerRepository : BaseRepository<Career>, ICareerRepository
    {
        public CareerRepository(MyDBContext context) : base(context)
        {
        }
        public async Task<List<Student>> GetStudents(Guid careerId)
        {
            var career = await context
                .Set<Career>().Include((s) => s.Students)
                .FirstAsync((s) => s.Id
                .Equals(careerId));
            return career.Students;
        }
    }
}
