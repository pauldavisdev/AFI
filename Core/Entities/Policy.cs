using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Policy
    {
        public int PolicyId { get; set; }
        public string PolicyReference { get; set; }
        public Customer Customer { get; set; }
    }
}
