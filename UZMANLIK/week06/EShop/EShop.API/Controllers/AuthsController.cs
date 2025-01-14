using EShop.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        private readonly IAuthService _authServices;
        public
        

    }

}
//JWT
//jhoson web token birr anahtardır 
//herkese acık bir şekilde bilgi göndermek istemıyorum sifrelemek istiyorum login olma mekanızmasını bu sistemin üzerine kuruyoryz
//cookie için api mantıklı değil
// artık bana yaptığın isteklerde bana json web tokenı da gönder diyoruz
//appseting jsonda calısıyoruz 
// "JwtConfig":{
//     "Secret":"şifre yazılılack guid gibi bir yerden",
//     "Issuer":"EShopBackend", tokenı dağıtan taraf
//     "Audience":"EshopFronted": bu tokenı kim kullanıcak
//     "AccsessTokenExpriration":30 kullanılcak süre

// }
//progrsm cs de builder.Services.AddIdentity<ApplicationUser,ApllicationRole>(option=>{
//option.Password.RequireDigit});




