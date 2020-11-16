using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toci.Lion.Test
{
    class DatesForValidation
    {
        public string Date;
        public bool IsValid;
    }
    [TestClass]
    public class DateValidationTests
    {
        List<DateValidator> dateValidators = new List<DateValidator>()
        {
            new Example(),

        };

        DatesForValidation[] Dates = new DatesForValidation[20];

        protected void Init()
        {
            Dates[0] = new DatesForValidation() { Date = "1984-08-08", IsValid = true };
            Dates[1] = new DatesForValidation() { Date = "2019-02-29", IsValid = false };
        }

        [TestMethod]
        public void DateValidatorsTests()
        {
            Init();

            //dateValidators
        }
    }
}
