using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
    public class Inverted_Triangle
    {
        public static void InvertedTriangle(int n)
        {
            for(int i = n;i>=1;i--)
            {
                for(int j = 1; j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
