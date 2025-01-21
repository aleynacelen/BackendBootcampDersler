using System;
using EShop.Services.Abstract;
using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic;

namespace EShop.Services.Concrete;

public class ImageMenager : IImageServices
{
    private readonly string _imageFolderPath;
    public ImageMenager()
    {
        _imageFolderPath=Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","image");
        //gerekli yolu eklemiş olduk
        if (!Directory.Exists(_imageFolderPath))
        {
            Directory.CreateDirectory(_imageFolderPath);
        }
        
    }
    public ResponseDto<bool> DeleteImage(string imageUrl)
    {
        try
        {
            if(string.IsNullOrWhiteSpace(imageUrl))
            {
                return ResponseDto<bool>.Fail("Resim yolu boş olmaz", StatusCodes.Status400BadRequest);

            }
            var FileName=Path.GetFileName(imageUrl);
            var fileFullPath=Path.Combine(_imageFolderPath,FileName);
            if (!File.Exists(fileFullPath))
            {
                return ResponseDto<bool>.Fail("Resim boş olmaz", StatusCodes.Status400BadRequest);
            }
            File.Delete(fileFullPath);
            return ResponseDto<bool>.Success(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {

            return ResponseDto<bool>.Fail(ex.Message, StatusCodes.Status400BadRequest);
        }
    }

    public async Task<ResponseDto<string>> UploadImageAsync(IFormFile image)
    {
        try
        {
            if (image==null)
            {
                return ResponseDto<string>.Fail("Resim dosyası boş olamaz",StatusCodes.Status400BadRequest);
            }
            if (image.Length==0)
            {
                return ResponseDto<string>.Fail("Resim dosyası 0 bayttan küçük olamaz", StatusCodes.Status400BadRequest);
            }
           var allowedExtensions = new[] {".jpg","jpeg",".png",".bmp",".gif"};
           var imageExtentions = Path.GetExtension(image.FileName);
           if (!allowedExtensions.Contains(imageExtentions))
           {
                return ResponseDto<string>.Fail("Uygunsuz dosya uzantısı", StatusCodes.Status400BadRequest);
            }
            if (image.Length>5*1024*1024)
            {
                return ResponseDto<string>.Fail("Resim dosyası 5 bayttan büyük olamaz", StatusCodes.Status400BadRequest);

            }
            var fileName=$"{Guid.NewGuid()}{imageExtentions}";
            var fullPath=Path.Combine(_imageFolderPath,fileName);
            using (var stream= new FileStream(fullPath,FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }
            return ResponseDto<string>.Success($"/image/{fileName}",StatusCodes.Status201Created);
        }
        catch (Exception ex)
        {

            return ResponseDto<string>.Fail(ex.Message, StatusCodes.Status500InternalServerError);
        }
    }
}
