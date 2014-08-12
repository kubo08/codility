using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace lesson_2_Counting_Elements
{
    class Program
    {
        private static void Main()
        {
            PermCheck perm = new PermCheck();

            Stopwatch timer = new Stopwatch();
            timer.Start();
            var test = perm.solution(new[] { 4, 1, 2 });
            timer.Stop();
            Console.WriteLine("perm check: " + test);
            Console.WriteLine(timer.Elapsed);


            timer.Reset();

            FrogRiverJump frog = new FrogRiverJump();
            int[] A = new int[100000];
            for (int i = 0; i < 100000; i++)
            {
                A[i] = 100000 - i;
            }
            timer.Start();

            test = frog.solution(100000, A);
            timer.Stop();
            Console.WriteLine("frog jump: " + test);
            Console.WriteLine(timer.Elapsed);

            timer.Reset();

            MaxCounter counters = new MaxCounter();
            int[] numbers = new[] {3, 4, 4, 6, 1, 4, 4};
            timer.Start();
            var result = counters.solution(5, numbers);
            timer.Stop();
            Console.Write("max counters: ");
            foreach (var item in result)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine(timer.Elapsed);

            timer.Reset();

            //var array = new[] {1, 3, 6, 4, 1, 2};
            var array = new List<int>();
            for (int i = -2; i < 100000; i++)
            {
                array.Add(i);
            }
            MissingInteger miss=new MissingInteger();
            timer.Start();
            test=miss.solution(array.ToArray());
            timer.Stop();
            Console.WriteLine("missing integer: " + test);
            Console.WriteLine(timer.Elapsed);
        }
    }
}
