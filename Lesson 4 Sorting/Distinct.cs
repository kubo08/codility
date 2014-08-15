using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_4_Sorting
{
    class Distinct
    {
        public int solution(int[] A)        //100%
        {
            // write your code in C# 5.0 with .NET 4.5 (Mono)
            return GetDistinct(A).ToList().Count;
        }

        private IEnumerable<int> GetDistinct(int[] A)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var num in A.Where(num => !set.Contains(num)))
            {
                set.Add(num);
                yield return num;
            }
        }
    }
}
