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
        public OrganizationFee Delete(OrganizationFee obj)
        {
            throw new NotImplementedException();
        }

        public OrganizationFee Get(OrganizationFee obj)
        {
            throw new NotImplementedException();
        }

        public List<OrganizationFee> GetAll()
        {
            string sql = @"select * from OrganizationFee";
            DataTable dt = DBHelper.ExecuteReader(sql, null);

            List<OrganizationFee> list = new List<OrganizationFee>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    OrganizationFee fee = new OrganizationFee
                    {
                        FeeMonth = Convert.ToInt32(dr["FeeMonth"]),
                        Fee = Convert.ToDecimal(dr["Fee"])
                    };

                    list.Add(fee);
                }
            }

            return list;
        }

        public DataTable GetAllAsDt()
        {
            throw new NotImplementedException();
        }

        public OrganizationFee GetByMonth(int month)
        {
            string sql = @"select * from OrganizationFee where FeeMonth = ?";
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("FeeMonth", month);

            DataTable dt = DBHelper.ExecuteReader(sql, dict);

            OrganizationFee organizationFee = new OrganizationFee();
            organizationFee.Fee = Convert.ToDecimal(dt.Rows[0]["Fee"]);
            organizationFee.FeeMonth = Convert.ToInt32(dt.Rows[0]["FeeMonth"]);

            return organizationFee;
        }

        public OrganizationFee Insert(OrganizationFee obj)
        {
            throw new NotImplementedException();
        }

        public OrganizationFee Update(OrganizationFee obj)
        {
            string sql = @"update OrganizationFee set Fee = ? where FeeMonth = ?";
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("@p1", obj.Fee);
            dict.Add("@p2", obj.FeeMonth);

            DBHelper.ExecuteNonQuery(sql, dict);

            return obj;
        }
    }
}
