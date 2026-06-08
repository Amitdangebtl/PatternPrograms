using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
    public class Pyramid_Pattern
    {
        public static void PyramidPattern(int n)
        {
            for(int i =1;i <= n;i++)
            {
                for(int j = 1; j<= n-i;j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
