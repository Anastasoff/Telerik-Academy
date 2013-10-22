namespace Human
{
    using System;

    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
        // : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The week salary cannot be less than zero!");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("The work hour per day are in the range 1-24 !");
                }

                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            double result = 0.0;
            result = (this.weekSalary / 5) / this.workHoursPerDay;
            return result;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, week salary: ${2}, work hours per day: {3}, money per hour: ${4:F2};",
                this.FirstName, this.LastName, this.weekSalary, this.workHoursPerDay, this.MoneyPerHour());
        }
    }
}
