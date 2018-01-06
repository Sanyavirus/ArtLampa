using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomMezonin.DomainModel.Entity
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public byte Age { get; set; }
        public string PassportNumber { get; set; }
        public string PassportSerial { get; set; }
        public string PassportIssueDate { get; set; }
        public string PassportIssue { get; set; }
        public string RegistrationAddress { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string FacticalAddress { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
