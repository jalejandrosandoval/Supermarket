using APIRESTFul.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIRESTFul.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Products>> ListAsync();
    }
}
