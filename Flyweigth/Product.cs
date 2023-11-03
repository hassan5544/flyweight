namespace Flyweigth;

public class Product
{
   
    public string ProductName  { get; }
    public int Qty { get;  }
    public DateTime CreateDate  { get; }
    
    public Product(string productName, int qty, DateTime createDate)
    {
        ProductName = productName;
        Qty = qty;
        CreateDate = createDate;
    }

}

