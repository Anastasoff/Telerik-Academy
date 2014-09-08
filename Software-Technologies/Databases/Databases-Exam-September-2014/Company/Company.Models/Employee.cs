namespace Company.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        public Employee()
        {
            Employees1 = new HashSet<Employee>();
            EmployeesProjects = new HashSet<EmployeesProject>();
            Reports = new HashSet<Report>();
        }

        public int EmployeeID { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Column(TypeName = "money")]
        public decimal YearSalary { get; set; }

        public int? ManagerID { get; set; }

        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Employee> Employees1 { get; set; }

        public virtual Employee Employee1 { get; set; }

        public virtual ICollection<EmployeesProject> EmployeesProjects { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
    }
}
