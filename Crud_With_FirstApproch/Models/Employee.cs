using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crud_With_FirstApproch.Models
{
    public class Employee
    {   

        public int EmployeeId { get; set; }
        [Required]
        public string EmpName { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthofDate { get; set; }
        public string Gender { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string Phone { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        public string City { get; set; }
        [Required]
        public string Department { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime JoiningDate { get; set; }
    }
}