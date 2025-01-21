using System;
using EShop.Shared.Dtos;
using EShop.Shared.Dtos.ResponseDtos;

namespace EShop.Services.Abstract
{
    public interface ICategoryService
    {
        Task<ResponseDto<CategoryDto>> GetAsync(int id);
        Task<ResponseDto<IEnumerable<CategoryDto>>> GetAllAsync();
        Task<ResponseDto<IEnumerable<CategoryDto>>> GetAllAsync(bool? isActive);
        Task<ResponseDto<CategoryDto>> AddAsync(CategoryCreateDto categoryCreateDto);
        Task<ResponseDto<NoContent>> UpdateAsync(CategoryUpdateDto categoryUpdateDto);
        Task<ResponseDto<NoContent>> SoftDeleteAsync(int id);
        Task<ResponseDto<NoContent>> HardDeleteAsync(int id);
        Task<ResponseDto<int>> CountAsync();
        Task<ResponseDto<int>> CountAsync(bool? isActive);
        Task<ResponseDto<bool>> UpdateIsActiveAsync(int id);

    }
}
//get all için overlood tasarslıyorum cunku mesela aktif olan tüm kayıtları getirmemiz gereken bir durumda olabilir
//yeni bir kategori oluşturmak icin create dtoyu da oluşturduk
//deltede oluştrduk
//hard delete ve soft delete de ekledik ve  adet saydırmak için countu ve sadece aktfleri de saydırabılcegımız bır overloodunu da ekledik
//ve servis katmanında bunun somutunu yazdık 
