using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Lion
{
    public abstract class DateValidator
    {
        // public
        // protected
        // private
        // true false
        // 1984-08-08
        public bool ParseAndValidateDate(string dateCandidate)
        {
            if (dateCandidate.Length != 10)
            {
                return false;
            }

            string[] elements = dateCandidate.Split(new[] { "-"}, StringSplitOptions.None);

            if (elements.Length != 3)
            {
                return false;
            }

            int year, month, day;

            int.TryParse(elements[0], out year);
            int.TryParse(elements[1], out month);
            int.TryParse(elements[2], out day);

            ValidateMonthAndDay(year, month, day);

            return true;
        }

        public abstract bool ValidateMonthAndDay(int year, int month, int day);
    }
}
