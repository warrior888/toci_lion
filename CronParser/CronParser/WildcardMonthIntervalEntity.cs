using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronParser
{
    public class WildcardMonthIntervalEntity : WildcardIntervalEntity
    {
        public WildcardMonthIntervalEntity() : base(1, 12)
        {
        }
    }
}
