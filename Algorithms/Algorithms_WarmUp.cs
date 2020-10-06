using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Algorithms_WarmUp
{

    // Complete the staircase function below.
    public static void staircase(int n)
    {
        int stepCount = 1;

        for (int i = n; i > 0; i--)
        {
            Console.WriteLine(String.Concat(printChar(' ', i - 1), printChar('#', stepCount)));
            stepCount++;
        }

    }

    public static string printChar(char chr, int n)
    {
        return new string(chr, n);
    }

    public static void MainStaircase(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }

    public static int diagonalDifference(List<List<int>> arr)
    {
        int sumUp = 0;
        int sumDown = 0;
        int rowCount = arr.Count;

        for (int row = 0; row < rowCount; row++)
        {
            sumUp = sumUp + arr[row][row];
            sumDown = sumDown + arr[rowCount - row - 1][row];
        }

        return Math.Abs(sumUp - sumDown);
    }

    public static void MainDiagonalDifference(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = diagonalDifference(arr);

        textWriter.WriteLine(result);
        Console.ReadKey();

        textWriter.Flush();
        textWriter.Close();
    }

    public static void miniMaxSum(int[] arr)
    {
        long minValue = arr[0];
        long maxValue = arr[0];
        long sumValue = 0;

        foreach (long number in arr)
        {
            if (number < minValue)
                minValue = number;

            if (number > maxValue)
                maxValue = number;

            sumValue = sumValue + number;
        }

        Console.WriteLine(String.Concat(sumValue - maxValue, " ", sumValue - minValue));

    }

    public static void MainMiniMaxSum(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
