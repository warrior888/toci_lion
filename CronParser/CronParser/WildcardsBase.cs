using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronParser
{
    public abstract class WildcardsBase
    {
        public abstract List<int> ParseWildcard(string wildcardSign, string argument);

        public virtual List<int> CreateWildcardInterval(WildcardIntervalEntity wiEntity)
        {
            List<int> result = new List<int>();

            for (int i = wiEntity.IntervalMin; i <= wiEntity.IntervalMax; i++)
            {
                result.Add(i);
            }

            return result;
        }

        public static bool HasWildcard(string wildcardSign, string argument)
        {
            return argument.Contains(wildcardSign);
        }
    }
}
