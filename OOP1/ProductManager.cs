using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi");

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " silindi");
        }
        /*void nedir ? geriye bir değer döndürmeyecek ise void kullanılabilir, 
        int , string vb. gibi değişkenler türünden bir fonksiyon yazılacak ise return komutu 
        kullanılabilir.*/



    }
}
