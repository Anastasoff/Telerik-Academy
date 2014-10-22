namespace EmployeesGridView
{
    using Northwind.Data;
    using System;
    using System.Linq;

    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(this.Request.QueryString["id"]);
            var db = new NorthwindDbContext();
            var employee = db.Employees.Where(emp => emp.EmployeeID == id).ToList();
            this.DetailsViewEmployee.DataSource = employee;
            this.DetailsViewEmployee.DataBind();
        }
    }
}