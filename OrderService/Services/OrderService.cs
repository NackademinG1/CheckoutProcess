using OrderService.Interfaces;
using PaymentService.Implementation;

namespace OrderService.Services;

public class OrderService : IOrderService
{
    public void ConfirmOrder()
    {
        throw new NotImplementedException();
    }

    public void CreateOrder(double amount, PaymentMethod Method)
    {
        throw new NotImplementedException();
    }

    public void ProcessOrder(PaymentMethod Method, double amount)
    {
        throw new NotImplementedException();
    }
}
