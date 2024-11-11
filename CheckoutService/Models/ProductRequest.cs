using PaymentService.Implementation;

namespace CheckoutService.Models;

public class ProductRequest
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Price { get; set; } = null!;
    public int Quantity { get; set; }
    public string Description { get; set; } = null!;
    public PaymentMethod Paymentmethod { get; set; }
}
