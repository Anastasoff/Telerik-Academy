namespace RegistrationForm
{
    using System;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;

    public partial class Register : Page
    {
        private readonly string[] universities = {
                                                     "Sofia University",
                                                     "Plovdiv University",
                                                     "Varna University",
                                                     "Burgas University"
                                                 };

        private readonly string[] specialties = {
                                                    "Computer Science",
                                                    "History",
                                                    "Law",
                                                    "Math",
                                                    "Chemistry"
                                                };

        private readonly string[] courses = {
                                                "Intro to History",
                                                "Intro to Law",
                                                "Intro to Math",
                                                "Intro to Chemistry"
                                            };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                this.BindData();
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            this.AddHeading();
            this.AddNames();
            this.AddFacultyNumber();
            this.AddUniversity();
            this.AddSpeciality();
            this.AddCourses();
        }

        private void BindData()
        {
            this.DropDownListUniversity.DataSource = universities;
            this.DropDownListUniversity.DataBind();

            this.DropDownListSpeciality.DataSource = specialties;
            this.DropDownListSpeciality.DataBind();

            this.ListBoxCourses.DataSource = courses;
            this.ListBoxCourses.DataBind();
        }

        private void AddHeading()
        {
            var heading = new HtmlGenericControl("h2");
            heading.InnerText = "Student Info";

            this.PanelResult.Controls.Add(heading);
        }

        private void AddNames()
        {
            var firstName = new HtmlGenericControl("strong");
            firstName.InnerText = this.TextBoxFirstName.Text;

            var lastName = new HtmlGenericControl("strong");
            lastName.InnerText = this.TextBoxLastName.Text;

            this.PanelResult.Controls.Add(firstName);
            this.PanelResult.Controls.Add(lastName);
            this.PanelResult.Controls.Add(new HtmlGenericControl("br"));
        }

        private void AddFacultyNumber()
        {
            var facultyNumber = new HtmlGenericControl("span");
            facultyNumber.InnerText = this.TextBoxFacultyNumber.Text;

            this.PanelResult.Controls.Add(facultyNumber);
            this.PanelResult.Controls.Add(new HtmlGenericControl("br"));
        }

        private void AddUniversity()
        {
            var university = new HtmlGenericControl("span");
            university.InnerText = this.DropDownListUniversity.SelectedItem.Text;

            this.PanelResult.Controls.Add(university);
            this.PanelResult.Controls.Add(new HtmlGenericControl("br"));
        }

        private void AddSpeciality()
        {
            var speciality = new HtmlGenericControl("span");
            speciality.InnerText = this.DropDownListSpeciality.SelectedItem.Text;

            this.PanelResult.Controls.Add(speciality);
            this.PanelResult.Controls.Add(new HtmlGenericControl("br"));
        }

        private void AddCourses()
        {
            var p = new HtmlGenericControl("p");

            foreach (var item in this.ListBoxCourses.GetSelectedIndices())
            {
                var course = new HtmlGenericControl("span");
                course.InnerText = this.ListBoxCourses.Items[item].Text;
                p.Controls.Add(course);
                p.Controls.Add(new HtmlGenericControl("br"));
            }

            this.PanelResult.Controls.Add(p);
        }
    }
}