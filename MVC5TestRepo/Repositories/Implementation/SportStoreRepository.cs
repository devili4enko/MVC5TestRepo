using System.Collections.Generic;
using System.Threading.Tasks;
using Models.SportStoreModels;
using MVC5TestRepo.Models.SportStoreModels;
using MVC5TestRepo.Repositories.Interfaces;

namespace MVC5TestRepo.Repositories.Implementation
{
    public class SportStoreRepository : ISportStoreRepository
    {
        private readonly ProductDbContext _context;

        public SportStoreRepository()
        {
            _context=new ProductDbContext();
        }

        public IEnumerable<Product> Products
        {
            get { return _context.Products; }
        }

        public async Task<int> SaveProductAsync(Product product)
        {
            if (product.Id==0)
            {
                _context.Products.Add(product);
            }
            else
            {
                var dbEntry = await _context.Products.FindAsync(product.Id);

                if (dbEntry!=null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Category = product.Category;
                    dbEntry.Price = product.Price;
                    dbEntry.Description = product.Description;
                }
            }

            return await _context.SaveChangesAsync();
        }

        public async Task<Product> DeleteProductAsync(int productId)
        {
            var dbEntry = await _context.Products.FindAsync(productId);

            if (dbEntry != null) _context.Products.Remove(dbEntry);

            await _context.SaveChangesAsync();

            return dbEntry;
        }

        public IEnumerable<Order> Orders
        {
            get { return _context.Orders.Include("Lines").Include("Lines.Product"); }
        }

        public async Task<int> SaveOrderAsync(Order order)
        {
            if (order.Id == 0)
            {
                _context.Orders.Add(order);
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<Order> DeleteOrderAsync(int orderId)
        {
            var dbEntry = await _context.Orders.FindAsync(orderId);

            if (dbEntry != null) _context.Orders.Remove(dbEntry);

            await _context.SaveChangesAsync();

            return dbEntry;
        }
    }
}