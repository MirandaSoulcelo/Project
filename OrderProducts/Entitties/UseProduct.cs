using System.Globalization;
namespace Order
{
    class UsedProduct : Product
    {
        public DateOnly ManuFactureDate{get; set;}

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateOnly manuFactureDate) : base(name, price)
        {
            ManuFactureDate = manuFactureDate;
        }

        public override string PriceTag()
        {
            return "Name: " + Name + " (used) Product Pirce:  " + Price.ToString("F2", CultureInfo.InvariantCulture) + " Manufacture Date: " + ManuFactureDate;
        }
    }
}

