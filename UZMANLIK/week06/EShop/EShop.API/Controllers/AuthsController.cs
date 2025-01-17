using System.IdentityModel.Tokens.Jwt;
using System.IO.Pipelines;
using System.Security.Principal;
using EShop.Service.Abstract;
using EShop.Shared.Dtos.Auth;
using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

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
//api projesine yüklüyoruz 
//shemaları ekliyoruz
//optiontions.DefaultAuthenticateScheme=JwtBearerDefults.AuthencationScheme;
//options.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme;. AddJwtBearer (diyio burada da eklediğimiz paketle alakalı yapılandırmaları yapıyoruz)
//
//options.TokenValitdationParametrer = new TokenValidationParameters{ ısu aud vs bunları kontrol edeyim mi gerekli olan ısu nerede yazıyor bana tanıt... ıssuesigkey kısmında da = new SymetricSc(endcodin.utf8.geybyyts(jwtConfig.Secre))}= ikili sayı sistemine dönüştürüyoruz bir kkez daha sifremizin güvenliğini arttırıyoruz
// ve servis katmanınd abstract ve concate oluşturyoruz 
//ilk önce IAutchServices oluşturuyoruz ve 

//servislerimde belli metodlarım olucak kodumu kullanarak kod yazıcak kişinin daha fazla bilgi sahibi olması lazım ve bazende hata döndüreceğim ve hatalarım çeşit çeşit olucak 
//kolaylık sağlamak amacıyla bir ceavp standardı oluşrtumam gerekşyor ve bunun için response diye bir class oluşturmam gerekıyor ve bunu dtosun ıcıne oluşruracağım istersem ayrı da oluşturabılırım bu sınıfın içinde 1 geri döndürülecek datayı 2 geri dödüreülecek hata mesajını geri döndürülcecek hata kodunu ve işlemin başarılı olup olmadıgını döndürücek 
//ve kılasımızı düzenliyoruz
//public class Response<T>{ public t? data get set public string Errormesage (amacı hatayı tutmak) prop int StatusCode bool tipde IsSussesfull başarılı olup olmadığını anlatan bır şey dönücek}
// Başarılı durumlarda kullanılcak constracter metodlarımkz
//publiv static ResponseDto<T> Success(T?,data, int statusCode){return new Response<T> Data=data StatusCode=statusCode IsSUSSE=TRUE}
//BAŞARILI AMA GERİYE DATA DÖNDÜRMEYECEK DURUMLARDA
//public static ResponseDto<T> Success(int statusCode)
//{data defult statuscode status code ıssuccelul}
//fail olma durudumda ise fail adında bir dta oluşucak 
//burda factory desing paket kullandık cunku önce oluşturup sonra içindekş metodu kullanmak zorunda kalmayacağım 
//şimdi ise servisin içinde oluştudurudğumuz IAutchServisin içinde dönüyoruz ve ordada task<responsedto<??>> LoginAync (LoginDto logindto); oluşturuyoruz 
//ve dtoların içinde login dtoyu oluşturuyoruz
//sonra tokendtoyu oluşturuyoryz
//login dtrouun içinde user name ve şifre var
//token dtounun içinde ise accsestoken adını verdiğimiz bir değer ve bitme tarihini tutacağımız iki tane prop olsun
//registordtro olucak isim, soyisim gibi bildilerin oldugu proplar bulunucak
//kullancı şifresimi unuttugundakı kısım içinde bir dto hazırlanacak daha sonrasında requided bilgileribi vereceğiz registord compare: eşitliiğini kontroller ettiğimniz şifre kısmında kullanacğaız ve bunları ıautch servisin içine task olarak yazacağız
//concratein içine AutchManagr diye bir sınıf oluşturduk
//ve ilk aşama olarak içerine 
//private readonly UserManager<ApplicationUser> _userManager i ekliyoruz bana bir user ver bu neye göre çalışıcak application usera göre
//private readonly SigInManager<ApplicaitonUser> _sigInManager i ekliyoruz  bu bize ıdentittyden geliyor login ve logut olma gibi şeylri barıdnıyor
//private JwtConfig _jwtConfig; ekliyoruz bunu direkt bu tipde alamıyoruz ona müdahalede bulunmamız gerekiyor  onu IOpitons içinde almamız gerekiyor ve içerindeki jwtConfig= options.Value olarak almamız gerekiyor.
//ıauth servisten implement etmemiz gerekiyor 
//ilk aşama olarak da login işlemini yapıyoruz 
//loginnin içinw yazmam gerken bilgileri yazıyorum
//try catch meknaızmasının içine yazıyorum cunku hata yakalamam gerekiyor sistemsel hataları yaklamam gerekiyor
// try
// {
    //var user = await _userManager.findByName(logindtor.username)// findbyname kullanıcı adına göre arama yapan bir metod 
    //if(user==null)
    // {
    //     return ResponseDto<TokenDto>.Fail("Kullanıcın adı veya şifre hatalı",StatusCode.kullanılcakstatuscodelar,);
    // }
    //var isValidPassword= await _userManager.CheckPasswordAsyc(user,loginDto.Passwordd); if işinde kontrol ediyoruz ve return respınsestroz<TokenDtoZ.Fail(kullanıcı adı veya şifre hatalı mesajını veriyoruz bunuda statuscode.status400Request ile)
    
// }
// catch (System.Exception)
// {
    
//     throw;
// }
//token yaratmamız gerekiyor 
// try
// {
//     var roles = _userManager.GetRoleAsyn(user);
        //var username //kulanııyla ilgili bilgiler claim ve kullanıcı hakkındaki bilgileri ekleyeceğiz
        //newClaim = new List<CLAİM>
        //new claim(claimTypes.NameIdenttifier userId namevs burada ekliyoruz)
        //JwtRegistered.Names.jti(tokena özelleştirilmiş bir id),Guid.NewGuid().ToString())()- guid sitesinde oluşturduğumuz rastgele guid değerini c de böyle bir kod ile yazarız
        //rolleri eklemek için linq sorgusu ile yukarıdaki bilgilerle birşeleştirebiliriz
        //.Uniom(roles.Select(x=>new Claim(ClaimTypes.Role,x)))
        //-- burada diyoruz ki unionla birleştiriyoruz

        //olan keyi binary formatta vermeiz için aşağıdaki gibi yazarız
        // var key = new  SymmetricSecurity Key(encoid.utf8.getbyres(jwtvon.sec)
        //var credentials = new Signincredential(keyisecuritiy))//bu imzzayı kulland
        //var ecpiry=DateTime.Now.AddDays(Convert.ToDouble(_jwtCınfig.Acsess)) süresi için 30 gün soneası mesala
        // var token= new JwtSecurityToken(
        //     issuer:_jwtConfig.Issuer,
        //     audience:_jwtConfig.Audience,
        //     expires:expiry,
        //     signingCredentials:creditials
        /// 1.42 kala tokenı daha guvenli nasıl yazabılceğımızı gösteren kodlar var

        // )



// }
// catch (System.Exception)
// {
    
//     throw;
// }
//işlemler bittikten sonra login işlerşmşni kontrol edeceğiz
//
//daha sonra controller klasörüne gidip api kontroller oluşturacağız
//Controllerbase den miras alıyor, normal controlerden da miras alıyor ve içinde viev gibi yapılar yok
// private readonly IAuthService _authService;
//public AuthsController(IAuthtService autchService)
//{
//_AUTHTsERVİDE = AUTCHSERVİCE;
//}
//DEDİKTEN SORNA LOGİN İŞLEMİNİ ARTIK GERçeekleştiriyoruz

// public async Task<Shared.Dtos.ResponseDtos.ResponseDto<TokenDto>>IAuthtService.LoginAsyn(LoginDto loginDto){
//     var result = await _authServices
// }


 





