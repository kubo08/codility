using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace codility
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //List<int> A = new List<int>();
            //List<int> B = new List<int>();
            //Random rand = new Random();
            //for (int i = 0; i < 40000; i++)
            //{
            //    A.Add(rand.Next(400000000));
            //    B.Add(rand.Next(400000000));
            //}
            //A.Sort();
            //B.Sort();
            int[] perm = new int[100000];
            for (var a = 1; a < 100001; a++)
            {
                perm[a - 1] = a;
            }
            TimeComplexity tc = new TimeComplexity();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            //var test = solution(400000000, 400000000, 3, A.ToArray(), B.ToArray());
            //var test = solution2(new[] {3, 1, 2, 4, 3});
            //var test = FrogJmp(10, 1000000000, 30);
            var test = tc.ElementMissing(perm);
            timer.Start();
            Console.WriteLine(test);
            Console.WriteLine(timer.Elapsed);
        }

        // you can also use other imports, for example:
        // using System.Collections.Generic;

        // you can use Console.WriteLine for debugging purposes, e.g.
        // Console.WriteLine("this is a debug message");
        public static int solution(int X, int Y, int K, int[] A, int[] B)
        {
            // write your code in C# 5.0 with .NET 4.5 (Mono)
            int N = A.Length;
            List<int> a1 = new List<int> { A[0] };
            List<int> b1 = new List<int> { B[0] };
            for (int i = 1; i < N; i++)
            {
                a1.Add(A[i] - A[i - 1]);
                b1.Add(B[i] - B[i - 1]);
            }
            a1.Add(X - A[N - 1]);
            b1.Add(Y - B[N - 1]);
            List<int> plochy = (from itema in a1 from itemb in b1 select itema * itemb).ToList();
            plochy.Sort((a, b) => -1 * a.CompareTo(b));

            return plochy.ElementAt(K - 1);
        }

        public class TimeComplexity
        {



            public int solution2(int[] A)
            {
                // write your code in C# 5.0 with .NET 4.5 (Mono)

                int sum = A.ToList().Sum();
                int partSum = 0;
                int diff = Math.Abs(sum);
                int position;

                for (var i = 0; i < A.Length; i++)
                {
                    partSum += A[i];
                    if (Math.Abs(2 * partSum - sum) < diff)
                        diff = Math.Abs(2 * partSum - sum);
                    position = i;
                }


                return diff;
            }

            public int FrogJmp(int X, int Y, int D) //100%
            {
                // write your code in C# 5.0 with .NET 4.5 (Mono)
                var diff = Y - X;

                return (int)Math.Ceiling((double)diff / (double)D);
            }

            public int ElementMissing(int[] A)          //100%
            {
                int N = A.Length;
                int[] array = new int[N + 1];
                for (int i = 1; i < N + 1; i++)
                {
                    array[A[i - 1] - 1] = 1;
                    //if (!A.Contains(i))           //slaby performance
                    //{
                    //    return i;
                    //}
                }
                //var result = array..Where(t => t == 0).FirstOrDefault();
                var result = Array.IndexOf(array, 0);
                return result + 1;
            }
        }
    }
}
