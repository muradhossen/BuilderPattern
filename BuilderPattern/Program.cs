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
        Discount = 10,
        Price = 10000,
        ProductId = "#1010",
        Name = "Laptop"
    })
    .AddAddon(new Addon()
    {
        Name = "",
        Price = 1200,
        ProductId = "#8888"
    });

    orderBuilder = orderBuilder.AddProduct(new Product()
    {
        Discount = 0,
        Price = 10000,
        ProductId = "#1010",
        Name = "Laptop"
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



//.AddProduct(new Product()
// {
//     Discount = 100,
//     Price = 25000,
//     ProductId = "#1012",
//     Name = "Sangsum Gallaxy S3"
// })
//    .AddProduct(new Product()
//    {
//        Discount = 100,
//        Price = 10010,
//        ProductId = "#1013",
//        Name = "Table"
//    })
//    .AddProduct(new Product()
//    {
//        Discount = 100,
//        Price = 10010,
//        ProductId = "#1014",
//        Name = "HP G3 Laptop"
//    })