using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CalculateAge
    {
       public static int Age(DateTime birthday)
        {
            // Get current date
            DateTime today = DateTime.Today;

            // Calculate age
            int age = today.Year - birthday.Year;
            if (birthday > today.AddYears(-age)) age--;

            return age;
        }
    }
}
