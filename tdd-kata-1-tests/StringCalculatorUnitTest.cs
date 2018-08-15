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
    }
}
