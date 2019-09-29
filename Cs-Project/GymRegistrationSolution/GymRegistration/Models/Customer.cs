using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRegistration.Models
{
   public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }
        public double Balance { get; set; }
        public List<Payment> Payments { get; set; }
        public List<MenuOrder> MenuOrder { get; set; }

    }
}
