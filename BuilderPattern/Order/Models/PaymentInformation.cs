
namespace BuilderPattern.Order.Models
{
    public class PaymentInformation
    {
        public long Id { get; set; }
        public string PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
    }
    public enum PaymentMethodEnum
    {
        InstantPay = 1,
        PayLater = 2
    }
}
