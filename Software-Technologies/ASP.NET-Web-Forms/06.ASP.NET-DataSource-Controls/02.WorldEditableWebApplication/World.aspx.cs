using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.WorldEditableWebApplication
{
    public partial class World : System.Web.UI.Page
    {
        protected string GetImage(object img)
        {
            string result = "";
            if (img != null)
            {
                result = "data:image/jpg;base64," + Convert.ToBase64String((byte[])img);
            }
            return result;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ListBoxContinent.SelectedIndex = 1;
            }
        }
        protected void ListBoxContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TextBoxContinentName.Text = this.ListBoxContinent.SelectedItem.Text;
        }
        protected void ButtonAddContinent_Click(object sender, EventArgs e)
        {
            string name = this.TextBoxContinentName.Text;
            if(name != "")
            {
                var context = new WorldDBEntities();
                var continent = new Continent(){ Name= name };
                using(context)
                {
                    context.Continents.Add(continent);
                    context.SaveChanges();
                    this.ListBoxContinent.DataBind();
                }
            }
        }
        protected void ButtonRemoveContinent_Click(object sender, EventArgs e)
        {
            int selectedContinent;
            if (int.TryParse(this.ListBoxContinent.SelectedValue, out selectedContinent))
            {
                var context = new WorldDBEntities();
                var continent = context.Continents.Find(selectedContinent);
                using (context)
                {
                    context.Continents.Remove(continent);
                    context.SaveChanges();
                    this.ListBoxContinent.DataBind();
                }
            }
        }
        protected void ImageButtonChangeFlag_Click(object sender, ImageClickEventArgs e)
        {
            int editIndex = this.GridViewCountries.EditIndex;
            var fileUpload = this.GridViewCountries.Rows[editIndex].FindControl("ChangeFlagPicture") as FileUpload;
            string validationCheckMessage = "";
            if (fileUpload.HasFile)
            {
                validationCheckMessage = ValidateUploadFile(fileUpload.PostedFile.FileName);
            }
            if (validationCheckMessage == "")
            {
                if (fileUpload.HasFile)
                {
                    Byte[] imgByte = null;
                    HttpPostedFile File = fileUpload.PostedFile;
                    imgByte = new Byte[File.ContentLength];
                    File.InputStream.Read(imgByte, 0, File.ContentLength);

                    int selectedCountry;
                    if (int.TryParse(this.GridViewCountries.DataKeys[editIndex].Value.ToString(), out selectedCountry))
                    {
                        var context = new WorldDBEntities();
                        using (context)
                        {
                            var country = context.Countries.Find(selectedCountry);
                            if (country != null)
                            {
                                country.Flag = imgByte;
                                context.SaveChanges();
                                this.GridViewCountries.DataBind();
                            }
                        }
                    }
                }
            }
        }
        protected void ButtonDisplayAddCountry_Click(object sender, EventArgs e)
        {
            this.GridViewCountries.ShowFooter = true;
        }
        protected void ButtonAddCountry_Click(object sender, EventArgs e)
        {
            var fileUpload = this.GridViewCountries.FooterRow.FindControl("AddFlagPicture") as FileUpload;
            string validationCheckMessage = "";
            if (fileUpload.HasFile)
            {
                validationCheckMessage = ValidateUploadFile(fileUpload.PostedFile.FileName);
            }
            if (validationCheckMessage == "")
            {
                if (!string.IsNullOrEmpty(ViewState["Name"].ToString()) &&
                    !string.IsNullOrEmpty(ViewState["Population"].ToString()) &&
                    !string.IsNullOrEmpty(ViewState["Language"].ToString()) &&
                    !string.IsNullOrEmpty(ViewState["ContinentId"].ToString())
                    )
                {
                    Byte[] imgByte = null;
                    if (fileUpload.HasFile)
                    {
                        HttpPostedFile File = fileUpload.PostedFile;
                        imgByte = new Byte[File.ContentLength];
                        File.InputStream.Read(imgByte, 0, File.ContentLength);
                    }

                    var context = new WorldDBEntities();
                    using (context)
                    {
                        var country = new Country()
                        {
                            Name = ViewState["Name"].ToString(),
                            Population = int.Parse(ViewState["Population"].ToString()),
                            Language = ViewState["Language"].ToString(),
                            ContinentId = int.Parse(ViewState["ContinentId"].ToString()),
                            Flag = imgByte
                        };
                        context.Countries.Add(country);
                        context.SaveChanges();
                        this.GridViewCountries.DataBind();

                        ViewState["Name"] = "";
                        ViewState["Population"] = "";
                        ViewState["Language"] = "";
                        ViewState["ContinentId"] = "";
                        this.GridViewCountries.ShowFooter = false;
                    }
                }
            }
            else
            {
                var label = this.GridViewCountries.FooterRow.FindControl("LabelAddFlagPictureValidate") as Label;
                label.ForeColor = System.Drawing.Color.Red;
                label.Text = validationCheckMessage;
            }
        }
        protected void CountryNameInsert_PreRender(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            ViewState["Name"] = tb.Text;
        }
        protected void CountryPopulationInsert_PreRender(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            var text = tb.Text;
            if (!string.IsNullOrWhiteSpace(text))
            {
                ViewState["Population"] = int.Parse(text);
            }
        }
        protected void CountryLanguageInsert_PreRender(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            ViewState["Language"] = tb.Text;
        }
        protected void DropDownListContinentInsert_PreRender(object sender, EventArgs e)
        {
            var ddl = (DropDownList)sender;
            var selectedValue = ddl.SelectedValue;
            if (!string.IsNullOrWhiteSpace(selectedValue))
            {
                ViewState["ContinentId"] = int.Parse(selectedValue);
            }
        }
        protected string ValidateUploadFile(string fileName)
        {
            string[] validFileTypes = { "bmp", "gif", "png", "jpg", "jpeg", "tiff"};
            string ext = System.IO.Path.GetExtension(fileName);

            for (int i = 0; i < validFileTypes.Length; i++)
            {
                if (ext == "." + validFileTypes[i])
                {
                    return "";
                }
            }

            return "Invalid File. Please upload a File with extension " +
                                   string.Join(", ", validFileTypes);
        }

        protected void ButtonInsertTown_Click(object sender, EventArgs e)
        {
            this.ListViewTowns.InsertItemPosition = InsertItemPosition.LastItem;
        }

        protected void ListViewTowns_ItemCanceling(object sender, ListViewCancelEventArgs e)
        {
            this.ListViewTowns.InsertItemPosition = InsertItemPosition.None;
        }

        protected void DropDownListCountryInsert_PreRender(object sender, EventArgs e)
        {
            var ddl = (sender as DropDownList);
            int countryId;
            if(int.TryParse(this.GridViewCountries.DataKeys[this.GridViewCountries.SelectedIndex].Value.ToString(), out countryId))
            {
                for (int i = 0; i < ddl.Items.Count; i++)
                {
                    if (ddl.Items[i].Value == countryId.ToString())
                    {
                        ddl.SelectedIndex = i;
                        break;
                    }
                }                
            }

        }
    }
}