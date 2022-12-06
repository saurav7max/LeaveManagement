using Microsoft.AspNetCore.Identity;

namespace LeaveManagementWeb.Data
{
    public class Employee : IdentityUser
    {
        public string? Firstname { get; set; }

        public string? Lastname { get; set; }

        public DateTime DOB { get; set; }

        public string? TaxId { get; set; }  

        public DateTime DOJ { get; set; }
        
    }
}
