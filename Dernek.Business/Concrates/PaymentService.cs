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

        public List<Payment> GetByDateList(DateTime startDate, DateTime endDate)
        {
            DataTable dt = paymentRepository.GetByDate(startDate, endDate);
            List<Payment> list = new List<Payment>();
            foreach(DataRow row in dt.Rows)
            {
                list.Add(new Payment()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    MemberId = row["MemberId"].ToString(),
                    PaymentDate = Convert.ToDateTime(row["PaymentDate"]),
                    Price = Convert.ToDecimal(row["Price"])
                });
            }

            return list;
        }
    }
}
