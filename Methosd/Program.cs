using System;

namespace Methosd
{
    class Program
    {
        static void Main(string[] args)
        {
            //dd(); 
            //var resault = Add2(10);
            //int number1 = 20;
            //int number2 = 100;
            //var resault2 = Add3(number1, number2);
            //Console.WriteLine(resault2);
            //Console.WriteLine();
            //Console.WriteLine(Multiply(2,4,4));
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
            
        }
    

        static void Add()
        {
         Console.WriteLine("added"); 
        }

        static int Add2(int number1, int number2) 
        {
            var resault = number1 + number2;
            return resault;
        }
        static int Add3(int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2 ;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }
        
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
        






    }
}