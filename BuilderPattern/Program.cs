// See https://aka.ms/new-console-template for more information
using BuilderPattern.Order.Models;
using BuilderPattern.Order.OrderBuilder;

Console.WriteLine("Building order...");

OrderBuilder orderBuilder = new OrderBuilder()
    .AddDeliveryInformation(new DeliveryInformation()
    {
        CustomerAddressId = 1,
        DeliveryAddressId = 2,
    })
    .AddProduct(new Product()
    {
        Discount = 100,
        Price = 10010,
        ProductId = "#1010",
        Name = "Banana"
    })
    .AddProduct(new Product()
    {
        Discount = 100,
        Price = 10010,
        ProductId = "#1011",
        Name = "Apple"
    })
    .AddProduct(new Product()
    {
        Discount = 100,
        Price = 25000,
        ProductId = "#1012",
        Name = "Sangsum Gallaxy S3"
    })
    .AddProduct(new Product()
    {
        Discount = 100,
        Price = 10010,
        ProductId = "#1013",
        Name = "Table"
    })
    .AddProduct(new Product()
    {
        Discount = 100,
        Price = 10010,
        ProductId = "#1014",
        Name = "HP G3 Laptop"
    })
    .AddAddon(new Addon()
    {
        Name = "Kyeboard",
         Price = 1200,
         ProductId = "#8888"
    });

    orderBuilder.AddPaymentInformation(new PaymentInformation()
    {
        Amount = 10000,
        PaymentId = "#12345",
        PaymentMethod = PaymentMethodEnum.InstantPay
    });

Order order = orderBuilder.Build();

Console.WriteLine("Order build.");

Console.ReadLine();

