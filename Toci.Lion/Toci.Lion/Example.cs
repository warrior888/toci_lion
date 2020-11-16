using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Lion
{
    public class Example : DateValidator
    {
        public override bool ValidateMonthAndDay(int year, int month, int day)
        {
            //??
            return true;
        }
    }
}
