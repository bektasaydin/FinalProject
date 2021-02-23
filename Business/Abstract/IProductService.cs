using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllByProduct();
        List<Product> GetByUnitPrice(decimal min, decimal max);
        List<Product> GetAllByCategoryId(int id);
        List<ProductDetailDto> GetProductDetails();
        Product GetById(int productId);
        IResult Add(Product product);
    }
}
