using PaymentService.Implementation;

namespace PaymentService.Interface
{
    public interface IPaymentService
    {
        public void ProcessPayment(PaymentMethod method, double amount);
    }
}