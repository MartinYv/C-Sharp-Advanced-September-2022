using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Date_Modifier
{
    class DateModifier
    {

        public TimeSpan GetDifference(int[] firstDate, int[] secondDate)
        {
            int firstYear = firstDate[0];
            int firstMonth = firstDate[1];
            int firstDay = firstDate[2];

            int secondYear = secondDate[0];
            int secondMonth = secondDate[1];
            int secondDay = secondDate[2];

            DateTime dateFirst = new DateTime(firstYear, firstMonth, firstDay);
            DateTime dateSecond = new DateTime(secondYear, secondMonth, secondDay);

            return dateSecond.Subtract(dateFirst);

        }
    }
}