using Dernek.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.DataAccess.Abstract
{
    public interface IMemberRepository : IBaseRepository<Member>
    {
        List<Member> GetByFilter(Member member);
    }
}
