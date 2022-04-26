using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime? DOB { get; set; }
        public string? Email { get; set; }
        public List<Policy> Policies { get; set; } = new List<Policy>();
    }
}
