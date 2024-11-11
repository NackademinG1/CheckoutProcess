using PaymentService.Interface;

namespace PaymentService.Implementation;

    public class ApplePayPayment : IPayment
    {

    public void Pay(double amount)
    {
        Console.WriteLine($"Processing applepay payment of {amount}");
    }
}

