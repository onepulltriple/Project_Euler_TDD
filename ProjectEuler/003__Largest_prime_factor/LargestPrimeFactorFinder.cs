namespace ProjectEuler._003__Largest_prime_factor
{
    public class LargestPrimeFactorFinder
    {
        // list to hold prime numbers up to and possibly including the input number
        List<int> ListOfPrimes = new List<int>();

        public int FindLargestPrimeFactor(int compositeNumber)
        {
            int temp = 29;

            if (compositeNumber <= 1)
            {
                //throw exception 
            }

            int numberInQuestion = compositeNumber;
            int outputNumber;


            // apply the Sieve of Eratosthenes

            // check 2, 3, and 5 on on their own
            for (int i = 2; i <= 5; i++)
            {
                if (i == 4)
                    continue; // skips 4

                outputNumber = FactorExtractor(numberInQuestion, i);

                if (outputNumber == 1)
                {
                    ListOfPrimes.Add(i);
                    break;
                }
                if (outputNumber != numberInQuestion)
                    ListOfPrimes.Add(i);
            }

            //numberInQuestion = FactorExtractor(numberInQuestion, 2); 
            // if output number was 1, record 2 and stop
            // if output number is different from input number, record 2 and go on
            // if output number is unchanged, 2 was not a factor, so go on

            //numberInQuestion = FactorExtractor(numberInQuestion, 3);
            // if output number was 1, record 3 and stop
            // if output number is different from input number, record 3 and go on
            // if output number is unchanged, 3 was not a factor, so go on

            //numberInQuestion = FactorExtractor(numberInQuestion, 5);
            // if output number was 1, record 5 and stop
            // if output number is different from input number, record 5 and go on
            // if output number is unchanged, 5 was not a factor, so go on


            // loop over the remaining integers 
            // increment by 2 and 4, alternating
            // skip multiples of 5
            int j = 2;
            for (int i = 7; i <= numberInQuestion; i+=j)
            {
                if (numberInQuestion % 5 == 0)
                    continue;

                numberInQuestion = FactorExtractor(numberInQuestion, i);

                if (j == 2)
                    j = 4;
                else
                    j = 2;
            }

            //int resultOfFactorExtraction = FactorExtractor(462, 2);
            // make note of 2
            // then do it again with (231,3)
            //resultOfFactorExtraction = FactorExtractor(231, 3);
            // make note of 3
            // then do it again with not 4, but 5
            //resultOfFactorExtraction = FactorExtractor(77, 5);
            // nothing to note
            // then do it again with 7
            //resultOfFactorExtraction = FactorExtractor(77, 7);
            // make note of 7
            // then do it again with 11
            //resultOfFactorExtraction = FactorExtractor(11, 11);
            // make note of 11
            // since resulting number is 1, we should know that we are done
            return temp;






            // if list of int is empty, we started with a prime number
        }

        public int FactorExtractor(int inputNumber, int factorToFactorOut)
        {
            int outputNumber = inputNumber;

            while (inputNumber % factorToFactorOut == 0)
            {
                inputNumber = inputNumber / factorToFactorOut;
                outputNumber = inputNumber;
            }
    
            return outputNumber;
            // 1 means the factor was the only prime factor (e.g. 32, 2 yields 1)

        }
    }
}
