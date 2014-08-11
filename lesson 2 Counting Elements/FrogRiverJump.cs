using System;
using System.Collections.Generic;

namespace lesson_2_Counting_Elements
{
    class FrogRiverJump
    {
        public int solution(int X, int[] A)
        {
            // write your code in C# 5.0 with .NET 4.5 (Mono)
            List<int> bridge = new List<int>();
            for (int i = 1; i < X+1; i++)
            {
                bridge.Add(i);
            }

            for (int i = 0; i < A.Length; i++)
            {
                try
                {
                    bridge.Remove(A[i]);
                    if (bridge.Count == 0)
                        return i;
                }
                catch (IndexOutOfRangeException) { }
            }
            return -1;
        }
    }
}
