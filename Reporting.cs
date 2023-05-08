using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    
    interface IGetterInvoices
    {
        void RevenueInvoice(string warehouseName, Product product);

        void SalesInvoice(string warehouseName, Product product);
    }

    interface IGetterBalances
    {
        void GetWarehouseBalances(WareHouse warehouse);
    }
    internal class Reporting : IGetterInvoices, IGetterBalances
    {

        public Reporting()
        {

        }
        public void RevenueInvoice(string warehouseName, Product product)
        {
            global::System.Console.WriteLine($"Товар {product.ProductName} продано зі складу {warehouseName}"); 
        }

        public void SalesInvoice(string warehouseName, Product product)
        {
            global::System.Console.WriteLine($"Товар {product.ProductName} додано на склад {warehouseName}");
        }

        public void GetWarehouseBalances(WareHouse warehouse)
        {
            global::System.Console.WriteLine($"На {warehouse.WarehouseName} {warehouse.Count} залишків");
        }


    }
}
