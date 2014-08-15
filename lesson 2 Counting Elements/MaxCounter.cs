using System;

namespace lesson_2_Counting_Elements
{
    class MaxCounter
    {
        public int[] solution(int N, int[] A)           //100%
        {
            int[] temp = new int[N];
            int[] result= new int[N];
            int lastCheckpoint = 0;
            int max = 0;
            int lastMax = Array.LastIndexOf(A, N + 1);
            for(int i=0;i<lastMax;i++)
            {
                if (A[i] == N + 1)
                {
                    //temp=SetAllToMax(result, max);
                    lastCheckpoint = max;
                    continue;
                }
                temp[A[i] - 1] = temp[A[i] - 1] < lastCheckpoint ? lastCheckpoint + 1 : temp[A[i] - 1]+1;
                if (temp[A[i] - 1]  > max)
                {
                    max = temp[A[i] - 1];
                }
            }
            for (int i = 0; i < N; i++)
            {
                result[i] = max;
            }
            for (int i = lastMax+1; i < A.Length; i++)
            {
                result[A[i]-1]++;
            }
            
            return result;
        }
    }
}
