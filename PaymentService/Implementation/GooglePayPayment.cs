using PaymentService.Interface;

namespace PaymentService.Implementation;

public class GooglePayPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Processing Googlepay payment of {amount}");
    }
}
