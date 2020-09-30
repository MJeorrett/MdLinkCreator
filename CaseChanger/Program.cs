using System;

namespace CaseChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            var theString = args[0];
            var theStringParts = theString.ToLower().Split(" ");
            var link = string
                .Join("-", theStringParts)
                .Replace("---", "-");

            Console.WriteLine($"[{theString}](#{link})");
        }
    }
}
