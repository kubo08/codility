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

            MinAvgTwoSlice avg = new MinAvgTwoSlice();

            timer.Start();
            test = avg.solution(new []{4,2,2,5,1,5,8});
            timer.Stop();
            Console.Write("minimal average start: " + test);
            Console.WriteLine();
            Console.WriteLine(timer.Elapsed);

            timer.Reset();

            CountDiv div = new CountDiv();

            timer.Start();
            test = div.solution(6, 11, 2);
            timer.Stop();
            Console.Write("num of divs: " + test);
            Console.WriteLine();
            Console.WriteLine(timer.Elapsed);

            timer.Reset();
        }
    }
}
