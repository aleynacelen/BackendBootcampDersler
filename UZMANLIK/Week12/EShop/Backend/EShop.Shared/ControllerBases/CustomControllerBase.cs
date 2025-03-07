using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Shared.ControllerBases
{
    public class CustomControllerBase : ControllerBase
    {
        public static IActionResult CreateResult<T>(ResponseDto<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }

        protected string GetUserId()
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            return userId!;

        }
    }

}

public class CustomControllerBase: ControllerBase
{
    public static IActionResult CreateResult<T>(ResponseDto<T> response)
    {
        return new ObjectResult(response)
        {
            StatusCode = response.StatusCode
        };
    }
}
//Bu kodda, ControllerBase sınıfından türetilen CustomControllerBase sınıfı oluşturulmuştur. Bu sınıf, API'lerde kullanılan controller sınıflarının ortak işlemlerini gerçekleştirmek için oluşturulmuştur. CreateResult metodu, API'lerden dönen ResponseDto nesnelerini IActionResult nesnelerine dönüştürmek için kullanılmaktadır. GetUserId metodu, kullanıcının kimliğini döndürmek için kullanılmaktadır.
//Bu sınıf, API'lerde kullanılan controller sınıflarının ortak işlemlerini gerçekleştirmek için oluşturulmuştur. CreateResult metodu, API'lerden dönen ResponseDto nesnelerini IActionResult nesnelerine dönüştürmek için kullanılmaktadır. GetUserId metodu, kullanıcının kimliğini döndürmek için kullanılmaktadır.
