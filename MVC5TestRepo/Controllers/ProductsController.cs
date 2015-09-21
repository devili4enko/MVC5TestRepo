using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Models.SportStoreModels;
using MVC5TestRepo.Repositories.Implementation;
using MVC5TestRepo.Repositories.Interfaces;

namespace MVC5TestRepo.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly ISportStoreRepository _repository;

        public ProductsController()
        {
            _repository = new SportStoreRepository();
        }

        public IEnumerable<Product> Get()
        {
            return _repository.Products;
        }

        public Product GetProduct(int id)
        {
            return _repository.Products.FirstOrDefault(p => p.Id == id);
        }
        public async Task<int> PostProduct(Product product)
        {
            return await _repository.SaveProductAsync(product);
        }

        public async Task<Product> DeleteProduct(int id)
        {
            return await _repository.DeleteProductAsync(id);
        }

        [Route("api/Products/Delete/")]
        [HttpPost]
        public async Task<Product> PostDeleteProduct(Product product)
        {
            return await _repository.DeleteProductAsync(product.Id);
        }

    }
}
