namespace FileUpload.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using FileUpload.Model;
    using FileUpload.Data.Migrations;

    public class FileUploadDb : DbContext
    {
        public FileUploadDb()
            : base("name=FileUploadDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FileUploadDb, Configuration>());
        }

        public IDbSet<TextFile> TextFiles { get; set; }
    }
}