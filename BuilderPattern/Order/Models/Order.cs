namespace BuilderPattern.Order.Models;

public class Order
{
    public Order()
    {
        Addons = new List<Addon>();
        Products = new List<Product>();
        Addons = new List<Addon>();
        DeliveryInformation = new();
        PaymentInformation = new();
    }
    public int Id { get; set; }
    public string OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public IList<Addon> Addons { get; set; }
    public IList<Product> Products { get; set; }
    public PaymentInformation PaymentInformation { get; set; }
    public DeliveryInformation DeliveryInformation { get; set; }
    public double TotalAmount { get; set; }
    public double DiscountAmount { get; set; }

}
