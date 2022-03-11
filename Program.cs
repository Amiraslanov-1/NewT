using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product
            {
                NameProd = "Iphone 12 ",
                ProdBrand = "Iphone",
                Price = 3500
            };

            Console.WriteLine($"{product.NameProd} {product.ProdBrand}  {product.Price}");

            Product product1 = new Product
            {
                NameProd = "Iphone 11",
                ProdBrand = "Iphone",
                Price = 3450
            };

            Console.WriteLine($"{product1.NameProd} {product1.ProdBrand}  {product1.Price}");

            Product product2 = new Product();

            product2.NameProd = "Iphone XS Max";
            product2.ProdBrand = "Iphone";
            product2.Price = 2000;
            Console.WriteLine($"{product2.NameProd} {product2.ProdBrand}  {product2.Price}");


            Product product3 = new Product();

            product3.NameProd = "Iphone X ";
            product3.ProdBrand = "Iphone";
            product3.Price = 700;
            Console.WriteLine($"{product3.NameProd} {product3.ProdBrand}  {product3.Price}");


            Product product4 = new Product();

            product4.NameProd = "Iphone 8+";
            product4.ProdBrand = "Iphone";
            product4.Price = 600;
            Console.WriteLine($"{product4.NameProd} {product4.ProdBrand}  {product4.Price}");







            int[] MyArr = { product.Price, product1.Price,product2.Price, product3.Price, product4.Price };
          
            int[] Products = MixedArray(ref MyArr);

            foreach (var item in MixedArray(ref MyArr  ))
            {
                Console.WriteLine(item);
            }
           


        }

        static int[] MixedArray(ref int[] Products, double MinPrice = 1000, double MaxPrice = 7000)
        {
        
            for (int i = 0; i < Products.Length; i++)
            {

               if(MinPrice<Products[i] && MaxPrice>Products[i])
                {
                   Products = new int[i];
                }
          
 
            }
            return Products;


        }


    }

    }




