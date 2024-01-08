using Dernek.DataAccess.Abstract;
using Dernek.DataAccess.Helper;
using Dernek.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.DataAccess.Concrates
{
    public class PaymentRepository : IPaymentRepository
    {
        public Payment Delete(Payment obj)
        {
            throw new NotImplementedException();
        }

        public Payment Get(Payment obj)
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllAsDt()
        {
            throw new NotImplementedException();
        }

        public DataTable GetByDate(DateTime startDate, DateTime endDate)
        {
            string sql = @"select * from Payment where PaymentDate >= ? and PaymentDate < ?";
            
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("StartDate", startDate);
            parameters.Add("EndDate", endDate);

            return DBHelper.ExecuteReader(sql, parameters);
        }

        public Payment Insert(Payment obj)
        {
            string sql = @"insert into Payment (Price, PaymentDate, MemberId) values (?,?,?)";

            Dictionary<string,object> dict = new Dictionary<string,object>();
            dict.Add("Price", obj.Price);
            dict.Add("PaymentDate", obj.PaymentDate);
            dict.Add("MemberId", obj.MemberId);

            DBHelper.ExecuteNonQuery(sql, dict);

            return obj;
        }

        public Payment Update(Payment obj)
        {
            throw new NotImplementedException();
        }
    }
}
