﻿using LINQ_Samples;
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
// var prices = repository
//     .Products
//     .Where(x=>x.Price>=10000)
//     .ToList();
// var prices = from product in repository.Products
//                 select product.Price;
#endregion

#region Kategoriye Göre Gruplanmış Ürünleri Listeleme
// var groupedByCategory = repository
//     .Products
//     .GroupBy(x=>x.CategoryId)
//     .ToList();
// var groupedByCategory = from product in repository.Products
//                         group product by product.CategoryId;
#endregion

#region Tedarikçi Başına Ürün Sayısını Listeleme
// var productCountsBySupplier = repository
//     .Products
//     .GroupBy(p => p.SupplierId)
//     .Select(g => new { SupplierId = g.Key, ProductCount = g.Count() })
//     .ToList();
// var productCountsBySupplier = 
//         from product in repository.Products
//         group product by product.SupplierId into groupedData
//         select new {SupplierId= groupedData.Key, ProductCount= groupedData.Count()};
#endregion

#region Her Kategorideki İlk Ürünü Getirme
// var firstProductInCategory= 
//     repository
//     .Products
//     .GroupBy(p=>p.CategoryId)
//     .Select(g=>g.FirstOrDefault())
//     .ToList();
// var firstProductInCategory =
//     from product in repository.Products
//     group product by product.CategoryId into productGroup
//     select productGroup.FirstOrDefault();
#endregion

#region Ürün Fiyatlarından En Küçüğünü Getirme
// var minPrice = repository
//     .Products
//     .Min(p => p.Price);
var minPrice =
    (from product in repository.Products
    select product.Price).Min();
System.Console.WriteLine();
#endregion

#region Bir müşteriye Ait satışları getirme
// var customerSales =repository
//                    .Sales
//                    .Where(x=>x.CustomerId==3)
//                    .ToList();
// System.Console.WriteLine();
// var customerSales=
//     (from sale in repository.Sales
//     where sale.CustomerId==3
//     select sale).ToList();
//     System.Console.WriteLine();
    
#endregion

#region Kategoriye göre ürünlerin fiyat ortalamalarını getirme
// var averagePriceByCategory=
//         repository
//             .Products
//             .GroupBy(p=>p.CategoryId)
//             .Select(g=>new{CategoryId=g.Key, AveragePrice=g.Average(p=>p.Price)})
//             .ToList();
//             System.Console.WriteLine();
// var averagePriceByCategory=
//         from product in repository.Products
//         group product by product.CategoryId into productGroup
//         select new{CategoryId=productGroup.Key,AvaregePrice=productGroup.
//         Average(x=>x.Price)};

#endregion

