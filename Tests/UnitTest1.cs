using System;
using WordWrappingProblem;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestWordFix()
        {
            var wordWrap = new WordWrap();
            string expectedString = "This is a bad string";
            string badString = "This is a \n bad     string";
            string fixedString = wordWrap.FixStrings(badString);

            Assert.Equal(expectedString, fixedString);
        }

         [Fact]
        public void TestFirstCase()
        {
            var wordWrap = new WordWrap();
            int width = 7;
            string exampleString = "one two";
            string expectedString = "one two";

            string fixedString = wordWrap.Wrap(exampleString, width);
            Assert.Equal(expectedString, fixedString);
        }

        [Fact]
         public void TestSecondCase()
        {
            var wordWrap = new WordWrap();
            int width = 3;
            string exampleString = "one two";
            string expectedString = "one\ntwo";

            string fixedString = wordWrap.Wrap(exampleString, width);
            Assert.Equal(expectedString, fixedString);
        }

         [Fact]
         public void TestThirdCase()
        {
            var wordWrap = new WordWrap();
            int width = 3;
            string exampleString = "oneoneoneoneoneee";
            string expectedString = "one\none\none\none\none\nee";

            string fixedString = wordWrap.Wrap(exampleString, width);
            Assert.Equal(expectedString, fixedString);
        }


    }
}
