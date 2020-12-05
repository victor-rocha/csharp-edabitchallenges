using EdabitChallenges.Medium;
using NUnit.Framework;

namespace UnitTests.Medium
{
    public class MediumUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Happy Birthday", ExpectedResult = "hAPPY bIRTHDAY")]
        [TestCase("MANY THANKS", ExpectedResult = "many thanks")]
        [TestCase("sPoNtAnEoUs", ExpectedResult = "SpOnTaNeOuS")]
        [TestCase("eXCELLENT, yOuR mAJESTY", ExpectedResult = "Excellent, YoUr Majesty")]
        public static string ReverseTheCaseTests(string str) => ReserveTheCase.ReserveTheCaseMethod(str);
        
    }
}
