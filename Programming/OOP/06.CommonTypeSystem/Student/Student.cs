// 1. Define a class Student, which contains data about a student:
// first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. 
// Use an enumeration for the specialties, universities and faculties. 
// Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
namespace Student
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        #region Constructors

        public Student()
        {
        }

        public Student(string firstName, string middleName, string lastName, string ssn)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
        }

        public Student(string firstName, string middleName, string lastName, string ssn, string address,
            string phoneNumber, string email, uint course, University university, Faculty faculty, Specialty specialty)
            : this(firstName, middleName, lastName, ssn)
        {
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        #endregion

        #region Properties

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public uint Course { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        #endregion

        #region Operators

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }

        #endregion

        #region Methods

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            if (object.ReferenceEquals(this, obj))
            {
                return true;
            }

            if (!object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (!object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }

            if (!object.Equals(this.LastName, student.LastName))
            {
                return false;
            }

            if (this.SSN != student.SSN)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.LastName.GetHashCode() ^ this.SSN.GetHashCode();
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("Name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            result.AppendLine("SSN: " + this.SSN);
            result.AppendLine("Address: " + this.Address);
            result.AppendLine("Phone number: " + this.PhoneNumber);
            result.AppendLine("E-mail: " + this.Email);
            result.AppendLine("Course: " + this.Course);
            result.AppendLine("Specialty: " + this.Specialty);
            result.AppendLine("University: " + this.University);
            result.AppendLine("Faculty: " + this.Faculty);

            return result.ToString();
        }

        // 2. Add implementations of the ICloneable interface. 
        // The Clone() method should deeply copy all object's fields into a new object of type Student.
        public Student Clone()
        {
            Student newStudent = new Student();

            newStudent.FirstName = this.FirstName;
            newStudent.MiddleName = this.MiddleName;
            newStudent.LastName = this.LastName;
            newStudent.SSN = this.SSN;
            newStudent.Address = this.Address;
            newStudent.PhoneNumber = this.PhoneNumber;
            newStudent.Email = this.Email;
            newStudent.Course = this.Course;
            newStudent.Specialty = this.Specialty;
            newStudent.University = this.University;
            newStudent.Faculty = this.Faculty;

            return newStudent;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        // 3. Implement the  IComparable<Student> interface to compare students by names 
        // (as first criteria, in lexicographic order) and by social security number 
        // (as second criteria, in increasing order).
        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MiddleName != other.MiddleName)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }

            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }

            if (this.SSN != other.SSN)
            {
                return this.SSN.CompareTo(other.SSN);
            }

            return 0;
        }

        #endregion
    }
}
