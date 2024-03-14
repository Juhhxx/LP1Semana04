using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
