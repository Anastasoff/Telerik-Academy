using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextToImageHttpHandler
{
    public partial class TextToImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGenerate_Click(object sender, EventArgs e)
        {
            string text = this.TextBoxContent.Text;

            string path = "/example.img?text=" + text;

            this.Response.Redirect(path);
        }
    }
}