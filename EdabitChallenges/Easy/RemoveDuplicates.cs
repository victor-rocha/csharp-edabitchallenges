using System.Linq;

namespace EdabitChallenges.Easy
{
    public class RemoveDuplicates
    {
        // https://edabit.com/challenge/TofdXBRqnf7JFiZBC
        public static object[] RemoveDups(object[] str)
        {
            return str.Distinct().ToArray();
        }

    }
}
