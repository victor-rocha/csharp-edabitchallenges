namespace EdabitChallenges.Medium
{
    public class CheckEquality
    {
        // https://edabit.com/challenge/Q7g8sfg7DJq6CyMMu
        public static bool CheckEqualityMethod(object a, object b)
        {
            if (a.GetType() != b.GetType())
                return false;
            return a.Equals(b);
        }
    }
}
