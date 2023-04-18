namespace ProjectEuler._002__Even_Fibonacci_numbers
{
    public class SummerOfEvenValuedTerms
    {
        public int FindSumOfEvenTermsBelowIncluding(int upperLimit)
        {
            int sum = 0;
            int leftNumber = 1;
            int rightNumber = 2;
            if (upperLimit < 2)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(upperLimit),
                    actualValue: upperLimit,
                    $"The whole numbers less than {upperLimit} do not contain any positive even numbers. Input a whole number greater than or equal to 2.");
            }
            else
            {
                do
                {
                    if (rightNumber % 2 == 0)
                        sum += rightNumber;

                    int temp = leftNumber;
                    leftNumber = rightNumber;
                    rightNumber = temp + leftNumber;
                } while (rightNumber <= upperLimit);
            }

            return sum;
        }
    }
}
