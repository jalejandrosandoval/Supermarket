using APIRESTFul.Domain.Models;
using APIRESTFul.Domain.Persistence.Context;
using APIRESTFul.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIRESTFul.Domain.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Products>> ListAsync()
        {
            return await _context.Products.Include(p => p.Category)
                                          .ToListAsync();
        }
    }
}
