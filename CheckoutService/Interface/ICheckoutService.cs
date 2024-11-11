using PaymentService.Implementation;

namespace CheckoutService.Interface;

public interface ICheckoutService
{
    public void ProcessCheckout(PaymentMethod method, double amount);
}
