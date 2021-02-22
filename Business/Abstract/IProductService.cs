using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllByProduct();
        List<Product> GetByUnitPrice(decimal min, decimal max);
        List<Product> GetAllByCategoryId(int id);
    }
}
