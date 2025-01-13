using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Azure.Core;
using EShop.Entity.Concrete;
using EShop.Service.Abstract;
using EShop.Shared.Configurations.Auth;
using EShop.Shared.Dtos;
using EShop.Shared.Dtos.Auth;
using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace EShop.Service.Concrete;

public class AuthManager : IAuthService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private JwtConfig _jwtConfig;
    //Aslında burada başka servisler de olacak, ancak henüz yazmadık.
    public AuthManager(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IOptions<JwtConfig> options)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _jwtConfig = options.Value;
    }

    public Task<ResponseDto<NoContent>> ChangePasswordAsync(ChangePasswordDto changePasswordDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<NoContent>> ForgotPasswordAsync(ForgotPasswordDto forgotPasswordDto)
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseDto<TokenDto>> LoginAsync(LoginDto loginDto)
    {
        try
        {
            var user = await _userManager.FindByNameAsync(loginDto.UserName);
            if (user == null)
            {
                return ResponseDto<TokenDto>.Fail("Kullanıcı adı veya şifre hatalı", StatusCodes.Status400BadRequest);
            }
            var isValidPassword = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            if (!isValidPassword)
            {
                return ResponseDto<TokenDto>.Fail("Kullanıcı adı veya şifre hatalı", StatusCodes.Status400BadRequest);
            }
            var tokenDto = await GenerateJwtToken(user);
            return ResponseDto<TokenDto>.Success(tokenDto, StatusCodes.Status200OK);

        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Giriş yapılırken bir hata oluştu: {ex.Message}");
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

    private async Task<TokenDto> GenerateJwtToken(ApplicationUser user)
    {
        try
        {
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            }.Union(roles.Select(x => new Claim(ClaimTypes.Role, x)));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.Secret));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToDouble(_jwtConfig.AccessTokenExpiration));

            var token = new JwtSecurityToken(
                issuer: _jwtConfig.Issuer,
                audience: _jwtConfig.Audience,
                claims: claims,
                expires: expiry,
                signingCredentials: credentials
            );
            var tokenDto = new TokenDto
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                AccessTokenExpirationDate = expiry
            };
            return tokenDto;

        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Token oluşturulurken bir hata oluştu: {ex.Message}");
            throw;
        }
    }
}



// foreach (var role in roles)
// {
//     claims.Add(new Claim(ClaimTypes.Role, role));
// }