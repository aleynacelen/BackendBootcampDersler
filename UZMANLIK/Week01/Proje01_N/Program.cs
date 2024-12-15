//Nullable Types : Bu tipler bir değerin "yok" (null) olabilmesine izin veren veri türleridir
//Genellikle referans tipler için mümkün olan bir durumdur.
//Varsayıalan olarak null değer içeleremeyen Value typeler istenilirse null değer içerebilcek hala getirebililerler bunun için tip yanının yanına" ? " konulur

int nullableInt = 5;
int? nullableınT= null;
if(nullableInt.HasValue){
    System.Console.WriteLine("değer, var");

}else
{
    System.Console.WriteLine("değeri yok");
}
int? nullableValue = null;
// int result = nullableValue==null ? 100 : nullableValue;
int result =nullableValue ?? 100;
//Null Colesing Operator (??)
System.Console.WriteLine(result);
//Bir veri tabanında kullanıcının yaşını alıyoruz , ancak bazı durumlarda bu veri null glebiliyor.

int userAge =GetUserAge();
if(userAge<0){
    System.Console.WriteLine("Kişinin yaş bilgisi yok");
}else
{
    System.Console.WriteLine(userAge  );
}
System.Console.WriteLine(userAge);
int GetUserAge(){
    int age =5;
    return age?? -1;//Bu fake bir veri tabanından yaş çekme kodu

}

