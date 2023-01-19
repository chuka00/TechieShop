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

        public void Display()
        {
            List<string> properties = new List<string>();
            Console.WriteLine("Select the properties you want to display.\nEnter 'done' when you're finished:");

            try
            {
                string input = "";
                while (input != "done")
                {
                    input = Console.ReadLine();
                    if (input == "Id" || input == "Name" || input == "Quantity" || input == "Price" || input == "Category" || input == "OrderCount")
                    {
                        properties.Add(input);
                    }
                    else if (input != "done")
                    {
                        throw new Exception("Invalid input, please enter a valid property name or 'done'");
                    }
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
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }
    }
}
