using System;

namespace Project24;

public abstract class Repo
// bu class ı ileride oluşturacağım Product Category Customer gibi farklı yapılar için miras vermek üzere oluşturuyorum

{
public abstract void Create();
    public abstract void GetAll();
   
    public abstract void GetById();
    public abstract void Delete ();
}
public class ProductRepo : Repo
public strin Name { get; set; } 
public int M { get; set; }   

static void DisplayArray (int[] array);
foreach (int curretntnumber in collection)
{
    
}
