using PaymentService.Interface;

namespace PaymentService.Implementation;

public class Paypalpayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount}");
    }
}
