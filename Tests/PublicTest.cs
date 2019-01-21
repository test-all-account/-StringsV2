using NUnit.Framework;

namespace StringHelpers.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [TestCase("abracadabra", ExpectedResult = 5)]
        [TestCase("sprppr", ExpectedResult = 0)]
        [TestCase("aaa", ExpectedResult = 3)]
        public int GetVowelCountTest(string source) => VowelCountTask.GetVowelCount(source);
    }
}