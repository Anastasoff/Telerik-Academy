using FileUpload.Data;
using FileUpload.Model;
using System;
using System.IO;
using System.IO.Compression;
using System.Web;

namespace FileUpload
{
    public partial class Default : System.Web.UI.Page
    {
        private const int MAX_FILE_SIZE = 1024000;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            if (this.FileUploadArchive.HasFile)
            {
                try
                {
                    var archiveFile = this.FileUploadArchive.PostedFile;
                    if (archiveFile.ContentType != "application/octet-stream")
                    {
                        this.LabelStatus.Text = "Only zip archives are allowed";
                    }
                    else if (archiveFile.ContentLength > MAX_FILE_SIZE)
                    {
                        this.LabelStatus.Text = string.Format("Max file size is {0} bytes", MAX_FILE_SIZE);
                    }
                    else
                    {
                        ProcessArchiveFile(archiveFile);
                        this.LabelStatus.Text = "File uploaded!";
                    }
                }
                catch (Exception ex)
                {
                    this.LabelStatus.Text = ex.Message;
                }
            }
        }

        private void ProcessArchiveFile(HttpPostedFile archiveFile)
        {
            var stream = archiveFile.InputStream;
            var zip = new ZipArchive(stream);
            var files = zip.Entries;

            foreach (var file in files)
            {
                if (file.FullName.EndsWith(".txt"))
                {
                    var fileStream = file.Open();
                    var fileName = Path.GetFileNameWithoutExtension(file.FullName);
                    using (var sr = new StreamReader(fileStream))
                    {
                        var fileContent = sr.ReadToEnd();
                        SaveToDatabase(fileName, fileContent);
                    }
                }
            }
        }

        private int SaveToDatabase(string fileName, string fileContent)
        {
            var db = new FileUploadDb();
            var file = new TextFile()
            {
                Name = fileName,
                Content = fileContent
            };
            db.TextFiles.Add(file);
            return db.SaveChanges();
        }
    }
}