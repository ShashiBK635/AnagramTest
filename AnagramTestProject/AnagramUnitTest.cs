
namespace AnagramTestProject
{
    public class AnagramUnitTest
    {
        [Fact]
        public void TestMethod1()
        {
            Assert.True(AnagramLibrary.Anagram.isAnagram("cinema", "iceman"));
        }

        [Fact]
        public void TestMethod2()
        {
            Assert.True(AnagramLibrary.Anagram.isAnagram("Tom Marvolo Riddle", "I am Lord Voldemort!"));
        }

        [Fact]
        public void TestMethod3()
        {
            Assert.True(AnagramLibrary.Anagram.isAnagram("Dave Barry", "Ray Adverb"));
        }

        [Fact]
        public void TestMethod4()
        {
            Assert.True(AnagramLibrary.Anagram.isAnagram("debit card", "bad credit"));
        }

        [Fact]
        public void TestMethod5()
        {
            Assert.True(AnagramLibrary.Anagram.isAnagram("astronomer", "Moon starer"));
        }

        [Fact]
        public void TestMethod6()
        {
            Assert.True(AnagramLibrary.Anagram.isAnagram("abc123", "c3b2a1"));
        }

        [Fact]
        public void TestMethod7()
        {
            Assert.False(AnagramLibrary.Anagram.isAnagram("banana", "bananas"));
        }

        [Fact]
        public void TestMethod8()
        {
            Assert.False(AnagramLibrary.Anagram.isAnagram("bananab", "abanana"));
        }

        [Fact]
        public void TestMethod9()
        {
            Assert.False(AnagramLibrary.Anagram.isAnagram("Tom Riddle", "I’m Lord Voldemort?"));
        }

        [Fact]
        public void TestMethod10()
        {
            Assert.False(AnagramLibrary.Anagram.isAnagram("abc123", "a11b22c33"));
        }

    }
}