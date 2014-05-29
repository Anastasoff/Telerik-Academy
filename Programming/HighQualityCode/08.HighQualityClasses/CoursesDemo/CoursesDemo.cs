// ********************************
// <copyright file="SoftwareAcademyDemo.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace CoursesDemo
{
    using System;
    using System.Collections.Generic;

    using Courses;

    /// <summary>
    /// Used to test the software academy courses functionality.
    /// </summary>
    public class CoursesDemo
    {
        /// <summary>
        /// The entry point of the program.
        /// </summary>
        public static void Main()
        {
            LocalCourse localCourse = new LocalCourse("High-Quality Programming Code");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Ultimate";
            Console.WriteLine(localCourse);

            localCourse.Students = new List<string>() { "Peter", "Maria" };
            Console.WriteLine(localCourse);

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.AddStudent("Milena");
            localCourse.AddStudent("Todor");
            Console.WriteLine(localCourse);

            OffSiteCourse offsiteCourse = new OffSiteCourse("PHP and WordPress Development", "Mario Peshev", new List<string>() { "Thomas", "Anne", "Steve" });
            Console.WriteLine(offsiteCourse);
        }
    }
}