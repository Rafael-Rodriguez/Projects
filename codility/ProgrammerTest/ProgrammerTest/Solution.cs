using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerTest
{
    public class Solution
    {
        const int NO_EQUILIBRIUM_INDEX_EXISTS = -1;
        Dictionary<int, int> preSumValues = new Dictionary<int, int>();
        Dictionary<int, int> postSumValues = new Dictionary<int, int>();

        public int solution(int [] A)
        {
            if(A.Length == 0)
            {
                return NO_EQUILIBRIUM_INDEX_EXISTS;
            }

            FillPreSumValues(0, A.Length - 1, A);
            FillPostSumValues(0, A.Length - 1, A);

            //for(int i = 0; i < A.Length; ++i)
            //{
            //    long sumBefore = ComputePreSum(i, A);
            //    long sumAfter = ComputePostSum(i, A);

            //    if(sumBefore == sumAfter)
            //    {
            //        return i;
            //    }
            //}

            return NO_EQUILIBRIUM_INDEX_EXISTS;
        }

        private void FillPreSumValues(int begIndex, int endIndex, int[] a)
        {
            /*int midIndex = GetMidIndex(begIndex, endIndex);

            var preSum = FindPreSum(begIndex, midIndex, a);
            preSumValues[midIndex] = preSum;*/

            preSumValues[0] = 0;

            var preSum = FindPreSum(begIndex, endIndex, a);
            preSumValues[endIndex] = preSum;
        }

        private static int GetMidIndex(int begIndex, int endIndex)
        {
            return (int)Math.Floor((double)((begIndex + endIndex) / 2));
        }

        private int FindPreSum(int begIndex, int endIndex, int[] a)
        {
            if(endIndex - begIndex > 1)
            {
                int midIndex = GetMidIndex(begIndex, endIndex);

                int preSum = FindPreSum(begIndex, midIndex, a);
                preSumValues[midIndex] = preSum;

                preSum += a[midIndex];
                preSumValues[midIndex + 1] = preSum;

                preSum += FindPreSum(midIndex + 1, endIndex, a);
                preSumValues[endIndex] = preSum;

                return preSum;
            }
            else if(endIndex - begIndex == 1)
            {
                return a[begIndex];
            }
            else
            {
                return 0;
            }
        }

        private void FillPostSumValues(int v1, int v2, int[] a)
        {
            //var preSum = FindPreSum(begIndex, endIndex, a);
            //preSumValues[endIndex] = preSum;
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
