using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace ProdExerc.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFess): base(name, price)
        {
            CustomsFee = customsFess;
        }

        public double TotalPrice()
        {
            return Price += CustomsFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $"(Custom fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
