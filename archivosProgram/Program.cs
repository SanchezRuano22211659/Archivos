﻿using System;
using System.IO;


class Product
{
    public string Code;
    public string Description;
    public decimal Price;


    public Product(string _Code, string _Description, decimal _Price)
    {
        Code= _Code;
        Description= _Description;
        Price= _Price;
    }
}




class ProductsDB
{
    public static void SaveProducts(List<Product> products)
        {
            string name = @"productsDatabase.txt";
            StreamWriter textOut= new StreamWriter ( new FileStream(name, FileMode.Create, FileAccess.Write));


            foreach(var product in products)
            {
                textOut.WriteLine($"{product.Code} | {product.Description} | {product.Price}");
            }
            textOut.Close();
        }
}




 class Program
{
    private static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        products.Add(new Product ("1200", "a", 1324234m));
        products.Add(new Product ("200", "b", 221345m));
        products.Add(new Product ("1234", "c", 3123123m));
        products.Add(new Product ("13554", "d", 312m));
        products.Add(new Product ("5832", "e", 3123m));


        ProductsDB.SaveProducts(products);
       
    }
}