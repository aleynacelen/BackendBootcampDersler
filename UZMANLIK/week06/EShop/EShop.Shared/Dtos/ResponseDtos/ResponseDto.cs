using System;

namespace EShop.Shared.Dtos.ResponseDtos;
//Bu sınıf içinde 1- Geri döndürülecek datayı 2- Geri döndürülecek hata mesajını 3- Geri döndürülecek hata kodunu tutacağız 4- Geri dödürülücek işlemin başarılı olup olmadığını tutacağız.

public class ResponseDto<T>
{
    public T? Data { get; set; }
    public string? Eror { get; set; }
    public int StatusCode { get; set; }
    public bool IsSuccessfull { get; set; }

    //Başarılı bir işlem olduğunda bu metodu kullanacağız.
  public static ResponseDto<T> Success(T? data, int statusCode)
  {
    return new ResponseDto<T>
    {
      Data = data,
      StatusCode = statusCode,
      IsSuccessfull = true
    };
  }
  //Başarılı ama geriye data döndürmeyeceğimiz durumlar için bu metodu kullanacağız.    
  public static ResponseDto<T> Success(int statusCode)
  {
    return new ResponseDto<T>
    {
      Data = default,
      StatusCode = statusCode,
      IsSuccessfull = true
    };
  }
  //Hata durumunda bu metodu kullanacağız.
    public static ResponseDto<T> Fail(string error, int statusCode)
    {
        return new ResponseDto<T>
        {
        Eror = error,
        StatusCode = statusCode,
        IsSuccessfull = false
        };
    }

}
//Factory Design Pattern kullandık çünkü: Bu sınıfın içinde 3 farklı durum var. 1- Başarılı bir işlem 2- Başarılı bir işlem ama geriye data döndürmeyeceğimiz durum 3- Hata durumu. Bu durumları tek bir sınıf içinde tutmak yerine bu durumları ayrı ayrı sınıflarda tutmak daha mantıklıdır. Bu yüzden Factory Design Pattern kullandık.//İhtiyacıma göre istediğim durumu en ideal şekilde bana design pattern sağlıyor
