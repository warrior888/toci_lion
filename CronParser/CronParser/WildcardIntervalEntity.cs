using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronParser
{
    public class WildcardIntervalEntity
    {
        public int IntervalMin { get; set; }
        public int IntervalMax { get; set; }

        public WildcardIntervalEntity(int min, int max)
        {
            IntervalMin = min;
            IntervalMax = max;
        }
    }
}
