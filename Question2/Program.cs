using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


public static class StringBuilderExtensions
{
    public static int wordCount(this StringBuilder sb)
    {
        int count = 0;
        for (int i = 0; i < sb.Length; i++)
        {
            if (char.IsWhiteSpace(sb[i]))
            {
                count++;
            }
        }
        return count;
    }
}
namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder("This is to test whether the extension\r\nmethod count can return a right answer or not");
            int wordCount = StringBuilderExtensions.wordCount(sb);
            Console.WriteLine($"The string has a word count of {wordCount}");
        }
    }
}
