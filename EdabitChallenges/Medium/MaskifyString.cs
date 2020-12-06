using System;
using System.Linq;
namespace EdabitChallenges.Medium
{
    public class MaskifyString
    {
        private const string CHAR_MASKED = "#";
        public static string MaskifyStringMethod(string str)
        {
            var stringLength = str.Length;
            if (stringLength < 4)
                return str;

            var lastFour = str[Math.Max(0, str.Length - 4)..];
            return new string(string.Concat(Enumerable.Repeat(CHAR_MASKED, stringLength - 4)) + lastFour);
        }
    }
}
