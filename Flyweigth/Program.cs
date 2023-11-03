using Flyweigth;

class Program
{
    public static void Main()
    {
        Order NewOrder = new Order();
        OrderItems item = new OrderItems();
        OrderItems item2 = new OrderItems();

        ProductFlyweightFactory Factory = new ProductFlyweightFactory();
        item.product = Factory.CreateProduct("test");
        item2.product = Factory.CreateProduct("test");
        
        NewOrder.Items.Add(item);
        NewOrder.Items.Add(item2);
    }
}