using APIRESTFul.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIRESTFul.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Products>> ListAsync();
    }
}
