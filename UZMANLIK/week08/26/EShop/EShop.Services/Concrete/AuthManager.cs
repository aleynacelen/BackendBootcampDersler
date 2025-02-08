using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Azure.Core;
using EShop.Entity.Concrete;
using EShop.Services.Abstract;
using EShop.Shared.Configurations.Auth;
using EShop.Shared.Dtos;
using EShop.Shared.Dtos.Auth;
using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace EShop.Services.Concrete;

public class AuthManager : IAuthService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private JwtConfig _jwtConfig;

    public AuthManager(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, JwtConfig jwtConfig)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _jwtConfig = jwtConfig ;
    }

    public Task<ResponseDto<NoContent>> ForgetPasswordAsync(ForgotPasswordDto forgotPasswordDto)
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseDto<TokenDto>>LoginAsyn(LoginDto loginDto)
    {
        try
        {
           var user = await _userManager.FindByNameAsync(loginDto.UserName);
           if(user===null)
           {
            return ResponseDto<TokenDto>.Fail("Kullanıcı adı veya şifre hatalı",StatusCodes.Status400BadRequest);
           }
           var isValidPassword=await _userManager.CheckPasswordAsync(user,LoginDto.Password);
           
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }

    public Task<ResponseDto<ApplicationUserDto>> RegisterAsync(RegisterDto registerDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<NoContent>> ResetPasswordAsync(ResetPasswordDto resetPasswordDto)
    {
        throw new NotImplementedException();
    }
}



