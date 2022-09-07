using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = " abcde FGHIJ ABC abc DEFG   ";
            string s1= original.ToUpper();
            string s2= original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3,5);
            string s6 = (original.ToLower()).Replace("abc", "xy");
            bool b1=string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);


            Console.WriteLine("Origi: [ "+original+"]");
            Console.WriteLine("Upper: [" + s1 + "]");
            Console.WriteLine("Lower: [" + s2 + "]");
            Console.WriteLine("Lower: [" + s3 + "]");
            Console.WriteLine("\nA primeira posição o indexof('bc'): "+n1);
            Console.WriteLine("\nA última posição o indexof('bc'): " + n2);
            Console.WriteLine("Substring: [" + s4 + "]");
            Console.WriteLine("Substring: [" + s5 + "]");
            Console.WriteLine("Replace: [" + s6 + "]");
            Console.WriteLine("Bool-IsNullOrEmpty: [" + b1 + "]");
            Console.WriteLine("IsNullOrWhiteSpace: [" + b2 + "]");

        }
    }
}
