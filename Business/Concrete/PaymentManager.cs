using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        public IResult CreditPayment(Payment paymentCredit)
        {
            return new SuccessResult(Messages.PaymentCompleted);
        }
    }
}
