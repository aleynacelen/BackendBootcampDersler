using System;
using EShop.MVC.Models;

namespace EShop.MVC.Services.Interfaces;

public interface IProductServices
{

Task<ResponseModel<List<ProductModel>>> GetAllAsync(); 
Task<ResponseModel<List<ProductModel>>> GetAllActivesAsync();
Task<ResponseModel<List<ProductModel>>> GetAllDeleteAsync(); 
Task<ResponseModel<ProductModel>> GetByIdAsync(int id);
Task<ResponseModel<ProductModel>> CoreatetAsync(ProductModel productCreateModel);
Task<ResponseModel<ProductModel>> UpdateAsync(ProductModel productUpdateModel);
Task<ResponseModel<NoContent>> SoftDeleteAsync(int id); 
Task<ResponseModel<NoContent>> HardDeleteAsync(int id);

}
