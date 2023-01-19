namespace TechieShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElasticCollection elasticCollection = new ElasticCollection();

            elasticCollection.AddProduct(new Product { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 1000 });
            elasticCollection.AddProduct(new Product { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 200, Category = "Chairs", OrderCount = 4000 });
            elasticCollection.AddProduct(new Product { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 });

            Console.WriteLine("TechieShop...A shop different from...\n List of Items\n Id = 1, Name = \"Dell Xps\", Quantity = 30, Price = 1500, Category = \"PCs\", OrderCount = 1000\n Id = 2, Name = \"Ergonomic Chair\", Quantity = 400, Price = 200, Category = \"Chairs\", OrderCount = 4000\n " +
                "Id = 3, Name = \"Table\", Quantity = 500, Price = 250, Category = \"Tables\", OrderCount = 3000\n");
            elasticCollection.Display();

        }
    }
}