namespace Company
{
    using Company.Data;
    using System;
    using System.Linq;
    using System.Threading;

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Employee> GridViewEmployees_GetData()
        {
            var db = new NorthwindEntities();
            var employees = db.Employees;

            return employees;
        }

        protected void GridViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GridViewOrders.DataSource = null;
            this.GridViewOrders.DataBind();
            Thread.Sleep(5000);

            int empId = int.Parse(this.GridViewEmployees.SelectedDataKey.Value.ToString());
            var db = new NorthwindEntities();
            var orders = db.Orders.Where(o => o.EmployeeID == empId).ToList();

            this.GridViewOrders.DataSource = orders;
            this.GridViewOrders.DataBind();
        }
    }
}