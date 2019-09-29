using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRegistration.Models
{
  public  class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public byte EntryQuantity { get; set; }
        public bool Status { get; set; }
        public List<Payment> Payments { get; set; }

    }
}
