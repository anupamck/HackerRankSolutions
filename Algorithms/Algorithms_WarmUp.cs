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

    public static int birthdayCakeCandles(List<int> candles)
    {
        int maxCount = 0;
        int highestCandle = 0;

        foreach (int candle in candles)
        {

            if (candle == highestCandle)
                maxCount++;

            if (candle > highestCandle)
            {
                highestCandle = candle;
                maxCount = 1;
            }


        }
        return maxCount;
    }

    public static string timeConversion(string s)
    {
        int hour = Convert.ToInt32(s.Substring(0,2));
        string meridian = s.Substring(8, 2);       
        
        if (meridian.ToLower() == "am")
        {
            if (hour < 12)
                return s.Substring(0, 8);
            else
                return String.Concat((hour - 12).ToString("00"), s.Substring(2, 6));
        }
        else
            if (hour < 12)
                return String.Concat((hour + 12).ToString("00"), s.Substring(2, 6));
            else
                return s.Substring(0, 8);       
    }

}

