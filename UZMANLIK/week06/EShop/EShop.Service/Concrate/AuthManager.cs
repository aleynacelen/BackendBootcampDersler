using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EShop.Entity.Concrete;
using EShop.Service.Abstract;
using EShop.Shared.Configaration.Aut;
using EShop.Shared.Dtos.Auth;
using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace EShop.Service.Concrate;

public class AuthManager
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private JwtConfig _jwtConfing;
    public class AuthManager : IAuthService
    {
        public Task<ResponseDto<NoContent>> ChangePasswordAsync(ChangePassword changePasswordDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> ForgetPasswordAsync(ForgetPassword forgotPasswordDto)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto<TokenDto>> Login Asycn(LoginDto loginDto)
        {
            var user = await _userManager.FindByNameAsync(loginDto.UserName)
        }

        public Task<ResponseDto<ApplicationUser>> RegisterAync(RegistorDto registerDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> ResetPasswordAsyn(ResetPassword resetPassword)
        {
            throw new NotImplementedException();
        }
    }

    public Task<ResponseDto<NoContent>> ChangePasswordAsync(ChangePassword changePasswordDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> ForgetPasswordAsync(ForgetPassword forgotPasswordDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<TokenDto>> LoginAsycn(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<ApplicationUser>> RegisterAync(RegistorDto registerDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> ResetPasswordAsyn(ResetPassword resetPassword)
        {
            throw new NotImplementedException();
        }
        private async Task<TokenDto> GenerateJwtToken (ApplicationUser user)
        {
            try
            {
                var roles = await _userManager.GetRolesAsync(user);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier,user.Id),
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString),

                }.Union(roles.Select(x=> new Claim(ClaimTypes.Role,x)));
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfing.Secret));
                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var expiry = DateTime.Now.AddDays(Convert.ToDouble(_jwtConfing.AccessTokenExpiration));
                var token = new JwtSecurityToken(
                    issuer: _jwtConfing.Issuer,
                    audience:_jwtConfing.Audience,
                    expires:expiry,
                    claims:claims,
                    signingCredentials:credentials


                );
                var TokenDto= new TokenDto
                {
                    AccessToken= new JwtSecurityTokenHandler().WriteToken(token),
                    AccessTokenExparationDate=expiry

                };
                return TokenDto;
            }
            catch (System.Exception)
            {
                System.Console.WriteLine($"Token oluşurken bir hata oluştu:");
                
                throw;
            }

        }
    }


