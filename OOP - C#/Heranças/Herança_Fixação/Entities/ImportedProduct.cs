using System;
using System.Globalization;

namespace Course.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }
        
        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsfree) : base(name, price)
        {
            CustomsFree = customsfree;
        }

        public double TotalPrice()
        {
            return Price + CustomsFree;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFree.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
