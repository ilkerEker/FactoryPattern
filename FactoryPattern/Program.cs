// See https://aka.ms/new-console-template for more information

using FactoryPattern;

IPayment payment = //PaymentFactory.create(PaymentMethod.CreditCard);
                    //PaymentFactory.create(PaymentMethod.PayPal);
                    //PaymentFactory.create(PaymentMethod.GooglePay);
                    PaymentFactory.create(PaymentMethod.ApplePay);
    payment.Pay(1000.00);