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


            // apply the Sieve of Eratosthenes

            // check 2, 3, and 5 on on their own
            numberInQuestion = FactorExtractor(numberInQuestion, 2); 
            numberInQuestion = FactorExtractor(numberInQuestion, 3); 
            numberInQuestion = FactorExtractor(numberInQuestion, 5); 

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
            // 2, 2
            // 32, 2
            // 37,2

            int outputNumber = inputNumber;

            while (inputNumber % factorToFactorOut == 0)
            {
                inputNumber = inputNumber / factorToFactorOut;
                outputNumber = inputNumber;
            }
    
            return outputNumber;
            // 1 means the factor was the only prime factor (e.g. 32, 2 yields 1)
            // or it means the number was itself prime

        }
    }
}
