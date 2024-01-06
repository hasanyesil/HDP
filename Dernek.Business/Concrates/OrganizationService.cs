using Dernek.Business.Abstract;
using Dernek.DataAccess.Abstract;
using Dernek.DataAccess.Concrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Business.Concrates
{
    public class OrganizationService : IOrganizationService
    {
        IOrganizationRepository organizationRepository;

        public OrganizationService()
        {
            organizationRepository = new OrganizationRepository();
        }

        public decimal GetOrganizationFee()
        {
            return organizationRepository.GetOrganizationFee();
        }
    }
}
