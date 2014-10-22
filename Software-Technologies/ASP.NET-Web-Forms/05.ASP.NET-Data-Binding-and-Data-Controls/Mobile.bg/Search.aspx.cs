namespace Mobile.bg
{
    using Mobile.bg.DataModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web.UI;

    public partial class Search : Page
    {
        private static List<Manufacturer> manufacturers;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                manufacturers = this.LoadManufacturers();

                this.DropDownManufacturer.DataSource = manufacturers;
                this.DropDownManufacturer.SelectedIndex = 0;
                this.DropDownModel.DataSource = manufacturers.First().Models;

                string[] engines = { "Diesel", "Petrol", "Hybrid", "Electric" };
                this.RadioButtonEngine.DataSource = engines;

                string[] extras = { "AC", "Alarm" };
                this.CheckBoxExtras.DataSource = extras;
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.DataBind();
        }

        protected void DropDownManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DropDownModel.DataSource = manufacturers[this.DropDownManufacturer.SelectedIndex].Models;
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            StringBuilder resultingSearch = new StringBuilder();
            resultingSearch.Append("Manufacturer: " + this.DropDownManufacturer.SelectedItem.Text + "<br />");
            resultingSearch.Append("Model: " + this.DropDownModel.SelectedItem.Text + "<br />");
            resultingSearch.Append("Engine: " + this.RadioButtonEngine.SelectedItem.Text + "<br />");
            resultingSearch.Append("Extras:<br />");
            for (int i = 0; i < this.CheckBoxExtras.Items.Count; i++)
            {
                var currentItem = this.CheckBoxExtras.Items[i];
                if (currentItem.Selected)
                {
                    resultingSearch.Append("- " + currentItem.Text + "<br />");
                }
            }
            this.LiteralResult.Text = resultingSearch.ToString();
        }

        private List<Manufacturer> LoadManufacturers()
        {
            var loadedManufacturers = new List<Manufacturer>();

            var audi = new Manufacturer("Audi");
            audi.Models.Add("A4");
            audi.Models.Add("A5");
            audi.Models.Add("A6");
            audi.Models.Add("A8");
            loadedManufacturers.Add(audi);

            var bmw = new Manufacturer("BMW");
            bmw.Models.Add("M1");
            bmw.Models.Add("M3");
            bmw.Models.Add("M4");
            bmw.Models.Add("M5");
            loadedManufacturers.Add(bmw);

            var mercedes = new Manufacturer("Mercedes");
            mercedes.Models.Add("A Class");
            mercedes.Models.Add("C Class");
            mercedes.Models.Add("E Class");
            mercedes.Models.Add("S Class");
            loadedManufacturers.Add(mercedes);

            return loadedManufacturers;
        }
    }
}