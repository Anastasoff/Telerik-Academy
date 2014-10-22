namespace TextToImageHttpHandler
{
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Web;

    public class TextImageHandler : IHttpHandler
    {
        private const int ImageWidth = 500;
        private const int ImageHeight = 200;
        private readonly Color BackgroundColor = Color.YellowGreen;
        private readonly Font ImageTextFont = new Font("Arial", 20);
        private readonly Brush ImageBrush = new SolidBrush(Color.Black);

        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            string text = context.Request.QueryString["text"];

            this.GenerateImage(context, text);
        }

        private void GenerateImage(HttpContext context, string text)
        {
            Bitmap image = new Bitmap(ImageWidth, ImageHeight);
            Graphics graphics = Graphics.FromImage(image);

            graphics.Clear(BackgroundColor);
            graphics.DrawString(text, ImageTextFont, ImageBrush, 20, 10);
            context.Response.ContentType = "image/png";
            image.Save(context.Response.OutputStream, ImageFormat.Png);
        }
    }
}