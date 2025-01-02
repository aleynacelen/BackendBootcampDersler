using System;

namespace Aleyna.Data.Abstract;

public interface IProductRepository:IGenericRepository
{
Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);  
Task<IEnumerable<Product>> GetAllDeletedProductAsync();

Task<Product> GetProductWithCategoriesByIdAsync(int id);
Task<IEnumerable<Product>> GetProductsWithCategoriesAsync();
}
public class Product
{
}

public interface IGenericRepository
{
}