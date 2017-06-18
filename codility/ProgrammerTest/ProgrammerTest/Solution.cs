﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerTest
{
    public class Solution
    {
        const int NO_EQUILIBRIUM_INDEX_EXISTS = -1;

        public int solution(int [] A)
        {
            if(A.Length == 0)
            {
                return NO_EQUILIBRIUM_INDEX_EXISTS;
            }

            for(int i = 0; i < A.Length; ++i)
            {
                long sumBefore = ComputePreSum(i, A);
                long sumAfter = ComputePostSum(i, A);

                if(sumBefore == sumAfter)
                {
                    return i;
                }
            }

            return NO_EQUILIBRIUM_INDEX_EXISTS;
        }

        private long ComputePreSum(int i, int[] a)
        {
            if(i == 0)
            {
                return 0;
            }

            long sum = 0;
            for(int h = 0; h < i; ++h)
            {
                sum += a[h];
            }

            return sum;
        }

        private long ComputePostSum(int i, int[] a)
        {
            if(i == a.Length -1)
            {
                return 0;
            }

            long sum = 0;
            for(int j = i+1; j < a.Length; ++j)
            {
                sum += a[j];
            }

            return sum;
        }
    }
}
