using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisionmaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 5: Decision Making
            Console.WriteLine("\n\nEnter your exam score as a percentage:");
            int examScore = int.Parse(Console.ReadLine());

            if (examScore >= 90)
                Console.WriteLine("Grade: A");
            else if (examScore >= 80)
                Console.WriteLine("Grade: B");
            else if (examScore >= 70)
                Console.WriteLine("Grade: C");
            else if (examScore >= 60)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");

            Console.ReadKey();
        }
    }
}
