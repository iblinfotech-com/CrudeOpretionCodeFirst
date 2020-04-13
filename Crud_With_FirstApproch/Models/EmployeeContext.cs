using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Crud_With_FirstApproch.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("con")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}