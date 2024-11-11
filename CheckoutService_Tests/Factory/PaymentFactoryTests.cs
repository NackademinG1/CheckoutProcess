using PaymentService.Factory;
using PaymentService.Implementation;

namespace CheckoutService_Tests.Factory;

public class PaymentFactoryTests
{
    [Theory]
    [InlineData(PaymentMethod.CreditCard, typeof(CrediCardPayment))]
    [InlineData(PaymentMethod.Paypal, typeof(Paypalpayment))]
    [InlineData(PaymentMethod.GooglePay, typeof(GooglePayPayment))]
    [InlineData(PaymentMethod.ApplePay, typeof(ApplePayPayment))]

    public void Create_ValidPaymentMethod_ReturnCorrectPaymentType(PaymentMethod paymentMethod, Type expected)
    {
        var paymentInstance = PaymentFactory.Create(paymentMethod);

        Assert.IsType(expected, paymentInstance);
        Assert.Equal(expected, paymentInstance.GetType());


    }

    [Theory]
    [InlineData(PaymentMethod.CreditCard)]
    [InlineData(PaymentMethod.Paypal)]
    [InlineData(PaymentMethod.GooglePay)]
    [InlineData(PaymentMethod.ApplePay)]
    public void Create_ValidPaymentMethod_DoesNotReturnNull(PaymentMethod paymentMethod)
    {
        var paymentInstance = PaymentFactory.Create(paymentMethod);

        Assert.NotNull(paymentInstance);
    }


}
