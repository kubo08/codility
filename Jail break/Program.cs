using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jail_break
{
    class Program
    {
        static void Main(string[] args)
        {
            prison jail = new prison();

            var test = jail.JailBreak(new[] {0, 1, 2, 3, 3, 2, 6, 6,8,7}, new[] {1, 2, 3, 4, 5, 6, 8, 7,7,9}, new[] {1, 6});
            Console.WriteLine(test);
        }
    }

    class prison
    {
        public int JailBreak(int[] A, int[] B, int[] C)
        {
            int[] D = new int[A.Length+1];
            
            int[] entrances = new int[A.Length+1];
            int[] exits = new int[A.Length+1];
            for (int i = 0; i < exits.Length; i++)
            {
                exits[i] = -1;
                entrances[i] = -1;
            }
            int actual = -1;
            for (int i = 0; i < A.Length; i++)
            {
                //if (C.Contains(B[i])) continue;
                if (exits[B[i]] == -1)
                {
                    exits[B[i]] = 0;
                }
                exits[A[i]] = 1;
                if (entrances[A[i]] == -1)
                {
                    entrances[A[i]] = 0;
                }
                entrances[B[i]] = 1;
                //D[B[i]] = D[A[i]] != 0 ? D[A[i]] : A[i];
                //B[i] = -1;
                //A[i] = -1;
                if (C.Contains(A[i]))
                {
                    actual = B[i];
                }
                if (actual != -1)
                {
                    D[B[i]] = actual;
                }
                
                
            }

            if (C.Any(prisoner => entrances.Where(t => t == 0).Contains(prisoner)))
            {
                return -1;
            }

            List<int> test=new List<int>();
            for (int i=0;i<A.Length+1;i++)
            {
                if (exits[i] == 0)
                    test.Add(D[i]);
            }
            int count = test.Distinct().Count();
            //var count = (D.Where(t => t != 0)).Distinct().Count();

            D = new int[A.Length + 1];
            for (int i = A.Length-1; i >-1; i--)
            {
                //if (C.Contains(B[i])) continue;
                //D[B[i]] = D[A[i]] != 0 ? D[A[i]] : A[i];
                //B[i] = -1;
                //A[i] = -1;
                if (actual != -1)
                {
                    D[A[i]] = actual;
                }
                if (C.Contains(A[i]))
                {
                    actual = A[i];
                }

            }
            test = new List<int>();
            for (int i = 0; i < A.Length + 1; i++)
            {
                if (entrances[i] == 0)
                    test.Add(D[i]);
            }
            count += test.Distinct().Count();

            return count;
        }
    }
}
