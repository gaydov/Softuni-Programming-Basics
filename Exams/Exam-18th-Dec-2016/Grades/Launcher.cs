using System;

namespace Grades
{
    public class Launcher
    {
        public static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int between2and3 = 0;
            int between3and4 = 0;
            int between4and5 = 0;
            int above5 = 0;
            double allMarksSum = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double studentMark = double.Parse(Console.ReadLine());
                allMarksSum += studentMark;

                if (studentMark >= 2 && studentMark < 3)
                {
                    between2and3++;
                }
                else if (studentMark >= 3 && studentMark < 4)
                {
                    between3and4++;
                }
                else if (studentMark >= 4 && studentMark < 5)
                {
                    between4and5++;
                }
                else if (studentMark >= 5)
                {
                    above5++;
                }
            }

            double topStudentsPercent = (above5 / (double)studentsCount) * 100;
            double between4and5Percent = (between4and5 / (double)studentsCount) * 100;
            double between3and4Percent = (between3and4 / (double)studentsCount) * 100;
            double failedStudents = (between2and3 / (double)studentsCount) * 100;
            double averageMark = allMarksSum / studentsCount;

            Console.WriteLine("Top students: {0:F2}%", topStudentsPercent);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", between4and5Percent);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", between3and4Percent);
            Console.WriteLine("Fail: {0:F2}%", failedStudents);
            Console.WriteLine("Average: {0:F2}", averageMark);
        }
    }
}
