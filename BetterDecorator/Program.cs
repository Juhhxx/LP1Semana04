using System;

namespace BetterDecorator
{
    /// <summary>
    /// The program creates a decorated string using the inputs provided by the
    /// user.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Converts the arguments given by the user into the ones that are
        /// going to be used on the Decor() method and calls that method.
        /// </summary>
        /// <param name="args">Arguments in string format to be used by the
        /// Decor() method.</param>
        static void Main(string[] args)
        {
            string str = args[0];
            char chr = char.Parse(args[1]);
            int intg = int.Parse(args[2]);

            Console.WriteLine(Decor(str,chr,intg));
            
        }
        /// <summary>
        /// Creates a decorated string with the given arguments.
        /// </summary>
        /// <param name="s">Main string.</param>
        /// <param name="c">String decorator.</param>
        /// <param name="i">Times the decorator will be display on each side of 
        /// the string.</param>
        /// <returns></returns>
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
        private static string Decor()
        {
            return Decor("User did specify args!", '=', 3);
        }
    }
}
