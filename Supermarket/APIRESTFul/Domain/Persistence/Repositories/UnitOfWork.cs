using APIRESTFul.Domain.Persistence.Context;
using APIRESTFul.Domain.Repositories;
using System.Threading.Tasks;

namespace APIRESTFul.Domain.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }

}
