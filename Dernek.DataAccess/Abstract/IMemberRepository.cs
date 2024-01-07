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
    public interface IMemberRepository : IBaseRepository<Member>
    {
        List<Member> GetByFilter(Member member);
        Member GetById(string id);

        DataTable GetDebtorsByDate(DateTime startDate, DateTime endDate);

        DataTable GetPayingUserByDate(DateTime startDate, DateTime endDate);

        DataTable GetNotInMembers(string memberList);
    }
}
