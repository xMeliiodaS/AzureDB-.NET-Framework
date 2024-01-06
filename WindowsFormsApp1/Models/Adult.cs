using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Adult
    {
        public string id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Child[] children { get; set; }
        public Hobby[] hobbies { get; set; }

        public static List<Adult> ConvertAdultStringIntoList(string adultData)
        {
            if (string.IsNullOrEmpty(adultData))
                return new List<Adult>();

            return System.Text.Json.JsonSerializer.Deserialize<List<Adult>>(adultData);
        }
    }

    public class Child
    {
        public string FirstName { get; set; }
        public string DateOfBirth { get; set; }
    }

    public class Hobby
    {
        public string Name { get; set; } // The name of the Hobby
        public string Day { get; set; } // day in week that they שממשים

    }
}
