using Flyweigth;
namespace Flyweigth;

public class ProductFlyweightFactory
{


    private readonly Dictionary<string, Product> Products;

    public ProductFlyweightFactory()
    {
        Products = new Dictionary<string, Product>();
    }

    public Product CreateProduct(string ProductName)
    {
        if (!Products.ContainsKey(ProductName))
        {
            Product NewProduct = new Product(ProductName, 1, DateTime.Now);
            Products.Add(ProductName,NewProduct);
        }

        return Products[ProductName];
    }
}