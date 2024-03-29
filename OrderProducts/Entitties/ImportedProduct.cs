using System.Globalization;

namespace Order
{
    class ImportedProduct : Product 
    {
        public double CustomsFee{get; set;}

        public ImportedProduct(){

        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {

            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
             return "Product Name: " + Name + " Price: " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + $"(Customs Fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)} )";
        }
        
    }
}