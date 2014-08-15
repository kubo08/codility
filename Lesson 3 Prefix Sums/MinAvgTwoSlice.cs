namespace Lesson_3_Prefix_Sums
{
    class MinAvgTwoSlice
    {
        public int solution(int[] A)                //100%
        {
            // write your code in C# 5.0 with .NET 4.5 (Mono)
            int N = A.Length;
            int start = 0;
            int count = 0;
            double minAverage = (double)(A[1] + A[0])/2;
            int actualStart=0;
            double actualAverage=-1;
            for (int i = 1; i < N-1; i++)
            {
                if ((double)(A[i] + A[i + 1])/2 < minAverage)
                {
                    start = i;
                    minAverage = (double)(A[i] + A[i + 1]) / 2;
                }
                if ((A[i] <= minAverage ))
                {
                        actualStart = i;
                        actualAverage = (double) (A[i] + A[i + 1])/2;
                        count = 2;
                }
                else if (actualAverage != -1)
                {
                    ;
                    actualAverage = ((actualAverage*count) + A[i + 1])/++count;
                    if (actualAverage < minAverage)
                    {
                        minAverage = actualAverage;
                        start = actualStart;
                    }
                }
            }
            return start;
        }
    }
}
