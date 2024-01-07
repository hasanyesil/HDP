using Dernek.DataAccess.Abstract;
using Dernek.DataAccess.Helper;
using Dernek.Entity.Enums;
using Dernek.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.DataAccess.Concrates
{
    public class MemberRepository : IMemberRepository
    {
        public Member Delete(Member obj)
        {
            throw new NotImplementedException();
        }

        public Member Get(Member obj)
        {
            throw new NotImplementedException();
        }

        public List<Member> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllAsDt()
        {
            string sql = @"select * from Member";

            return DBHelper.ExecuteReader(sql, null);
        }

        public List<Member> GetByFilter(Member member)
        {
            throw new NotImplementedException();
        }

        public Member GetById(string id)
        {
            string sql = @"select * from Member where Id = ?";

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Id", id);

            DataTable dt = DBHelper.ExecuteReader(sql, dict);

            Member member;
            if(dt.Rows.Count > 0)
            {
                member = new Member()
                {
                    Id = dt.Rows[0]["Id"].ToString(),
                    BloodType = (BloodTypes)Convert.ToByte(dt.Rows[0]["BloodType"]),
                    City = (Cities)Convert.ToInt32(dt.Rows[0]["City"]),
                    BirthDate = (DateTime)dt.Rows[0]["BirthDate"],
                    MemberName = dt.Rows[0]["MemberName"].ToString(),
                    MemberStatus = (MemberStatuses)Convert.ToByte(dt.Rows[0]["MemberStatus"]),
                    PhoneNumber = dt.Rows[0]["PhoneNumber"].ToString(),
                    MemberSurname = dt.Rows[0]["MemberSurname"].ToString(),
                };
            }
            else
            {
                member = new Member();
            }

            return member;
        }

        public DataTable GetDebtorsByDate(DateTime startDate, DateTime endDate)
        {
            string sql = @"select m.* from Member m where m.id not in (select MemberId from Payment where PaymentDate >= ? and PaymentDate < ?)";

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("StartDate", startDate);
            dict.Add("EndDate", endDate);

            return DBHelper.ExecuteReader(sql, dict);
        }

        public DataTable GetNotInMembers(string memberList)
        {
            string sql = @"select * from Member where m.id not in (?)";
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("@p1", memberList);

            return DBHelper.ExecuteReader(sql, dict);
        }

        public DataTable GetPayingUserByDate(DateTime startDate, DateTime endDate)
        {
            string sql = @"select m.* from Member m where m.id in (select MemberId from Payment where PaymentDate > ? and PaymentDate < ?)";

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("StartDate", startDate);
            dict.Add("EndDate", endDate);

            return DBHelper.ExecuteReader(sql, dict);
        }

        public Member Insert(Member obj)
        {
            string sql = @"insert into Member (Id, MemberName, MemberSurname, BloodType, BirthDate, City, MemberStatus, PhoneNumber, Mail)
                            values (?,?,?,?,?,?,?,?)";

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Id", obj.Id);
            dict.Add("MemberName", obj.MemberName);
            dict.Add("MemberSurname", obj.MemberSurname);
            dict.Add("BloodType", Convert.ToByte(obj.BloodType));
            dict.Add("BirthDate", obj.BirthDate);
            dict.Add("City", Convert.ToInt32(obj.City));
            dict.Add("MemberStatus", Convert.ToByte(obj.MemberStatus));
            dict.Add("PhoneNumber", obj.PhoneNumber);
            dict.Add("Mail", obj.Mail);

            int effectedRow =  DBHelper.ExecuteNonQuery(sql, dict);

            return obj;
        }

        public Member Update(Member obj)
        {
            string sql = @"update Member set MemberName = ?, MemberSurname = ?, BloodType = ?, BirthDate = ?, City = ?, MemberStatus = ?, PhoneNumber = ?, Mail = ? where id = ?";
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("MemberName", obj.MemberName);
            dict.Add("MemberSurname", obj.MemberSurname);
            dict.Add("BloodType", Convert.ToByte(obj.BloodType));
            dict.Add("BirthDate", obj.BirthDate);
            dict.Add("City", Convert.ToInt32(obj.City));
            dict.Add("MemberStatus", Convert.ToByte(obj.MemberStatus));
            dict.Add("PhoneNumber", obj.PhoneNumber);
            dict.Add("Mail", obj.Mail);
            dict.Add("Id", obj.Id);

            DBHelper.ExecuteNonQuery(sql, dict);

            return obj;
        }
    }
}
