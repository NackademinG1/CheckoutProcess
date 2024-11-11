
using PaymentService.Implementation;

namespace OrderService.Interfaces;

public interface IOrderService
{
    public void CreateOrder(double amount, PaymentMethod Method);

    public void ConfirmOrder();
    
    public void ProcessOrder(PaymentMethod Method, double amount);
}
