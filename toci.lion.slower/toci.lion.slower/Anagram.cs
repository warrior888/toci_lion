using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toci.lion.slower
{
    public abstract class Anagram
    {
        // slowo slwoo
        // bartek zapart | bratek zpaart

        Dictionary<char, int> FirstWord = new Dictionary<char, int>();
        Dictionary<char, int> SecondWord = new Dictionary<char, int>();

        public bool IsAnagram(string first, string second)
        {
            FirstWord = CountElements(first);
            SecondWord = CountElements(second);

            // compare 2 dictinaries
            return AreDictionariesEqual(FirstWord, SecondWord);
        }

        protected Dictionary<char, int> CountElements(string candidate)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < candidate.Length; i++)
            {
                if (!result.ContainsKey(candidate[i]))
                {
                    result.Add(candidate[i], 1);
                }
                else
                {
                    result[candidate[i]]++;
                }
            }

            return result;
        }

        private void dDummy()
        {
            Dictionary<char, int> first = new Dictionary<char, int>();
            Dictionary<char, int> second = new Dictionary<char, int>();

            foreach (KeyValuePair<char, int> item in first)
            {

            }
        }

        protected abstract bool AreDictionariesEqual(Dictionary<char, int> first, Dictionary<char, int> second);
    }
}
