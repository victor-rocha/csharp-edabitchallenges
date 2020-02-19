using System;
using System.Linq;

namespace EdabitChallenges.Easy
{
    public class RetrieveSubReddit
    {
        // https://edabit.com/challenge/qvo2Ae8WdRQfCwaQk
        public static string SubReddit(string link)
        {
           return link.Remove(link.Length - 1).Split('/').Last();
        }
    }
}
