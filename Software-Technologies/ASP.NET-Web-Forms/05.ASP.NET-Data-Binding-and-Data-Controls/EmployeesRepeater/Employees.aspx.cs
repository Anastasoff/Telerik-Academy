namespace EmployeesRepeater
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
                var employees = db.Employees.ToList();
                this.RepeaterEmployees.DataSource = employees;
                this.RepeaterEmployees.DataBind();
            }
        }
    }
}