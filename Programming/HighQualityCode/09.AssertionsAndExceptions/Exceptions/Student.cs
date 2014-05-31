// ********************************
// <copyright file="Student.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private string firstName;
        private string lastName;
        private IList<Exam> exams;

        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("firstName", "Student's first name cannot be empty or null!");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentException("First name too short! It should be at least 2 letters!", "firstName");
                }

                if (value.Length > 50)
                {
                    throw new ArgumentException("First name too long! It should be maximum 50 letters!", "firstName");
                }

                foreach (char symbol in value)
                {
                    if (!char.IsLetter(symbol) && symbol != '-')
                    {
                        throw new ArgumentOutOfRangeException("firstName", "Invalid first name! Allowed symbols are only letters and hyphen!");
                    }
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("lastName", "Student's last name cannot be empty or null!");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentException("Last name too short! It should be at least 2 letters!", "lastName");
                }

                if (value.Length > 50)
                {
                    throw new ArgumentException("Last name too long! It should be maximum 50 letters!", "lastName");
                }

                foreach (char symbol in value)
                {
                    if (!char.IsLetter(symbol) && symbol != '-')
                    {
                        throw new ArgumentOutOfRangeException("lastName", "Invalid last name! Allowed symbols are only letters and hyphen!");
                    }
                }

                this.lastName = value;
            }
        }

        public IList<Exam> Exams
        {
            get
            {
                return this.exams;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Input value for exams is null.");
                }

                this.exams = value;
            }
        }

        public IList<ExamResult> CheckExams()
        {
            if (this.Exams == null)
            {
                throw new InvalidOperationException("Exams list cannot be null!");
            }

            if (this.Exams.Count == 0)
            {
                throw new InvalidOperationException("Exams list cannot be empty!");
            }

            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                throw new InvalidOperationException("Exams list cannot be null!");
            }

            if (this.Exams.Count == 0)
            {
                throw new InvalidOperationException("Exams list cannot be empty!");
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}