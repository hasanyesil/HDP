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
    public class OrganizationRepository : IOrganizationRepository
    {
        public Organization Delete(Organization obj)
        {
            throw new NotImplementedException();
        }

        public Organization Get(Organization obj)
        {
            throw new NotImplementedException();
        }

        public List<Organization> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllAsDt()
        {
            throw new NotImplementedException();
        }

        public decimal GetOrganizationFee()
        {
            string sql = "@select OrganizationFee from Organization where ID = 1";
            
            DataTable dt = DBHelper.ExecuteReader(sql, null);
            if(dt.Rows.Count > 0)
            {
                return Convert.ToDecimal(dt.Rows[0]["OrganizationFee"].ToString());
            }
            else
            {
                throw new Exception("No record found on Organization table, please check");
            }
        }

        public Organization Insert(Organization obj)
        {
            throw new NotImplementedException();
        }

        public Organization Update(Organization obj)
        {
            throw new NotImplementedException();
        }
    }
}
