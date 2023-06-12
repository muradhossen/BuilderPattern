
using BuilderPattern.Order.Models;

namespace BuilderPattern.Order.OrderBuilder;

public class OrderBuilder
{
    private Models.Order Order;
    private double MaxOrderAmount = int.MaxValue;
    public OrderBuilder()
    {
        Order = new();

    }


    public OrderBuilder AddProduct(Product product)
    {
        if (product == null) ArgumentNullException.ThrowIfNull(product, nameof(product));

        if (this.Order.Products.Any(c => c.ProductId == product.ProductId)) { throw new Exception("Product cannot added multiple times "); }

        SetTotalAmount(product.Price, product.Discount);

        Order.Products.Add(product);
        return this;
    }
    public OrderBuilder AddAddon(Addon addon)
    {
        if (addon == null) ArgumentNullException.ThrowIfNull(addon, nameof(addon));

        if (this.Order.TotalAmount >= MaxOrderAmount) { throw new ArgumentOutOfRangeException($"Order amount execed {MaxOrderAmount}"); }
        SetTotalAmount(addon.Price, discountAmount: 0);
        Order.Addons.Add(addon);
        return this;
    }
    public OrderBuilder AddDeliveryInformation(DeliveryInformation deliveryInfo)
    {
        if (deliveryInfo == null) ArgumentNullException.ThrowIfNull(deliveryInfo, nameof(deliveryInfo));


        Order.DeliveryInformation = deliveryInfo;
        return this;
    }
    public OrderBuilder AddPaymentInformation(PaymentInformation paymentInfo)
    {
        if (paymentInfo == null) ArgumentNullException.ThrowIfNull(paymentInfo, nameof(paymentInfo));


        Order.PaymentInformation = paymentInfo;
        return this;
    }
    public OrderBuilder SetOrderDate(DateTime orderDate)
    {
        Order.OrderDate = orderDate;
        return this;
    }
    public Order.Models.Order Build() => Order ?? new Order.Models.Order();
    private void SetTotalAmount(double amount, double discountAmount)
    {
        if (amount >= MaxOrderAmount)
        {
            throw new ArgumentOutOfRangeException($"Order amount execed {MaxOrderAmount}");
        }
        Order.TotalAmount += amount;
        Order.DiscountAmount += discountAmount;
    }
}
