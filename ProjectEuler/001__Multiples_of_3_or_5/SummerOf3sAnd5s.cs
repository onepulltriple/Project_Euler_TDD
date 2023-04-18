namespace ProjectEuler._001__Multiples_of_3_or_5
{
    public class SummerOf3sAnd5s
    {
        public int FindSumBelowExcluding(int upperLimit)
        {
            int sum = 0;
            if (upperLimit < 4)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(upperLimit),
                    actualValue: upperLimit, 
                    $"The whole numbers less than {upperLimit} do not contain any positive mulitples of 3 or 5. Choose a whole number greater than or equal to 4.");
            }
            else
            {
                for (int i = 3; i < upperLimit; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                        sum += i;
                }
            }

            return sum;
        }
    }
}
