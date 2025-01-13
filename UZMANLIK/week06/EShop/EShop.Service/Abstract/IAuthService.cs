using System;
using EShop.Entity.Concrete;
using EShop.Shared.Dtos.Auth;
using EShop.Shared.Dtos.ResponseDtos;

namespace EShop.Service.Abstract;

public interface IAuthService
{
    Task<ResponseDto<TokenDto>> LoginAsycn(LoginDto loginDto);
    Task<ResponseDto<ApplicationUser>> RegisterAync(RegistorDto registerDto);
    Task<ResponseDto<NoContent>> ForgetPasswordAsync(ForgetPassword forgotPasswordDto);
    Task<ResponseDto<NoContent>> ChangePasswordAsync(ChangePassword changePasswordDto);
    Task<ResponseDto<NoContent>> ResetPasswordAsyn(ResetPassword resetPassword);
    


}
