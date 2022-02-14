using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.R.InfraAlu.CrossCutting.Helpers
{
    public static class DateTimeOffExtensions
    {
        public static int GetCurrentAge(this DateTimeOffset dateTimeOffset)
        {
            var dateToCalulateTo = DateTime.UtcNow;

            int age = dateToCalulateTo.Year - dateTimeOffset.Year;

            if (dateToCalulateTo < dateTimeOffset.AddYears(age))
            {
                age--;
            }

            return age;
        }

    }
}
