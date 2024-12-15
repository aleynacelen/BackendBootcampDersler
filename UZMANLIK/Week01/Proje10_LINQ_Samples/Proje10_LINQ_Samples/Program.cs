using LINQ_Samples;
using Proje10_LINQ_Samples;
Repository repository = new Repository();

#region Tüm Kategorileri Listeleme
// var result = repository.Categories.ToList();
// var result = from category in repository.Categories
//  select category;
#endregion

#region Tüm Kategorilerin Adını Listeleme
// var categoryNames = repository
//     .Categories
//     .Select(x => x.Name)
//     .ToList();
// var categoryNames = from category in repository.Categories
//                     select category.Name;
#endregion

#region Sadece Silinmemiş Kategorileri Listeleme
// var deletedCategories = repository
//     .Categories
//     .Where(x=>!x.IsDeleted)
//     .ToList();
// var deletedCategories = from category in repository.Categories
//                         where !category.IsDeleted
//                         select category;
#endregion

#region Ürünlerin Fiyatlarını Listeleme
// var prices = repository
//     .Products
//     .Select(x=>x.Price)
//     .ToList();
#endregion
#region Kategoriye göre Gruplanmış Ürünleri Listeleme
// var grupedByCategory =repository
//                .Products
//                .GroupBy()

#endregion
#region Tedarikçi başına ürün sayısı

// var productCountBySupplier=repository

//     .Products
//     .GroupBy(X=>X.SupplierId)
//     .Select(global=> new {SupplierId =global.Key,ProductCount=global.Count()})
//     .ToList();
// var productCountBySupplier= from product in repository.productCountBySupplier
//                             group product by product.SupplierId into g
//                             select new {SupplierId=g.Key, ProductCount=g.Count()};

#endregion
#region Her Kategoride ki ilk ürünü getirme
// var firstProductInCategory =
// repository
// .Products
// .GroupBy(p=>p.CategoryId)
// .Select(g=>g.First())
// .ToList();

// var firstProductInCategory =
// from product in repository.Products
// group product by product.CategoryId  into productGroup
// select productGroup.FirstOrDefault();
// System.Console.WriteLine();


#endregion
#region Ürün fiyatlarından en küçüğünü getirme
var minPrice = repository

    .Products
    .Min(p=>p.Price);
#endregion
