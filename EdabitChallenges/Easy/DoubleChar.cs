using System.Linq;
using System.Text;

namespace EdabitChallenges.Easy
{
    public class DoubleChar
    {
        // https://edabit.com/challenge/fKZHLzmR8anBrxgNt
        public static string DoubleCharMethod(string str)
        {
            var stringBuilder = new StringBuilder();
            foreach (var item in str.ToCharArray())
            {
                stringBuilder.Append(string.Concat(Enumerable.Repeat(item, 2)));
            }
            return stringBuilder.ToString();
        }
    }
}
