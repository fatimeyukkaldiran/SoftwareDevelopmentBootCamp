using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager // Ürün ile ilgili operasyonlar içerir(ekle,sil,listele,bul....)
    {
        //encapsulation
        public void Add(Product product) //Product türünde bir şey ister
        {
            Console.WriteLine(product.ProductName + " " + "eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

    }
}
