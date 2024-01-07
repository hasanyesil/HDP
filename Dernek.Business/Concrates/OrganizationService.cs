using Dernek.Business.Abstract;
using Dernek.DataAccess.Abstract;
using Dernek.DataAccess.Concrates;
using Dernek.Entity.Models;
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

        public decimal GetOrganizationFeeByMonth(int month)
        {
            return organizationRepository.GetByMonth(month).Fee;
        }

        public List<OrganizationFee> GetAll()
        {
            return organizationRepository.GetAll();
        }

        public void UpdateFee(OrganizationFee organizationFee)
        {
            organizationRepository.Update(organizationFee);
        }
    }
}
