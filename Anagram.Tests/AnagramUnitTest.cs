using System;
using Xunit;
using Anagram;

namespace Anagram.Tests
{
    public class AnagramUnitTest
    {
        [Fact]
        public void RecognizesShuffledAlphabetsAsAnagrams()
        {
            AnagramSelector selector = new AnagramSelector();
            Assert.True(selector.WordPairIsAnagram("restful", "fluster"));
            Assert.True(selector.WordPairIsAnagram("forty five", "over fifty"));
        }
        [Fact]
        public void ReportsNonAnagrams()
        {
            AnagramSelector selector = new AnagramSelector();
            Assert.False(selector.WordPairIsAnagram("something", "else"));
        }
    }
}
