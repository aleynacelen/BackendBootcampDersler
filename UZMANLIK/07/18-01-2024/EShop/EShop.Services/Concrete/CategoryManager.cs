using System;
using EShop.Data.Abstract;
using EShop.Entity.Concrete;
using EShop.Services.Abstract;
using EShop.Shared.Dtos;
using EShop.Shared.Dtos.ResponseDtos;

namespace EShop.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;


        public Task<ResponseDto<CategoryDto>> AddAsync(CategoryCreateDto categoryCreateDto)
        {
            // AutoMapper paketini kurmaya gidiyoruz
            throw new NotImplementedException();
        }

        public Task<ResponseDto<int>> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<int>> CountAsync(bool? isActive)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<IEnumerable<CategoryDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<IEnumerable<CategoryDto>>> GetAllAsync(bool? isActive)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<CategoryDto>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> HardDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> UpdateAsync(CategoryUpdateDto categoryUpdateDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<bool>> UpdateIsActiveAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
