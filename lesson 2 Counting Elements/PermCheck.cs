using System;

namespace lesson_2_Counting_Elements
{
    class PermCheck
    {
        public int solution(int[] A)            //100%
        {
            // write your code in C# 5.0 with .NET 4.5 (Mono)
            int[] IsElement = new int[A.Length];

            foreach (var item in A)
            {
                try
                {
                    if (IsElement[item - 1] != 0)
                    {
                        return 0;
                    }
                    IsElement[item - 1] = 1;
                }
                catch (IndexOutOfRangeException)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
