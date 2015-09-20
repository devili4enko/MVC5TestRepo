using System.Collections.Generic;
using System.Threading.Tasks;
using Models.SportStoreModels;

namespace MVC5TestRepo.Repositories.Interfaces
{
   public interface ISportStoreRepository
    {
       IEnumerable<Product> Products { get; }

       Task<int> SaveProductAsync(Product product);
       Task<Product>DeleteProductAsync(int productId);

       IEnumerable<Order> Orders { get; }
       Task<int> SaveOrderAsync(Order order);
       Task<Order> DeleteOrderAsync(int orderId);
    }
}
