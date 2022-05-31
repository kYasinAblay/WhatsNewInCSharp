using System;

namespace PatternMatchingImprovements
{
    internal static class Program
    {
        public static bool IsLetter(this char c) =>
               c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
        public static bool IsLetterOrSeparator(this char c) =>
             c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or ';' or ',';
        static void Main(string[] args)
        {
            int temperature = 6666;

            var feel = temperature switch
            {
                < 0 => "freezing",
                //and
                >= 0 and < 20 => "tolerable",
                >= 20 and not (666 or 6666) => "warm",
                666 or 6666 => "hellish"
            };
            Console.WriteLine(feel);
            Console.ReadKey();
        }
    }
}
