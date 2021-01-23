using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "salık";
            students[1] = "engin";
            students[2] = "derin";
            
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();





        }
    }
}
