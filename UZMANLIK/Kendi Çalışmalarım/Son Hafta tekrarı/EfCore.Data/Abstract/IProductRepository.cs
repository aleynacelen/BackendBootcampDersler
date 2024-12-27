using System;
using System.Net.Http.Headers;

namespace EfCore.Data.Abstract;

public interface IProductRepository:IGenericRepository<Product>
{
    Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);
    Task<IEnumerable<Product>>GetAllDeletedProductsAsync(bool isDeleted=true);
    Task<Product

}
