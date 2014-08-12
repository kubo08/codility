using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace lesson_2_Counting_Elements
{
    class FrogRiverJump
    {
        public int solution(int X, int[] A)     //100%
        {
            //List<int> bridge = A.Distinct().ToList();     //povodne
            //if (bridge.Count < X)
            //{
            //    return -1;
            //}
            //return Array.IndexOf(A, bridge.Last());   
            List<int> bridge2 = getList(A).ToList();
            if (bridge2.Count < X)
            {
                return -1;
            }
            return Array.IndexOf(A, bridge2.Last());
        }

        IEnumerable<int> getList(int[] nums)
        {
            HashSet<int> list = new HashSet<int>();
            foreach (var num in nums.Where(num => !list.Contains(num)))
            {
                list.Add(num);
                yield return num;
            }
        }
    }
}
