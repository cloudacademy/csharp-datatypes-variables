using System;

namespace Arrays{    
    class Program    {        
        static void Main(string[] args)        
        {            
            string[] arrayOfStrings = { "how", "now", "brown", "cow" };            
            int[] arrayOfInts = { 0, 0, 1, 2, 3 };
            char[] arrayOfLetters = { };

            Console.WriteLine($"arrayOfStrings has {arrayOfStrings.Length} elements");
            Console.WriteLine($"arrayOfInts has {arrayOfInts.Length} elements");
            Console.WriteLine($"arrayOfLetters has {arrayOfLetters.Length} elements");

            Console.WriteLine($"{arrayOfStrings[0]} {arrayOfStrings[1]} {arrayOfStrings[2]} {arrayOfStrings[3]}");
            Console.WriteLine($"{arrayOfInts[1]} {arrayOfInts[2]} {arrayOfInts[3]} {arrayOfInts[4]}");
            Console.WriteLine($"{arrayOfStrings[arrayOfInts[3]]}");

            string cowColor = arrayOfStrings[arrayOfInts[3]];

            arrayOfLetters = new char[cowColor.Length];

            arrayOfLetters[0] = 'c';
            arrayOfLetters[1] = cowColor[1];
            arrayOfLetters[2] = cowColor[2];
            arrayOfLetters[3] = cowColor[3];
            arrayOfLetters[4] = cowColor[4];

            Console.WriteLine($"{arrayOfLetters[0]}{arrayOfLetters[1]}{arrayOfLetters[2]}{arrayOfLetters[3]}{arrayOfLetters[4]}");

            Console.WriteLine("");
            Console.WriteLine("***** Checkers *****");
            int[,] checkers = new int[4, 4];
            checkers[0, 0] = 1;
            checkers[0, 1] = 0;
            checkers[0, 2] = 1;
            checkers[0, 3] = 0;

            checkers[1, 0] = 0;
            checkers[1, 1] = 1;
            checkers[1, 2] = 0;
            checkers[1, 3] = 1;

            checkers[2, 0] = 1;
            checkers[2, 1] = 0;
            checkers[2, 2] = 1;
            checkers[2, 3] = 0;

            checkers[3, 0] = 0;
            checkers[3, 1] = 1;
            checkers[3, 2] = 0;
            checkers[3, 3] = 1;

            Console.WriteLine($"{checkers[0, 0]}{checkers[0, 1]}{checkers[0, 2]}{checkers[0, 3]}");
            Console.WriteLine($"{checkers[1, 0]}{checkers[1, 1]}{checkers[1, 2]}{checkers[1, 3]}");
            Console.WriteLine($"{checkers[2, 0]}{checkers[2, 1]}{checkers[2, 2]}{checkers[2, 3]}");
            Console.WriteLine($"{checkers[3, 0]}{checkers[3, 1]}{checkers[3, 2]}{checkers[3, 3]}");

        }
    }
}