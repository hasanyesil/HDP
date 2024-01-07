using Dernek.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.DataAccess.Abstract
{
    public interface IPaymentRepository : IBaseRepository<Payment>
    {
        DataTable GetByDate(DateTime startDate, DateTime endDate);
    }
}
