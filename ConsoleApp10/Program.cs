using System;

namespace ConsoleApp10
{
    class Program
    {
        // Main Method
        static void Main(string[] args)
        {
            var result = Add(40, 40);
            Console.WriteLine(result);

            var strResult = PrintName("Katherine", "Winters");
            Console.WriteLine(strResult);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static string PrintName(string firstName, string lastName)
        {
            return $"Hello, {firstName} {lastName}.";
        }



    }
}
