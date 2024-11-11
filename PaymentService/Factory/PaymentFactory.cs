using PaymentService.Implementation;
using PaymentService.Interface;

namespace PaymentService.Factory;

public class PaymentFactory
{
    public static IPayment Create(PaymentMethod paymentMethod)
    {
        switch (paymentMethod)
        {
            case PaymentMethod.CreditCard:
                return new CrediCardPayment();

            case PaymentMethod.Paypal:
                return new Paypalpayment();

            case PaymentMethod.GooglePay:
                return new GooglePayPayment();

            case PaymentMethod.ApplePay:
                return new ApplePayPayment();

            default:
                throw new NotSupportedException(
                    $"{paymentMethod}is not currently supported as a payment method."
                    );
        }
    }
}
