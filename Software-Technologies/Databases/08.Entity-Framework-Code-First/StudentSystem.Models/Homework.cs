namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Homework
    {
        [Key, Required]
        public int HomeworkID { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public DateTime TimeSent { get; set; }

        public int StudentID { get; set; }

        public virtual Student Student { get; set; }

        public int CourseID { get; set; }

        public virtual Course Course { get; set; }
    }
}