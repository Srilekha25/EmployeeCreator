using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace EmployeeApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string ContractType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Ongoing { get; set; }
        public string TimeBasis { get; set; }
        public long Hours { get; set; }

        public Employee()
        {
            
        }
    }
}
