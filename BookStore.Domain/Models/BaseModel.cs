using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Models
{
    public class BaseModel
    {
        public bool IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
