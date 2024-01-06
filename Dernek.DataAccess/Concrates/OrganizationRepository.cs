using Dernek.DataAccess.Abstract;
using Dernek.DataAccess.Helper;
using Dernek.Entity.Enums;
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

        public Organization GetOrganization()
        {
            string sql = @"select * from Organization where ID = 1";

            DataTable dt = DBHelper.ExecuteReader(sql, null);
            if(dt.Rows.Count > 0)
            {
                Organization org = new Organization()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["ID"]),
                    Description = dt.Rows[0]["Description"].ToString(),
                    OrganizationName = dt.Rows[0]["OrganizationName"].ToString(),
                    Price = Convert.ToDecimal(dt.Rows[0]["Price"]),
                    PricePeriod = (PricePeriods)Convert.ToByte(dt.Rows[0]["PricePeriod"])
                };

                return org;
            }
            else
            {
                throw new Exception("No record found on Organization table, please check");
            }
        }

        public decimal GetOrganizationFee()
        {
            string sql = @"select Price from Organization where ID = 1";
            
            DataTable dt = DBHelper.ExecuteReader(sql, null);
            if(dt.Rows.Count > 0)
            {
                return Convert.ToDecimal(dt.Rows[0]["Price"].ToString());
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
            string sql = @"update Organization set OrganizationName = ?, Description = ?, Price = ?, PricePeriod = ?";

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("OrganizationName", obj.OrganizationName);
            dict.Add("Description", obj.Description);
            dict.Add("Price", obj.Price);
            dict.Add("PricePeriod", Convert.ToByte(obj.PricePeriod));

            DBHelper.ExecuteNonQuery(sql, dict);

            return obj;
        }
    }
}
