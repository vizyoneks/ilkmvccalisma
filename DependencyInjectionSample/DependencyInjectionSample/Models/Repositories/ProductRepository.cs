using System.Collections.Generic;
using System.Linq;

namespace DependencyInjectionSample.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {
        NorthwindEntities db = new NorthwindEntities();
        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }
    }
}
