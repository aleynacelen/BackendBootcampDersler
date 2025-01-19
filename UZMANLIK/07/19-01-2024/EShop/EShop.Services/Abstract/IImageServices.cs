using System;
using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Http;

namespace EShop.Services.Abstract;

public interface IImageServices
{
 Task<ResponseDto<string>>UploadImageAsync(IFormFile image);
ResponseDto<bool>DeleteImage(string imageUrl);
}
