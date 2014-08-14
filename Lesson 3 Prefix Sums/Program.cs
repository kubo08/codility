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
            PassingCars cars = new PassingCars();

            Stopwatch timer = new Stopwatch();
            timer.Start();
            var test = cars.solution(new[] { 0, 1, 0, 1, 1 });
            timer.Stop();
            Console.WriteLine("passing cars: " + test);
            Console.WriteLine(timer.Elapsed);

            timer.Reset();

            GenomicRangeQuery query = new GenomicRangeQuery();

            timer.Start();
            var testArray = query.solution("CAGCCTA", new[] { 2,5,0 }, new []{4,5,6});
            timer.Stop();
            Console.Write("Genomic range query: ");
            foreach (var item in testArray)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine(timer.Elapsed);

            timer.Reset();
        }
    }
}
