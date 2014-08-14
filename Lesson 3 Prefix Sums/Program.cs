using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Lesson_3_Prefix_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            PassingCars perm = new PassingCars();

            Stopwatch timer = new Stopwatch();
            timer.Start();
            var test = perm.solution(new[] {0, 1, 0, 1, 1});
            timer.Stop();
            Console.WriteLine("passing cars: " + test);
            Console.WriteLine(timer.Elapsed);

            timer.Reset();
        }
    }
}
