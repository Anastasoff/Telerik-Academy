// ********************************
// <copyright file="ExamResults.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Exceptions
{
    using System;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (grade < minGrade || maxGrade < grade)
            {
                throw new ArgumentOutOfRangeException("grade", string.Format("grade must be between {0} and {1}!", minGrade, maxGrade));
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("grade", "grade cannot be a negative number!");
                }

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("minGrade", "minGrade cannot be a negative number!");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            set
            {
                if (value <= this.minGrade)
                {
                    throw new ArgumentOutOfRangeException("maxGrade", "maxGrade must be bigger than minGrade!");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("comments", "comments cannot be null or empty string!");
                }

                this.comments = value;
            }
        }
    }
}