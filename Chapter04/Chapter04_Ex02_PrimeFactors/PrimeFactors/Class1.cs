namespace PrimeFactors
{
    public class PrimeFactorsClass
    {
        public static string PrimeFactorsString(int number)
        {
            string answer = "";
            int temp = number;
            for (int i = 2; i<= temp; i++)
            {
                if (temp%i==0)
                {
                    temp = temp/i;
                    if (answer == "")
                    {
                        answer += i.ToString();
                    }
                    else
                    {
                        answer += "x"+i.ToString();
                    }
                    i = 1;
                }
            }
            return answer;
        }

    }
}
