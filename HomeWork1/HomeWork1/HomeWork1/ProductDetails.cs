using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class ProductDetails
    {
         public int Id { get; set; }

         public string Title { get; set; }

         public double Price { get; set; }

         public ProductDetails (int id, string title, double price)
    {
         Id = id;
         Title = title;
         Price = price;
    }
  }
}
