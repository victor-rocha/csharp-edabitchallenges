using System;
using System.Text;

namespace EdabitChallenges.Medium
{
    public class ReserveTheCase
    {
        // https://edabit.com/challenge/99oN5igrbXddAjHEL
        public static string ReserveTheCaseMethod(string str)
        {
            var stringBuilder = new StringBuilder();
            foreach (var charItem in str)
            {
                stringBuilder.Append(char.IsUpper(charItem) ? char.ToLower(charItem) : char.ToUpper(charItem));
            }
            return stringBuilder.ToString();
        }
    }
}
