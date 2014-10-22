using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Northwind.Data;
using Northwind.Model;

namespace EmployeesListView
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var db = new NorthwindDbContext();
                var employees = db.Employees.ToList();
                this.ListViewEmployees.DataSource = employees;
                this.ListViewEmployees.DataBind();
            }
        }
    }
}