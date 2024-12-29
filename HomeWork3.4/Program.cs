using System;
using System.Collections.Generic;
using System.Linq;
using HomeWork3._4;
//ПП - правильное питание
//ФФ - фаст-фуд
var products = new List<Product>
{
    new Product{Name = "Огурец", Category = "ПП", Price = 10},  
    new Product{Name  = "Попмидор", Category = "ПП", Price = 14},
    
    new Product {Name = "Сникерс", Category = "ФФ", Price = 40},
    new Product {Name = "Бурито", Category = "ФФ", Price = 70},
};

var filterForFF = products.Where(p => p.Category == "ФФ");

var filterForPP = products.Where(p => p.Category == "ПП");

double averagePricePP = filterForPP.Average(p => p.Price);
double averagePriceFF = filterForFF.Average(p => p.Price);

foreach (var ProductFF in filterForFF)
{
    Console.WriteLine($"{ProductFF.Name}, {ProductFF.Category}, {ProductFF.Price}");
}

Console.WriteLine($"Средняя стоимость фаст-фуд товаров: {averagePriceFF}");

foreach (var ProductPP in filterForPP)
{
    Console.WriteLine($"{ProductPP.Name}, {ProductPP.Category}, {ProductPP.Price}");
}

Console.WriteLine($"Средняя стоимость полезный товаров: {averagePricePP}");