using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime bob)
        {
            var today = DateTime.Today;
            var age = today.Year - bob.Year;

            if(bob.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}