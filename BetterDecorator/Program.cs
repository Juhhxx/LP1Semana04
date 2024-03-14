using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = args[0];
            char chr = char.Parse(args[1]);
            int intg = int.Parse(args[2]);

            Console.WriteLine(Decor(str,chr,intg));
            
        }
        private static string Decor(string s, char c, int i)
        {
            string result;
            string decorator = "";

            for (int j = 0; j < i; j++)
            {
                decorator += c;
            }

            result = $"{decorator} {s} {decorator}";

            return result;
        }
    }
}
