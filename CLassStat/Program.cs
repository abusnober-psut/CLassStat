using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLassStat
{
    class Program
    {
        static void Main(string[] args)
        {
            // input grades for N students, then computes the no of passed and failed
            int N;
            int grade;
            int passed = 0, 
                failed = 0;

            int i = 1;

            Console.WriteLine("Input number of Students ");
            N = int.Parse( Console.ReadLine() );
            
            while (i<=N)
            {
                Console.WriteLine("Enter a grade");
                grade = int.Parse( Console.ReadLine() );

                if (grade >= 50) // passed
                    passed++;
                else
                    ++failed;

                i++;
            }

            Console.WriteLine($"The percentage of passed students = {1.0*passed/N}");
            Console.WriteLine($"The percentage of failed students = {failed/ (float)N}");

        }
    }
}
