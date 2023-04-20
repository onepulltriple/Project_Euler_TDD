namespace ProjectEuler._003__Largest_prime_factor
{
    public class LargestPrimeFactorFinder
    {
        // list to hold prime numbers up to and possibly including the input number
        public List<int> ListOfPrimes { get; set; } = new List<int>();

        public int FindLargestPrimeFactor(int numberInQuestion)
        {
            // apply the Sieve of Eratosthenes
            int outputNumber;

            if (numberInQuestion <= 1)
            {
                //throw exception 
            }

            // check 2, 3, and 5 on on their own
            for (int i = 2; i <= 5; i++)
            {
                if (i == 4)
                    continue; // skips 4

                outputNumber = FactorExtractor(numberInQuestion, i);

                if (outputNumber == 1)
                {
                    ListOfPrimes.Add(i);
                    return ListOfPrimes.Last();
                }
                if (outputNumber != numberInQuestion)
                    ListOfPrimes.Add(i);

                numberInQuestion = outputNumber;
            }


            // loop over the remaining integers 
            // increment by 2 and 4, alternating
            int j = 2;
            for (int i = 7; i <= numberInQuestion; i+=j)
            {
                if (numberInQuestion % 5 == 0)
                    continue; // skips multiples of 5

                outputNumber = FactorExtractor(numberInQuestion, i);

                if (outputNumber == 1)
                {
                    ListOfPrimes.Add(i);
                    return ListOfPrimes.Last();
                }
                if (outputNumber != numberInQuestion)
                    ListOfPrimes.Add(i);

                numberInQuestion = outputNumber;

                if (j == 2)
                    j = 4;
                else
                    j = 2;

            }

            // since resulting number is 1, we should know that we are done

            // if list of int is empty, we started with a prime number
            ListOfPrimes.Add(numberInQuestion);
            return ListOfPrimes.Last(); ;

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
            // 1 means the factor was the only prime factor
            // e.g. (32, 2) yields an ouput number of 1

        }

        public void PrintPrimeFactorsList(int number)
        {
            Console.WriteLine($"The list of prime factors for {number} is:");
            foreach (int primeNumber in ListOfPrimes)
            {
                Console.Write($"{primeNumber}, ");
            }
            Console.WriteLine();
        }
    }
}
