using System.Security.Principal;

abstract class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public abstract decimal CalculateDiscount();
}

class Electronic : Product
{
    public int Period { get; set; }

    public override decimal CalculateDiscount()
    {
        throw new NotImplementedException();
    }
}

class Food : Product
{
    public DateTime ExpirationDate { get; set; }
    public override decimal CalculateDiscount()
    {
        throw new NotImplementedException();
    }
    interface IProductRepository{
        Product GetProductById(int id);
        List<Product> GetAll();
    }
}
class ProductRepository{
    public Product GetProductById(int id){
        return new Electronic{Id=id,Name="İphohone",Period=5};
    }
}
class OrderServices
{
    private readonly IProductRepository productRepository1;
public void ProcessOrder(int id)
{
    ProductRepository productRepository = new ProductRepository();
    var product = productRepository.GetProductById(id);
    //burada order ile ilgili işlemler yapılıyor...

}
}