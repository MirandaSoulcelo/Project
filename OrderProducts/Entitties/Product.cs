using System.Globalization;

namespace Order
{
    class Product
    {
       public string Name{get; set;} 
       
       public double Price{get; protected set;}

       public Product()
       {

       }
       public Product(string name, double price)
       {
        Name = name;

        Price = price;
       }


       public virtual string PriceTag()
       {
        return "Product Name: " + Name + " Price: " + Price.ToString("F2", CultureInfo.InvariantCulture);
       }
    }
}