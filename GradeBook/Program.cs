using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no.of students. ");
            int size = Convert.ToInt32(Console.ReadLine());
            float max = 0, min = 0, avg = 0;
            float[] MarksArr = new float[size];
            Console.WriteLine("please enter the marks of the students.");
            for (int j = 0; j < MarksArr.Length; j++)
            {
                MarksArr[j] = float.Parse(Console.ReadLine());
            }
            min = MarksArr[0];
            for (int i = 0; i < MarksArr.Length; i++)
            {

                if (MarksArr[i] > max)
                    max = MarksArr[i];
                else if (MarksArr[i] <= min)
                    min = MarksArr[i];
                avg = avg + MarksArr[i];
            }
            avg = (avg / size);

            Console.WriteLine("Maximun Value = {0}\n Minimun Value = {1}\n Average Value = {2}", max, min, avg);
            Console.Read();
        }
    }
}
