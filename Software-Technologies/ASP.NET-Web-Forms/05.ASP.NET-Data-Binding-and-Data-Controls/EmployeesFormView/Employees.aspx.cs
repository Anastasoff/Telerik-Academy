namespace EmployeesFormView
{
    using Northwind.Data;
    using System;
    using System.Linq;
    using System.Web.UI.WebControls;

    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var db = new NorthwindDbContext();
                var employees = db.Employees.ToList();
                this.FormViewEmployee.DataSource = employees;
                this.FormViewEmployee.DataBind();
            }
        }

        protected void FormViewEmployee_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            var db = new NorthwindDbContext();
            var employees = db.Employees.ToList();
            this.FormViewEmployee.PageIndex = e.NewPageIndex;
            this.FormViewEmployee.DataSource = employees;
            this.FormViewEmployee.DataBind();
        }
    }
}