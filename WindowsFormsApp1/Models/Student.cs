using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Student
    {
        public string id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }


        public string MiddleName { get; set; }


        public Address[] addresses { get; set; }
        public Course[] courses { get; set; }

        public Student(string id)
        {
            this.id = id;
        }

        public Student()
        {

        }
        
        public static List<Student> ConvertStudentStringIntoList (string studentesData)
        {
            if (string.IsNullOrEmpty(studentesData))
                return new List<Student>();

            return System.Text.Json.JsonSerializer.Deserialize<List<Student>>(studentesData);
        }


        // After i did it alone
        public override string ToString()
        {
            if (this == null)
                return "No data";

            string studentAsString = string.Empty;

            studentAsString += "ID: " + this.id + "\n";
            if (!string.IsNullOrEmpty(this.FirstName))
                studentAsString += "Nice to meet you " + this.FirstName;
            else
                studentAsString += "Please update your first name...";

            return studentAsString;
        }

    }
}
