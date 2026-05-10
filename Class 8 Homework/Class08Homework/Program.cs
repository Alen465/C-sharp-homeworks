using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
                new Product(2, "iPhone X", "SIM-Free, Model A19211", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
                new Product(3, "Samsung Universe 9", "Samsung's new variant", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
                new Product(4, "OPPOF19", "OPPO F19 is officially announced", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
                new Product(5, "Huawei P30", "Huawei P30 Pro New Edition", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
                new Product(6, "MacBook Pro", "MacBook Pro 2021", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
                new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
                new Product(8, "Microsoft Surface Laptop 4", "Style and speed", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
                new Product(11, "perfume Oil", "Impression of Acqua Di Gio", 13, 4.26, 65, "Impression", ProductCategory.Fragrances),
                new Product(12, "Brown Perfume", "Royal Mirage", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
                new Product(16, "Hyaluronic Acid Serum", "Skin serum", 19, 4.83, 110, "L'Oreal", ProductCategory.Skincare),
                new Product(21, "Daal Masoor", "Fine quality", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
                new Product(22, "Elbow Macaroni", "Pasta", 14, 4.57, 146, "Bake Parlor", ProductCategory.Groceries)
            };
            var expensiveProducts = products.Where(p => p.Price > 500);

            foreach (var p in expensiveProducts)
            {
                Console.WriteLine(p.Title);
            }
            var skincare = products.Where(p => p.Category == ProductCategory.Skincare);

            foreach (var p in skincare)
            {
                Console.WriteLine(p.Title);
            }
            var titles = products.Select(p => p.Title);

            foreach (var t in titles)
            {
                Console.WriteLine(t);
            }
            var laptops = products
    .Where(p => p.Category == ProductCategory.Laptops)
    .Select(p => p.Title);

            foreach (var l in laptops)
            {
                Console.WriteLine(l);
            }
            var lowStockDesc = products
    .Where(p => p.Stock < 50)
    .Select(p => p.Description);

            foreach (var d in lowStockDesc)
            {
                Console.WriteLine(d);
            }
            var highRating = products
    .Where(p => p.Rating > 4.5)
    .Select(p => p.Title);

            foreach (var h in highRating)
            {
                Console.WriteLine(h);
            }
            var midPrice = products
    .Where(p => p.Price >= 100 && p.Price <= 200)
    .Select(p => p.Title);

            foreach (var m in midPrice)
            {
                Console.WriteLine(m);
            }
            var perfumes = products
    .Where(p => p.Category == ProductCategory.Fragrances && p.Rating > 4.6)
    .Select(p => p.Title);

            foreach (var p in perfumes)
            {
                Console.WriteLine(p);
            }
            var brands = products
    .Where(p => p.Price > 1000)
    .Select(p => p.Brand);

            foreach (var b in brands)
            {
                Console.WriteLine(b);
            }
            var perfumeTitles = products
    .Where(p => p.Title.ToLower().Contains("perfume"))
    .Select(p => p.Title);

            foreach (var p in perfumeTitles)
            {
                Console.WriteLine(p);
            }
            var lastGrocery = products.Last(p => p.Category == ProductCategory.Groceries);

            Console.WriteLine(lastGrocery.Title);
            var firstExpensive = products.First(p => p.Price > 1000);

            Console.WriteLine(firstExpensive.Title);
            var bigStockGroceries = products
    .Where(p => p.Category == ProductCategory.Groceries && p.Stock > 150)
    .Select(p => p.Title);

            foreach (var g in bigStockGroceries)
            {
                Console.WriteLine(g);
            }
            var hemani = products.First(p => p.Brand == "Hemani Tea");

            Console.WriteLine(hemani.Title);
            var ratings = products
    .Where(p => p.Stock >= 30 && p.Stock <= 50)
    .Select(p => p.Rating);

            foreach (var r in ratings)
            {
                Console.WriteLine(r);
            }
        }
    }
}