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
//     "Issuer":"EShopBackend", t okenı dağıtan taraf
//     "Audience":"EshopFronted": bu tokenı kim kullanıcak
//     "AccsessTokenExpriration":30 kullanılcak süre

// }
//progrsm cs de builder.Services.AddIdentity<ApplicationUser,ApllicationRole>(option=>{
//option.Password.RequireDigit}); şifre ile ilgili ayarları yaptık
//AddEntityFrameworStores = add ıdentıtynın deposu neresesi diyor
//AddEntityFrameworkStore<EShopDbContex 
//AddDefaultTokenProviders(); => Bunu yükleme sebebimiz ise token gönderebilmemeizi ssağlar eğer bunu yüksemezsek token üretmek için ayrıca bır paket yüklememiz gerekir
//shared appseting json dakı bilgilerin bulundugu bir class oluşturacağız
//sharedde configutastion adında bir folder oluşturduk ve sjwtconfig adında bir class oluşturduk ve çine secret vb proplar ekledik
//program cse tekrar geçtik ve oraya 
//builder.Services.Configure<JwConfig>(builder.Configaration.GetSection("JwtConfig")); i oluşturdum
//Bu kod bana configasryon ayayı yaptım ve appsettinge eriştim 
//var jwtConfig= builder.Configuration.GetSection("JwtConfig").Get<JwtConfig>(); //bu kodu yazdık cunku baska bır klasın ıcınde
// builder.Services.AddAuthentication (options=>{option.s})
//nuget.orga gidiyoruz ve jwtbearres paketini yüklüyouruz
///





