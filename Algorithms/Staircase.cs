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

class Algorithms
{

    // Complete the staircase function below.
    static void staircase(int n)
    {
        int stepCount = 1;

        for (int i = n; i > 0; i--)
        {
            Console.WriteLine(String.Concat(printChar(' ', i - 1), printChar('#', stepCount)));
            stepCount++;
        }

    }

    static string printChar(char chr, int n)
    {
        return new string(chr, n);
    }

    static void Main2(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
