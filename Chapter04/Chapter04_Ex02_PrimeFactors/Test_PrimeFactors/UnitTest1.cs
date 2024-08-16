using PrimeFactors;

namespace Test_PrimeFactors
{
    public class PrimeFactorsString
    {
        [Fact]
        public void PrimeFactorsString4()
        {
            // ����������
            int a = 4;
            string expected = "2x2";
            // ��������
            string actual = PrimeFactorsClass.PrimeFactorsString(a);
            // �����������
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsString7()
        {
            // ����������
            int a = 7;
            string expected = "7";
            // ��������
            string actual = PrimeFactorsClass.PrimeFactorsString(a);
            // �����������
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsString30()
        {
            // ����������
            int a = 30;
            string expected = "2x3x5";
            // ��������
            string actual = PrimeFactorsClass.PrimeFactorsString(a);
            // �����������
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsString40()
        {
            // ����������
            int a = 40;
            string expected = "2x2x2x5";
            // ��������
            string actual = PrimeFactorsClass.PrimeFactorsString(a);
            // �����������
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsString50()
        {
            // ����������
            int a = 50;
            string expected = "2x5x5";
            // ��������
            string actual = PrimeFactorsClass.PrimeFactorsString(a);
            // �����������
            Assert.Equal(expected, actual);
        }
    }
}