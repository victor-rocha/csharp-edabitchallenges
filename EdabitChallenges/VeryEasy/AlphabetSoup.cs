using System;
namespace VeryEasy
{
    // https://edabit.com/challenge/jRQSYLrcWLtxtYnx4
    public class AlphabetSoup
    {
        public static string AlphabetSoupMethod(string str)
        {
            char[] a = str.ToCharArray();
            Array.Sort(a);
            return new string(a);
        }
    }
}
