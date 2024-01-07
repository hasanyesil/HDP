using Dernek.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Business.Abstract
{
    public interface IPaymentService : IBaseService
    {
        Payment AddPayment(Payment payment);

        DataTable GetByDate(DateTime startDate, DateTime endDate);

        List<Payment> GetByDateList(DateTime startDate, DateTime endDate);
    }
}
