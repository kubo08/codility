﻿using System;
using System.Diagnostics;

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
            test = frog.solution(5, new []{1,3,1,4,2,3,5,4});
            timer.Stop();
            Console.WriteLine("frog jump: " + test);
            Console.WriteLine(timer.Elapsed);
        }
    }
}