using System;

namespace Dernek.Entity.Models
{
    public abstract class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        
        public DateTime? ModifiedDate { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
