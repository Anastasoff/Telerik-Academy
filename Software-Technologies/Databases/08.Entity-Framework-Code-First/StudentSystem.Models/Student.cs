namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Homework> homeworks;

        public Student()
        {
            this.courses = new HashSet<Course>();
            this.homeworks = new HashSet<Homework>();
        }

        [Key, Required]
        public int StudentID { get; set; }

        [MaxLength(20), Required]
        public string FirstName { get; set; }

        [MaxLength(20), Required]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime? DateAdded { get; set; }

        public virtual ICollection<Course> Courses
        {
            get
            {
                return this.courses;
            }

            set
            {
                this.courses = value;
            }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get
            {
                return this.homeworks;
            }

            set
            {
                this.homeworks = value;
            }
        }

        public override string ToString()
        {
            string toString = string.Format("Id: {0}. {1} {2}", this.StudentID, this.FirstName, this.LastName);
            return toString;
        }
    }
}