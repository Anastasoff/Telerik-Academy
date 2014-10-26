namespace GraficWebCounter
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Web.UI;

    public partial class GraficWebcounter : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            if (Application["visitorsCount"] == null)
            {
                Application["visitorsCount"] = 1;
            }
            else
            {
                int allVisitors = Convert.ToInt32(Session["visitorsCount"]);
                Application["visitorsCount"] = (int)Application["visitorsCount"] + 1;
            }
            Application.UnLock();
            Bitmap generatedImage = new Bitmap(200, 200);
            using (generatedImage)
            {
                Graphics gr = Graphics.FromImage(generatedImage);
                using (gr)
                {
                    gr.FillRectangle(Brushes.MediumSeaGreen, 0, 0, 200, 200);

                    gr.DrawString(Application["visitorsCount"].ToString(),
                        new Font("Consolas", 40),
                        Brushes.Yellow,
                         new PointF(60, 30));

                    Response.ContentType = "image/gif";

                    generatedImage.Save(Response.OutputStream, ImageFormat.Gif);
                }
            }
        }
    }
}