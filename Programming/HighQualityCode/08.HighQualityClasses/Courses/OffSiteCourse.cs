// ********************************
// <copyright file="OffSiteCourse.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Courses
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents an off-site software academy course.
    /// </summary>
    public class OffSiteCourse : Course
    {
        /// <summary>
        /// The name of the town in which the course is held.
        /// </summary>
        private string town;

        /// <summary>
        /// Initializes a new instance of the <see cref="OffSiteCourse"/> class.
        /// </summary>
        public OffSiteCourse(string name, string teacherName, IList<string> students, string town)
            : base(name, teacherName, students)
        {
            this.Town = town;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffSiteCourse"/> class.
        /// </summary>
        public OffSiteCourse(string name)
            : this(name, null, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffSiteCourse"/> class.
        /// </summary>
        public OffSiteCourse(string name, string teacherName)
            : this(name, teacherName, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffSiteCourse"/> class.
        /// </summary>
        public OffSiteCourse(string name, string teacherName, IList<string> students)
            : this(name, teacherName, students, null)
        {
        }

        /// <summary>
        /// Gets or sets the town of the course.
        /// </summary>
        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                this.town = value;
            }
        }

        /// <summary>
        /// Returns the string representation of the course info -
        /// its base class info, plus the town name.
        /// </summary>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { ");
            result.Append(base.ToString());

            if (this.Town != null)
            {
                result.AppendFormat("; Town = {0}", this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}