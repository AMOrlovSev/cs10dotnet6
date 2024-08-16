using PrimeFactors;

namespace Test_PrimeFactors
{
    public class PrimeFactorsString
    {
        [Fact]
        public void PrimeFactorsString4()
        {
            // размещение
            int a = 4;
            string expected = "2x2";
            // действие
            string actual = PrimeFactorsClass.PrimeFactorsString(a);
            // утверждение
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsString7()
        {
            // размещение
            int a = 7;
            string expected = "7";
            // действие
            string actual = PrimeFactorsClass.PrimeFactorsString(a);
            // утверждение
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsString30()
        {
            // размещение
            int a = 30;
            string expected = "2x3x5";
            // действие
            string actual = PrimeFactorsClass.PrimeFactorsString(a);
            // утверждение
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsString40()
        {
            // размещение
            int a = 40;
            string expected = "2x2x2x5";
            // действие
            string actual = PrimeFactorsClass.PrimeFactorsString(a);
            // утверждение
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsString50()
        {
            // размещение
            int a = 50;
            string expected = "2x5x5";
            // действие
            string actual = PrimeFactorsClass.PrimeFactorsString(a);
            // утверждение
            Assert.Equal(expected, actual);
        }
    }
}