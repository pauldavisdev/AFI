using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class RegistrationDetailDto
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime? DOB { get; set; }
        public string? Email { get; set; }
        public int PolicyReferenceNumber { get; set; }
    }
}
