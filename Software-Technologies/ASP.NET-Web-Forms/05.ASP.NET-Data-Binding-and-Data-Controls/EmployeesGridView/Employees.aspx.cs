namespace EmployeesGridView
{
    using Northwind.Data;
    using System;
    using System.Linq;

    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var db = new NorthwindDbContext();

                var employees = db.Employees.Select(emp => new
                {
                    Id = emp.EmployeeID,
                    FirstName = emp.FirstName,
                    LastName = emp.LastName
                })
                .ToList();

                this.GridViewEmployees.DataSource = employees;
                this.GridViewEmployees.DataBind();
            }
        }
    }
}