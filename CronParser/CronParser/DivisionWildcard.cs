﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronParser
{
    public class DivisionWildcard : WildcardsBase
    {
        public const string DivisionWildcardSign = "/";

        public override List<int> ParseWildcard(string wildcardSign, string argument)
        {
            throw new NotImplementedException();
        }
    }
}
