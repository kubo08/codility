using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_3_Prefix_Sums
{
    class CountDiv
    {
        public int solution(int A, int B, int K)    //100%
        {
            // write your code in C# 5.0 with .NET 4.5 (Mono)
            return ((int)Math.Floor((double)B / K) - (int)Math.Ceiling((double)A / K))+1;
        }
    }
}
