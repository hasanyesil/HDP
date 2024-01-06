﻿using Dernek.Entity.Enums;
using System.Collections.Generic;

namespace Dernek.Entity.Models
{
    public class Organization : BaseEntity
    {
        #region Public Properties
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public PricePeriods PricePeriod { get; set; }
        #endregion Public Properties

        #region Relational Properties

        public virtual List<Member> Members { get; set; }

        #endregion Relational Properties
    }
}
