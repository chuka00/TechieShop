using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace TechieShop
{
    class ElasticCollection
    {
        public List<ExpandoObject> Products { get; set; }

        public ElasticCollection()
        {
            Products = new List<ExpandoObject>();
        }

        public void AddProduct(Product product)
        {
            dynamic productObject = new ExpandoObject();
            productObject.Id = product.Id;
            productObject.Name = product.Name;
            productObject.Quantity = product.Quantity;
            productObject.Price = product.Price;
            productObject.Category = product.Category;
            productObject.OrderCount = product.OrderCount;

            Products.Add(productObject);
        }

        public void Display(List<string> properties = null)
        {
            if (properties == null)
            {
                properties = new List<string>() { "Id", "Name", "Quantity", "Price", "Category", "OrderCount" };
            }

            foreach (var product in Products)
            {
                foreach (var property in properties)
                {
                    if (((IDictionary<string, object>)product).ContainsKey(property))
                    {
                        Console.Write(((IDictionary<string, object>)product)[property] + ", ");
                    }
                    else
                    {
                        Console.Write("property not exists, ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
