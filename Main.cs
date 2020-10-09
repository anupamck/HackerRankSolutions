using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class Exe
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                grades.Add(Convert.ToInt32(Console.ReadLine().Trim()));
            }

            List<int> revisedGrades = Algorithms_WarmUp.gradingStudents(grades);

            foreach (int grade in revisedGrades)
                Console.WriteLine(grade);
            Console.ReadKey();





        }
    }
}