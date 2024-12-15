//generic yapılar özellikle tip güvenliği sağlama konusunda işimizi görürler. Fakat aynı zamanda kodun yeniden kullanılabilirliğini arttıır
//DRY Dont repeat yoursel
//Dictionary<TKey,TValue>
Dictionary<string,int> ages = new Dictionary<string,int>();
ages.Add("Aleyna",24);
ages.Add("Gökhan",23);
// foreach (var item in ages)
// {
//     System.Console.WriteLine($"{item.Key}:{item.Value}");
// }
// if(ages.ContainsKey("Bozkuş"))
// // {
// // System.Console.WriteLine(ages["Bozkuş"]);
// // }
// ages.Remove("Can");
// foreach (var item in ages)
// {
//     System.Console.WriteLine($"{item.Key}:{item.Value}");
// }


// Box<int> numberBox = new Box<int>();
// numberBox.Add(5);
// System.Console.WriteLine(numberBox.Get());
// Box<string> stringBox= new Box<string>();
// stringBox.Add("Aleyna");
// System.Console.WriteLine();
// class Box<T> 
// {
//     private T content ;
//     public void Add(T item)
//     {
//         content=item;

//     }
//     public T Get()
//     {
//         return content;
//     }
// }
