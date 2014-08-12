namespace lesson_2_Counting_Elements
{
    class MaxCounter
    {
        public int[] solution(int N, int[] A)           //slaby performance
        {
            int[] result= new int[N];
            int max = 0;
            // write your code in C# 5.0 with .NET 4.5 (Mono)
            foreach (var item in A)
            {
                if (item == N + 1)
                {
                    result=SetAllToMax(result, max);
                    continue;
                }
                result[item-1]++;
                if (result[item-1] > max)
                {
                    max = result[item-1];
                }
            }
            
            return result;
        }

        private static int[] SetAllToMax(int[] counters, int max)
        {
            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = max;
            }
            return counters;
        }
    }
}
