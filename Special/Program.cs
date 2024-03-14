using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            string input = Console.ReadLine();
            int i = int.Parse(input);

            Console.WriteLine(GetSpecial(i));
        }
        private static int GetSpecial(int n)
        {
            int result;

            if (n == 0 || n == 1)
            {
                result = n;
            }
            else
            {
                result = GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
            }

            return result;
        }
    }
}
