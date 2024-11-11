using CheckoutService.Interface;
using CheckoutService.Models;
using OrderService.Interfaces;
using PaymentService.Implementation;
using PaymentService.Interface;
using PaymentService.Services;
using System.Security.Cryptography.X509Certificates;

namespace CheckoutService.Services;

public class CheckoutService : ICheckoutService
{
    private readonly IPaymentService _paymentService;
    private readonly IOrderService _orderService;

    public CheckoutService(IPaymentService paymentService, IOrderService orderService)
    {
        _paymentService = paymentService;
        _orderService = orderService;
    }
    public void ProcessCheckout (PaymentMethod method, double amount)
    {
        _paymentService.ProcessPayment(method, amount);
        _orderService.ProcessOrder(method, amount);
    }
}
