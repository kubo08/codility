using System;

namespace Lesson_3_Prefix_Sums
{
    class GenomicRangeQuery
    {
        public int[] solution(string S, int[] P, int[] Q)       //62% korektne, ale prrformance testy na 0%     
        {                                                       //todo: improve performace
            // write your code in C# 5.0 with .NET 4.5 (Mono)
            int length = P.Length;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                int minimum = 5;
                for (int a = P[i]; a <= Q[i]; a++)
                {
                    switch (S[a])
                    {
                        case 'A':
                            minimum = Math.Min(minimum, 1);
                            break;
                        case 'C':
                            minimum = Math.Min(minimum, 2);
                            break;
                        case 'G':
                            minimum = Math.Min(minimum, 3);
                            break;
                        case 'T':
                            minimum = Math.Min(minimum, 4);
                            break;
                    }
                }
                result[i] = minimum;
            }
            return result;
        }
    }
}
