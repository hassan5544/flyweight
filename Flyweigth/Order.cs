namespace Flyweigth;

public class Order
{
    public int OrderNo { get; set; }
    public string CustomerName { get; set; }
    public DateTime OrderDate { get; set; }
    
    public List<OrderItems> Items { get; set; }
}