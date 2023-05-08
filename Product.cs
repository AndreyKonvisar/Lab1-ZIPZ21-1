using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    
    internal class Product
    {
        private string productName;
        private Money productPrice;

        public Product(string _productName, Money _productPrice)
        {
            productName = _productName;
            productPrice = _productPrice;
        }
        public string ProductName { get { return productName; } set { productName = value; } }
        public Money ProductPrice { get { return productPrice; } set { productPrice = value;} }

        public void decreasePrice(Money minusPrice, Product product)
        {
            int tmpCoin;
            if (minusPrice._coins > productPrice._coins)
            {
                tmpCoin = productPrice._coins - minusPrice._coins;
                productPrice._coins = 100 + tmpCoin;
                productPrice._money -= 1;
            }
            product.productPrice._money -= minusPrice._money;
        }
    }
}
