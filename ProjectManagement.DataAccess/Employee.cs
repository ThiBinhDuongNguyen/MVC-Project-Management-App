using System.ComponentModel.DataAnnotations;

namespace ProjectManagement.DataAccess.Entities
{
    public class Employee
    {
       
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Employee Number is required.")]
        [RegularExpression(@"^[a-zA-Z]{3}-\d{6}$", ErrorMessage = "Employee Number must be in the format 'ABC-123456'.")]
        public string? EmployeeNumber { get; set; }

        [Required(ErrorMessage = "Please enter Employee First Name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Employee Last Name")]
        public string? LastName { get; set; }

        public string? FullName => $"{LastName}, {FirstName}";

        // FK:
        public int? ProjectId { get; set; }

        // And nav prop:
        public Project? Project { get; set; }
    }
}
