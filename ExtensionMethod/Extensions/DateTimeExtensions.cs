using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExtensionMethod.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " horas";
            }
            else //if(duration.TotalDays < 365)
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Dias";
            }
            /*else
            {
                string anos = (duration.TotalDays / 365).ToString("F1", CultureInfo.InvariantCulture);
                return anos + " Anos";
            }*/
        }
    }
}
