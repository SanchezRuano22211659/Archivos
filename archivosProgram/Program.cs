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
            string path = @"a";
            StreamWriter textOut=
            new StreamWriter ( new FileStream(path, FileMode.Create, FileAccess.Write));


            foreach(var product in products)
            {
                textOut.Write(product.Code +"|");
                textOut.Write(product.Description +"|");
                textOut.WriteLine(product.Price);
            }
            textOut.Close();
        }
}




 class Program
{
    private static void Main(string[] args)
    {
        List<Product> product = new List<Product>();
        product.Add(new Product ("1", "a", 1m));
        product.Add(new Product ("2", "b", 2m));
        product.Add(new Product ("3", "c", 3m));


        ProductsDB.SaveProducts(product);
       
    }
}