using PaymentService.Implementation;
using PaymentService.Interface;

namespace PaymentService.Services;

public class PaymentService : IPaymentService
{
    private readonly IPayment _payment;

    public PaymentService(IPayment payment)
    {
        _payment = payment;
    }

    public void ProcessPayment(PaymentMethod method, double amount)
    {
        _payment.Pay(amount);  
    }
}
