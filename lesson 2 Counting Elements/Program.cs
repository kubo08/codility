using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace lesson_2_Counting_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            PermCheck perm = new PermCheck();

            Stopwatch timer = new Stopwatch();
            timer.Start();
            var test = perm.solution(new[] {4, 1, 2});
            timer.Stop();
            Console.WriteLine(test);
            Console.WriteLine(timer.Elapsed);
        }
    }
}
