namespace SesionObjectContent
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI;

    public partial class Index : Page
    {
        private List<string> listTextEvents = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["click"] != null)
            {
                listTextEvents = (List<string>)Session["Click"];
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Session["click"] = listTextEvents;
        }

        protected void ButtonAddLoad_Click(object sender, EventArgs e)
        {
            listTextEvents.Add(this.TextBoxInput.Text.ToString());
            Response.Write(string.Join("<br/>", listTextEvents));
        }
    }
}