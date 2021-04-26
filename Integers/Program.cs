using System;

namespace Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            byte piccolo = byte.MaxValue;
            short small = short.MaxValue;
            int regular = int.MaxValue;
            long grande = long.MaxValue;

            Console.WriteLine("piccolo = " + piccolo);
            Console.WriteLine("small = " + small);
            Console.WriteLine("regular = " + regular);
            Console.WriteLine("grande = " + grande);
            Console.WriteLine("________________________");
            Console.WriteLine("Variable Sizes");
            Console.WriteLine("------------------------");
            Console.WriteLine("piccolo's size is " + sizeof(byte));
            Console.WriteLine("small's size is " + sizeof(short));
            Console.WriteLine("regular's size is " + sizeof(int));
            Console.WriteLine("grande's size is " + sizeof(long));

            //grande = piccolo; // grande = 255
            //regular = (int)(piccolo + grande);
            //Console.WriteLine("regular = " + regular);

            Console.WriteLine("regular = " + regular);
            regular = checked(regular + 1);
            Console.WriteLine("regular + 1 = " + regular);

            regular = int.MaxValue;
            Console.WriteLine("regular = " + Convert.ToString(regular, 2));
            regular++;
            Console.WriteLine("regular = " + Convert.ToString(regular, 2));

            ushort usmall = ushort.MaxValue;
            Console.WriteLine("usmall = " + usmall);
            usmall++;
            Console.WriteLine("usmall + 1 = " + usmall);

        }
    }
}
