using Dernek.Business.Abstract;
using Dernek.DataAccess.Abstract;
using Dernek.DataAccess.Concrates;
using Dernek.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Business
{
    public class PaymentService : IPaymentService
    {
        IPaymentRepository paymentRepository;

        public PaymentService()
        {
            paymentRepository = new PaymentRepository();
        }

        public Payment AddPayment(Payment payment)
        {
            return paymentRepository.Insert(payment);
        }

        public DataTable GetByDate(DateTime startDate, DateTime endDate)
        {
            return paymentRepository.GetByDate(startDate, endDate);
        }
    }
}
