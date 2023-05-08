using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{   
    interface IWareHouse
    {
        void addProduct(Product product);
        void removeProduct(Product product);

    }

    internal class WareHouse : IWareHouse
    {

        private string warehouseName;
        private string measurment;
        private string dateOfLastDelivery;
        private int count;
        private Money priceForOne;
        private Reporting report = new Reporting();

        public WareHouse(string _warehouseName, string _measurment, string _dateOfLastDelivery, int _count, Product product)
        {
            warehouseName = _warehouseName;
            measurment = _measurment;
            dateOfLastDelivery = _dateOfLastDelivery;
            priceForOne = product.ProductPrice;
            count = _count;
            

        }
        public string WarehouseName { get { return warehouseName; } set { warehouseName = value; } }
        public string Measurment { get; set; }

        public Money PriceForOne { get; set; }
        public string DateOfLastDelivery { get; set; }
        public int Count { get { return count; } set { count = value; } }

        public void addProduct(Product product)
        {
            count++;
            report.SalesInvoice(warehouseName, product);
        }

        public void removeProduct(Product product)
        {   
            if (count == 0)
                global::System.Console.WriteLine("На складі 0 продуктів");
            else
                count--;
            report.RevenueInvoice(warehouseName, product);
        }

    }
}
