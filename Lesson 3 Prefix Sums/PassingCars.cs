using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_3_Prefix_Sums
{
    class PassingCars
    {
        public int solution(int[] A)    //100%
        {
            // write your code in C# 5.0 with .NET 4.5 (Mono)

            int west = 0;
            int count = 0;

            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] == 1)
                {
                    west++;
                }
                if (A[i] == 0)
                {
                    if (count + west > 1000000000)
                    {
                        return -1;
                    }
                    count += west;
                }
            }
            return count;
        }
    }
}
