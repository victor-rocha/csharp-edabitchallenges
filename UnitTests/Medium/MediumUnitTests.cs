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

        [Test]
        [TestCase("4556364607935616", ExpectedResult = "############5616")]
        [TestCase("64607935616", ExpectedResult = "#######5616")]
        [TestCase("1", ExpectedResult = "1")]
        [TestCase("", ExpectedResult = "")]
        [TestCase("tBy>L/cMe+?<j:6n;C~H", ExpectedResult = "################;C~H")]
        [TestCase("12", ExpectedResult = "12")]
        [TestCase("8Ikhlf6yoxPOwi5cB014eWbRumj7vJ", ExpectedResult = "##########################j7vJ")]
        [TestCase("123", ExpectedResult = "123")]
        [TestCase(")E$aCU=e\"_", ExpectedResult = "######=e\"_")]
        [TestCase("2673951408", ExpectedResult = "######1408")]
        [TestCase("1234", ExpectedResult = "1234")]
        public static string MaskifyStringTests(string str) => MaskifyString.MaskifyStringMethod(str);

    }
}
