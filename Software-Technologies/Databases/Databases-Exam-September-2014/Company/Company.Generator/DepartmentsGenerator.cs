namespace Company.Generator
{
    using Company.Data;
    using Company.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DepartmentsGenerator
    {
        private const string allLeters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const int MinDepartmentNameLength = 10;
        private const int MaxDepartmentNameLength = 50;
        private static CompanyDbContext db;
        private static Random rnd;

        public static void Generate(int count)
        {
            db = new CompanyDbContext();
            rnd = RandomGenerator.GetInstance;
            var departments = new HashSet<Department>();

            for (int i = 0; i < count; i++)
            {
                int currentNameRndLength = rnd.Next(MinDepartmentNameLength, MaxDepartmentNameLength + 1);
                string currentName = GenerateRandomName(currentNameRndLength);
                var currentDepartment = new Department();
                currentDepartment.Name = currentName;
                db.Departments.Add(currentDepartment);
            }

            db.SaveChanges();
        }

        private static string GenerateRandomName(int length)
        {
            StringBuilder sb = new StringBuilder();
            string namePrefix = "dep-";
            sb.Append(namePrefix);
            for (int i = 0; i < length - namePrefix.Length; i++)
            {
                var currentChar = allLeters[rnd.Next(0, allLeters.Length)];
                sb.Append(currentChar);
            }

            return sb.ToString();
        }
    }
}