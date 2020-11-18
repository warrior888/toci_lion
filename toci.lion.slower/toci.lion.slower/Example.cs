using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toci.lion.slower
{
    public class Example : Anagram
    {
        protected override bool AreDictionariesEqual(Dictionary<char, int> first, Dictionary<char, int> second)
        {
            throw new NotImplementedException();
        }
    }
}
