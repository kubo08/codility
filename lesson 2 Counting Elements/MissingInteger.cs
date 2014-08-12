using System.Collections.Generic;
using System.Linq;

namespace lesson_2_Counting_Elements
{
    internal class MissingInteger
    {
        public int solution(int[] A)
        {
            List<int> list = A.Distinct().ToList();
            list = list.Where(t => t > 0).ToList();
            list.Sort();
            for (int a = 1; a < list.Count + 1; a++)
            {
                if (!list.ElementAt(a - 1).Equals(a))
                {
                    return a;
                }
            }

            return list.Count + 1;
        }
    }
}