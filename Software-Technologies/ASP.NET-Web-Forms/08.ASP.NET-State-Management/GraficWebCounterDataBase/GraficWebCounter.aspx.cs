namespace GraficWebCounterDataBase
{
    using GraficWebCounterDataBase.Models;
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Linq;
    using System.Web.UI;

    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataContext();
            var counter = db.Counter.FirstOrDefault();
            counter.Count = counter.Count + 1;
            Bitmap generatedImage = new Bitmap(200, 200);
            using (generatedImage)
            {
                Graphics gr = Graphics.FromImage(generatedImage);
                using (gr)
                {
                    gr.FillRectangle(Brushes.MediumSeaGreen, 0, 0, 200, 200);

                    gr.DrawString((counter.Count).ToString(),
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