using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    public class SolutionNails
    {
        public int solution(int[] A, int K)
        {
            int n = A.Length;
            int best = 0;
            int count = 1;
            
            if(n - K - 1 <= -1)
            {
                return n;
            }

            for (int i = 0; i < n - K - 1; i++)
            {
                if (A[i] == A[i + 1])
                    count = count + 1;
                else
                    count = 1;
                if (count > best)
                    best = count;
            }

            int result = best + K;

            return result;
        }
    }
}
