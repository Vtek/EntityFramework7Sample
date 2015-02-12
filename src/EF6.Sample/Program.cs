using System;
using System.Diagnostics;

namespace EF6.Sample
{
    public class Program
    {
        static void Main()
        {
            using (var dbContext = new ProductContext())
            {
                var stopwatch = new Stopwatch();

                stopwatch.Start();

                for (var i = 0; i < 2000; i++)
                {
                    dbContext.Products.Add(new Product
                    {
                        CreationDate = DateTime.Now,
                        Id = i + 1,
                        Name = "Product"
                    });

                }
                dbContext.SaveChanges();
                stopwatch.Stop();
                Console.WriteLine("Executed in : {0}ms", stopwatch.ElapsedMilliseconds);
                Console.ReadKey();
            }
        }
    }
}
