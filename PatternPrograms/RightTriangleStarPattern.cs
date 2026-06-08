using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
    public class RightTriangleStarPattern
    {
        public static void RightTriangle(int n)
        {
            for (int i = 1; i<=n; i++)
            {
                for(int j = 1; j<= i;j++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
