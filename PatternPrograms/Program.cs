using System;
using System.Collections.Generic;
using PatternPrograms;

public class Progrma
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter Size of Pattern : ");
        int n = int.Parse(Console.ReadLine());

        //call

        RightTriangleStarPattern.RightTriangle(n);
        Inverted_Triangle.InvertedTriangle(n);
        Pyramid_Pattern.PyramidPattern(n);



    }
}