using System;
using EShop.MVC.Models;
using EShop.MVC.Services.Interfaces;

namespace EShop.MVC.Services;

public class ProductServices:IProductService
{
    private readonly HttpClient _httpClient;

    public ProductServices(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<ResponseModel<ProductModel>> CreateAsync(ProductModel productCreateModel)
    {
        // var formData = new MultipartFormDataContent();
        // formData.Add(new StringContent(productCreateModel.Name), "Name");
        // formData.Add(new StringContent(productCreateModel.Properties), "Properties");
        // formData.Add(new StringContent(productCreateModel.Price!.ToString()!), "Price");
        // foreach(var categoryId in productCreateModel.CategoryIds)
        // {
        //     formData.Add(new StringContent(categoryId.ToString()), "CategoryIds");

        // }
        // StreamContent streamContent;
        // if(productCreateModel.ImageUrl==null!){
        //     // formData.Add(new StreamContent(productCreateModel.Image!.OpenReadStream()), 
        //     // "Image", productCreateModel.Image!.FileName);
        //     var StreamContent = new StreamContent(productCreateModel.Image!.OpenReadStream());
        //     formData.Add(StreamContent, "Image", productCreateModel.Image!.FileName);
        // }
        // else{
        //     var defaultImagePathc =Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "default.png");
        // }
        throw new NotImplementedException();
        

    }

    public async Task<ResponseModel<List<ProductModel>>> GetAllActivesAsync()
    {
        // var  response = await _httpClient.GetAsync<ResponseModel<List<ProductModel>>>($"Product/GetAllActives/all/active?is");
        return response;

    }

    public async Task<ResponseModel<List<ProductModel>>> GetAllAsync()
    {
        // var response = await _httpClient.GetAsync<ResponseModel<List<ProductModel>>>("Product/GetAll");
        return response; 
    }

    public Task<ResponseModel<List<ProductModel>>> GetAllDeletedAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<ProductModel>> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<NoContent>> HardDeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<NoContent>> SoftDeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<ProductModel>> UpdateAsync(ProductModel productUpdateModel)
    {
        var formData = new MultipartFormDataContent();
        formData.Add(new StringContent(productUpdateModel.Name), "Name");
        formData.Add(new StringContent(productUpdateModel.Properties), "Properties");
        formData.Add(new StringContent(productUpdateModel.Price!.ToString()!), "Price");
        foreach(var categoryId in productUpdateModel.Categories)
        {
            formData.Add(new StringContent(categoryId.ToString()), "CategoryIds");

        }
    }

    public async Task<ResponseModel<NoContent>> UpdateIsActiveAsync(int id)
    {
       var response = await _httpClient.PutAsync<ResponseModel<NoContent>>($"Product/UpdateIsActive/{id}", null);
    }
}
