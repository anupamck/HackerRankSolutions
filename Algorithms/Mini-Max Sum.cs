﻿using System.CodeDom.Compiler;
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

class Algorithms
{

    // Complete the miniMaxSum function below.
    public static void miniMaxSum(int[] arr)
    {
        int minValue = arr.Min();
        int maxValue = arr.Max();

        Console.WriteLine(arr.Sum() - arr.Max() & " " & arr.Sum() - arr.Min());

    }

    static void Main2(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
