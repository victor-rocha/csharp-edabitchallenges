using NUnit.Framework;
using VeryEasy;

namespace VeryEasy
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("hello", ExpectedResult = "ehllo")]
        [TestCase("edabit", ExpectedResult = "abdeit")]
        [TestCase("hacker", ExpectedResult = "acehkr")]
        [TestCase("geek", ExpectedResult = "eegk")]
        [TestCase("javascript", ExpectedResult = "aacijprstv")]
        [TestCase("credibility", ExpectedResult = "bcdeiiilrty")]
        [TestCase("apostrophe", ExpectedResult = "aehoopprst")]
        [TestCase("determination", ExpectedResult = "adeeiimnnortt")]
        [TestCase("win", ExpectedResult = "inw")]
        [TestCase("synthesis", ExpectedResult = "ehinsssty")]

        public static string AlphabetSoupTests(string str)
        {
            return AlphabetSoup.AlphabetSoupMethod(str);
        }
    }
}