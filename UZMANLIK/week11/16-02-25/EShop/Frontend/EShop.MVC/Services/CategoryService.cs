using System;
using EShop.MVC.Areas.Admin.Models;
using EShop.MVC.Models;
using EShop.MVC.Services.Interfaces;
using Newtonsoft.Json;

namespace EShop.MVC.Services
{
    public class CategoryService : ICategoryService
    
    {
        private readonly HttpClient _httpClient;
        public Task<ResponseModel<int>> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<int>> CountAsync(bool isActive)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<CategoryModel>> CreateAsync(CategoryCreateModel categoryCreateModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<List<CategoryModel>>> GetAllActivesAsync(bool isActive)
        {
            var httpResponseMessage = await _httpClient.GetAsync("categories/actives");
            var contentResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            var response= JsonConvert.DeserializeObject<ResponseModel<List<CategoryModel>>>(contentResponse);
            return response;
            }

        public Task GetAllActivesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<CategoryModel>>> GetAllAPassivesAsync(bool isActive)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<CategoryModel>>> GetAllAsync(bool isActive)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<CategoryModel>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<CategoryModel>> GetAsync(int id)
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

        public Task<ResponseModel<NoContent>> UpdateAsync(CategoryUpdateModel categoryUpdateModel)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<bool>> UpdateIsActive(int id)
        {
            throw new NotImplementedException();
        }
    }
}
