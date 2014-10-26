namespace DeleteTheViewState
{
    using System;
    using System.Web.UI;

    public partial class DeleteViewState : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SubmitScriptButton_Click(object sender, EventArgs e)
        {
            var text = this.TextBoxScript.Text;
            this.ScriptResult.Text = text;
        }
    }
}