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
         [Fact]
        public void TestExample1()
        {
            var wordWrap = new WordWrap();
            int width = 13;
            string exampleString = "Green metal stick";
            string expectedString = "Green metal\nstick";

            string fixedString = wordWrap.Wrap(exampleString, width);
            Assert.Equal(expectedString, fixedString);
        }

        [Fact]
        public void TestExample2()
        {
            var wordWrap = new WordWrap();
            int width = 7;
            string exampleString = "Establishment of the church";
            string expectedString = "Establi\nshment\nof the\nchurch";

            string fixedString = wordWrap.Wrap(exampleString, width);
            Assert.Equal(expectedString, fixedString);
        }

        [Fact]
        public void TestExample3()
        {
            var wordWrap = new WordWrap();
            int width = 9999;
            string exampleString = "Lorem ipsum dolor sit amet";
            string expectedString = "Lorem ipsum dolor sit amet";
            
            string fixedString = wordWrap.Wrap(exampleString, width);
            Assert.Equal(expectedString, fixedString);
        }

        [Fact]
        public void TestExample4()
        {
            var wordWrap = new WordWrap();
            int width = 3;
            string exampleString = "1234 1 1234";
            string expectedString = "123\n4 1\n123\n4";
            
            string fixedString = wordWrap.Wrap(exampleString, width);
            Assert.Equal(expectedString, fixedString);
        }

        [Fact]
        public void TestSomeMore1()
        {
            var wordWrap = new WordWrap();
            int width = 7;
            string exampleString = "Establishmentestablishment";
            string expectedString = "Establi\nshmente\nstablis\nhment";
            
            string fixedString = wordWrap.Wrap(exampleString, width);
            Assert.Equal(expectedString, fixedString);
        }

        [Fact]
        public void TestSomeMore2()
        {
            var wordWrap = new WordWrap();
            int width = 7;
            string exampleString = "Establishmentestablishment a of the the church";
            string expectedString = "Establi\nshmente\nstablis\nhment a\nof the\nthe\nchurch";
            
            string fixedString = wordWrap.Wrap(exampleString, width);
            Assert.Equal(expectedString, fixedString);
        }


    }
}
