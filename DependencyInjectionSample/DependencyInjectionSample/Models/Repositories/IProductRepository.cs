using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Models.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
}
