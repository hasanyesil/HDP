using Dernek.Entity.Enums;
using System.Collections.Generic;

namespace Dernek.Entity.Models
{
    public class OrganizationFee : BaseEntity
    {
        #region Public Properties
        public int FeeMonth { get; set; }
        
        public decimal Fee { get; set; }

        #endregion Public Properties

    }
}
