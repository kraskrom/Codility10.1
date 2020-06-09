/*
A positive integer D is a factor of a positive integer N if there exists an integer M such that N = D * M.

For example, 6 is a factor of 24, because M = 4 satisfies the above condition (24 = 6 * 4).

Write a function:

class Solution { public int solution(int N); }

that, given a positive integer N, returns the number of its factors.

For example, given N = 24, the function should return 8, because 24 has 8 factors, namely 1, 2, 3, 4, 6, 8, 12, 24. There are no other factors of 24.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..2,147,483,647].
*/

using System;

namespace Codility10._1
{
    class Solution
    {
        public int solution(int N)
        {
            if (N == 1)
                return 1;
            int d = 2;
            int i = 2;
            for (; (long)i * i < (long)N; i++)
                if (N % i == 0)
                    d += 2;
            if (i * i == N)
                d++;
            return d;
        }
    }

    class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            int s = sol.solution(int.MaxValue);
            Console.WriteLine("Solution: " + s);
            //Console.WriteLine("Solution: " + string.Join(", ", s));
        }
    }
}
