using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRegistration.Models
{
   public class Payment
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int PackageId { get; set; }
        public byte PackageEntryQuantity { get; set; }
        public Package Package { get; set; }
        public bool Status { get; set; }
    }
}
