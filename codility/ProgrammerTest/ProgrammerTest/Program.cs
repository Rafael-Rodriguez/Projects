using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var array = new int[] { -1, 3, -4, 5, 1, -6, 2, 1 };

            Console.WriteLine("Equilibrium index: {0}", solution.solution(array));
        }
    }
}
