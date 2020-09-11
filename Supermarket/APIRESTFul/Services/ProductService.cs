using APIRESTFul.Domain.Models;
using APIRESTFul.Domain.Persistence.Repositories;
using APIRESTFul.Domain.Repositories;
using APIRESTFul.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRESTFul.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Products>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }

}
