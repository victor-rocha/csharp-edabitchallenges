using System.Linq;

namespace EdabitChallenges.Easy
{
    public class CheckSameCase
    {
        // https://edabit.com/challenge/ivaEWKZbFMcR8emJ8
        public static bool SameCase(string str)
        {
            return str.ToCharArray().All(q => char.IsLower(q)) || str.ToCharArray().All(q => char.IsUpper(q));
        }
    }
}
