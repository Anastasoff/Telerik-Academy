// ********************************
// <copyright file="LocalCourse.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Courses
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents a local software academy course.
    /// </summary>
    public class LocalCourse : Course
    {
        /// <summary>
        /// The name of the lab where the course is held.
        /// </summary>
        private string lab;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class.
        /// </summary>
        public LocalCourse(string name, string teacherName, IList<string> students, string lab)
            : base(name, teacherName, students)
        {
            this.Lab = lab;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class.
        /// </summary>
        public LocalCourse(string name)
            : this(name, null, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class.
        /// </summary>
        public LocalCourse(string name, string teacherName)
            : this(name, teacherName, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class.
        /// </summary>
        public LocalCourse(string name, string teacherName, IList<string> students)
            : this(name, teacherName, students, null)
        {
        }

        /// <summary>
        /// Gets or sets the name of the course lab.
        /// </summary>
        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                this.lab = value;
            }
        }

        /// <summary>
        /// Returns the string representation of the course info -
        /// its base class info, plus the lab name.
        /// </summary>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { ");
            result.Append(base.ToString());

            if (this.Lab != null)
            {
                result.AppendFormat("; Lab = {0}", this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}