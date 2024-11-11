using PaymentService.Interface;

namespace PaymentService.Implementation;

public class CrediCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Processing Credit card payment of {amount}");

    }

}
