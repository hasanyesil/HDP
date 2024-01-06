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
            throw new NotImplementedException();
        }

        public List<Member> GetByFilter(Member member)
        {
            throw new NotImplementedException();
        }

        public Member Insert(Member obj)
        {
            string sql = @"insert into Member (Id, MemberName, MemberSurname, BloodType, BirthDate, City, IsActive, PhoneNumber)
                            values (?,?,?,?,?,?,?,?)";

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Id", obj.Id);
            dict.Add("MemberName", obj.MemberName);
            dict.Add("MemberSurname", obj.MemberSurname);
            dict.Add("BloodType", Convert.ToByte(obj.BloodType));
            dict.Add("BirthDate", obj.BirthDate);
            dict.Add("City", Convert.ToInt32(obj.City));
            dict.Add("IsActive", Convert.ToByte(obj.IsActive));
            dict.Add("PhoneNumber", obj.PhoneNumber);

            int effectedRow =  DBHelper.ExecuteNonQuery(sql, dict);

            return obj;
        }

        public Member Update(Member obj)
        {
            throw new NotImplementedException();
        }
    }
}
