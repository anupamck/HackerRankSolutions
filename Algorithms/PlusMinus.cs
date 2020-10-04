using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class PlusMinus
    {

    // Complete the plusMinus function below.
    
    public static void plusMinus(int[] arr)
        {
            double positiveCount = 0;
            double negativeCount = 0;
            double zeroCount = 0;
            List<double> resultList = new List<double>();

            foreach (int element in arr)
            {
                if (element > 0)
                    positiveCount++;

                if (element < 0)
                    negativeCount++;

                if (element == 0)
                    zeroCount++;
            }

            resultList.Add(positiveCount / arr.Length);
            resultList.Add(negativeCount / arr.Length);
            resultList.Add(zeroCount / arr.Length);

            printList(resultList);

        }

        static void printList(List<double> dList)
        {
            foreach (double element in dList)
                Console.WriteLine(string.Format("{0:N6}", element));
        }

    }
}
