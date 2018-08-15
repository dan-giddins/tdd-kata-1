using System;
using tdd_kata_1;
using Xunit;

namespace tdd_kata_1_tests
{
    public class StringCalculatorUnitTest
    {
        private StringCalculator stringCalculator;

        public StringCalculatorUnitTest()
        {
            stringCalculator = new StringCalculator();
        }

        [Fact]
        public void Add_EmptyString_ReturnZero()
        {
            Assert.Equal(0, stringCalculator.Add(""));
        }

        [Fact]
        public void Add_One_ReturnOne()
        {
            Assert.Equal(1, stringCalculator.Add("1"));
        }

        [Fact]
         public void Add_Ten_ReturnTen()
        {
            Assert.Equal(10, stringCalculator.Add("10"));
        }

        [Fact]
        public void Add_OneTwo_ReturnThree()
        {
            Assert.Equal(3, stringCalculator.Add("1,2"));
        }

        [Fact]
        public void Add_TenEleven_ReturnTwentyOne()
        {
            Assert.Equal(21, stringCalculator.Add("10,11"));
        }
  
        [Fact]
        public void Add_OneTwoThreeFourFive_ReturnFifteen()
        {
            Assert.Equal(15, stringCalculator.Add("1,2,3,4,5"));
        }

        [Fact]
        public void Add_TenElevenTwelve_ReturnThirtyThree()
        {
            Assert.Equal(33, stringCalculator.Add("10,11,12"));
        }

        [Fact]
        public void Add_OneNewLineTwo_ReturnThree()
        {
            Assert.Equal(3, stringCalculator.Add("1\n2"));
        }

        [Fact]
        public void Add_OneNewLineTwoCommaThree_ReturnSix()
        {
            Assert.Equal(6, stringCalculator.Add("1\n2,3"));
        }

        [Fact]
        public void Add_OneNewLineTwoNewLineThreeCommaFourCommaFiveNewLineSixCommaSeven_ReturnFifteySix()
        {
            Assert.Equal(28, stringCalculator.Add("1\n2\n3,4,5\n6,7"));
        }

        [Fact]
        public void Add_Delimiter_ReturnZero()
        {
            Assert.Equal(0, stringCalculator.Add("//;\n"));
        }

        [Fact]
        public void Add_DelimiterOneTwo_ReturnThree()
        {
            Assert.Equal(3, stringCalculator.Add("//;\n1;2"));
        }

        [Fact]
        public void Add_DelimiterOneNewLineTwoNewLineThreeCommaFourCommaFiveNewLineSixCommaSeven_ReturnTwentyEight()
        {
            Assert.Equal(28, stringCalculator.Add("//;\n1\n2\n3,4,5\n6,7"));
        }
        [Fact]
        public void Add_DelimiterOneNewLineTwoNewLineThreeCommaNegativeFourCommaFiveNewLineSixCommaSeven_ReturnTwentyFour()
        {
            Assert.Equal(24, stringCalculator.Add("//;\n1\n2\n3,-4,5\n6,7"));
        }

        [Fact]
        public void Add_DelimiterNegativeFour_ReturnZero()
        {
            Assert.Equal(0, stringCalculator.Add("//;\n-4"));
        }

        [Fact]
        public void Add_NegativeFour_ReturnZero()
        {
            Assert.Equal(0, stringCalculator.Add("-4"));
        }

        [Fact]
        public void Add_DelimiterOneThousandNewLineTwoNewLineThreeCommaNegativeFourCommaFiveNewLineSixCommaSeven_ReturnOneThousandAndTwentyThree()
        {
            Assert.Equal(1023, stringCalculator.Add("//;\n1000\n2\n3,-4,5\n6,7"));
        }
        [Fact]
        public void Add_OneNewLineTwoNewLineThreeCommaNegativeFourCommaFiveNewLineSixCommaSevenDelimiter_ReturnTwentyTwo()
        {
            Assert.Equal(22, stringCalculator.Add("//;\n1\n2000\n3,-4,5\n6,7"));
        }
    }
}
