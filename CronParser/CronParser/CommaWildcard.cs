using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronParser
{
    public class CommaWildcard : WildcardsBase
    {
        public const string CommaWildcardSign = ",";

        public override List<int> ParseWildcard(string wildcardSign, string argument)
        {
            throw new NotImplementedException();
        }
    }
}
