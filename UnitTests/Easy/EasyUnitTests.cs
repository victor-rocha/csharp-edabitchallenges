using EdabitChallenges.Easy;
using NUnit.Framework;

namespace UnitTests.Easy
{
    public class EasyUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("https://www.reddit.com/r/relationships/", ExpectedResult = "relationships")]
        [TestCase("https://www.reddit.com/r/mildlyinteresting/", ExpectedResult = "mildlyinteresting")]
        [TestCase("https://www.reddit.com/r/funny/", ExpectedResult = "funny")]
        [TestCase("https://www.reddit.com/r/CrappyDesign/", ExpectedResult = "CrappyDesign")]
        [TestCase("https://www.reddit.com/r/confession/", ExpectedResult = "confession")]
        [TestCase("https://www.reddit.com/r/AskMen/", ExpectedResult = "AskMen")]
        [TestCase("https://www.reddit.com/r/comics/", ExpectedResult = "comics")]
        [TestCase("https://www.reddit.com/r/lifehacks/", ExpectedResult = "lifehacks")]
        [TestCase("https://www.reddit.com/r/wholesomememes/", ExpectedResult = "wholesomememes")]
        [TestCase("https://www.reddit.com/r/iamverysmart/", ExpectedResult = "iamverysmart")]
        [TestCase("https://www.reddit.com/r/starterpacks/", ExpectedResult = "starterpacks")]
        [TestCase("https://www.reddit.com/r/awww/", ExpectedResult = "awww")]
        public static string SubRedditTests(string str) => RetrieveSubReddit.SubReddit(str);

        [Test]
        [TestCase(new object[] { "John", "Taylor", "John" }, ExpectedResult = new object[] { "John", "Taylor" })]
        [TestCase(new object[] { "John", "Taylor", "John", "john" }, ExpectedResult = new object[] { "John", "Taylor", "john" })]
        [TestCase(new object[] { "javascript", "python", "python", "ruby", "javascript", "c", "ruby" }, ExpectedResult = new object[] { "javascript", "python", "ruby", "c" })]
        [TestCase(new object[] { 1, 2, 2, 2, 3, 2, 5, 2, 6, 6, 3, 7, 1, 2, 5 }, ExpectedResult = new object[] { 1, 2, 3, 5, 6, 7 })]
        [TestCase(new object[] { "#", "#", "%", "&", "#", "$", "&" }, ExpectedResult = new object[] { "#", "%", "&", "$" })]
        [TestCase(new object[] { 3, "Apple", 3, "Orange", "Apple" }, ExpectedResult = new object[] { 3, "Apple", "Orange" })]
        public static object[] RemoveDuplicatesTests(object[] list) => RemoveDuplicates.RemoveDups(list);

        [Test]
        [TestCase("HELLO", ExpectedResult = true)]
        [TestCase("HEllo", ExpectedResult = false)]
        [TestCase("mArmALadE", ExpectedResult = false)]
        [TestCase("marmalade", ExpectedResult = true)]
        [TestCase("MARMALADE", ExpectedResult = true)]
        [TestCase("ketchUP", ExpectedResult = false)]
        [TestCase("pickle", ExpectedResult = true)]
        [TestCase("MUSTARD", ExpectedResult = true)]
        public static bool CheckSameCaseTests(string str) => CheckSameCase.SameCase(str);

        [Test]
        [TestCase("String", ExpectedResult = "SSttrriinngg")]
        [TestCase("Hello World!", ExpectedResult = "HHeelllloo  WWoorrlldd!!")]
        [TestCase("1234!_ ", ExpectedResult = "11223344!!__  ")]
        [TestCase("##^&%%*&%%$#@@!", ExpectedResult = "####^^&&%%%%**&&%%%%$$##@@@@!!")]
        [TestCase("scandal", ExpectedResult = "ssccaannddaall")]
        [TestCase("economics", ExpectedResult = "eeccoonnoommiiccss")]
        [TestCase(" ", ExpectedResult = "  ")]
        [TestCase("_______", ExpectedResult = "______________")]
        [TestCase("equip gallon read", ExpectedResult = "eeqquuiipp  ggaalllloonn  rreeaadd")]
        [TestCase("baby increase", ExpectedResult = "bbaabbyy  iinnccrreeaassee")]
        public static string DoubleCharTests(string str) => DoubleChar.DoubleCharMethod(str);
        
    }
}
