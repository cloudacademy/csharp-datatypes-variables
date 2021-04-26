using System;

namespace FloatingPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            float fAnswer = 3.65f + 0.05f;
            Console.WriteLine($"float answer should be 3.7, but is {fAnswer}");

            double dAnswer = 3.65d + 0.05d;
            Console.WriteLine($"double answer should be 3.7, but is {dAnswer}");

            decimal mAnswer = 3.65m + 0.05m;
            Console.WriteLine($"decimal answer should be 3.7, but is {mAnswer}");

            fAnswer = 0.09f * 100f;
            float fAnswer2 = 0.09f * 99.9999999999f;
            Console.WriteLine($"float answer should be {fAnswer}, but is {fAnswer2}");

            bool areEqual = fAnswer == fAnswer2;
            Console.WriteLine($"float {fAnswer} is equal to {fAnswer2}: {areEqual}");

            dAnswer = 0.09f * 100d;
            double dAnswer2 = 0.09d * 99.999999999999999999999d;            
            Console.WriteLine($"double answer should be {dAnswer}, but is {dAnswer2}");

            areEqual = dAnswer == dAnswer2;
            Console.WriteLine($"double {dAnswer} is equal to {dAnswer2}: {areEqual}");

            mAnswer = 0.09m * 100m;
            decimal mAnswer2 = 0.09m * 99.999999999999999999999m;
            Console.WriteLine($"decimal answer should be {mAnswer}, but is {mAnswer2}");

            areEqual = mAnswer == mAnswer2;
            Console.WriteLine($"decimal {mAnswer} is equal to {mAnswer2}: {areEqual}");

            int one = 1;
            int ten = 10;

            dAnswer = (double)one / (double)ten;
            Console.WriteLine($"double answer should be 0.1, but is {dAnswer}");            

        }
    }
}
