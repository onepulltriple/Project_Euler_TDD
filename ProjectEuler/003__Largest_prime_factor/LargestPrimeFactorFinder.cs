using System.Net.Http.Headers;

namespace ProjectEuler._003__Largest_prime_factor
{
    public class LargestPrimeFactorFinder
    {
        // list to hold prime numbers up to and possibly including the input number
        public List<ulong> ListOfPrimes { get; set; } = new List<ulong>();

        public ulong FindLargestPrimeFactor(ulong numberInQuestion)
        {
            FindPrimeFactors(numberInQuestion);
            return ListOfPrimes.Last();
        }

        public List<ulong> FindPrimeFactors(ulong numberInQuestion)
        {
            ulong outputNumber;

            if (numberInQuestion <= 1)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(numberInQuestion),
                    actualValue: numberInQuestion,
                    $"Whole numbers less than 1 do not contain any positive prime numbers. Input a whole number greater than or equal to 2.");
            }

            // apply the Sieve of Eratosthenes
            // loop over the prime integers 
            // increment by 2 and 4, alternating
            ulong j = 2;
            for (ulong i = 2; i < numberInQuestion; i+=j)
            {
                if (i % 5 == 0 && i > 5)
                    continue; // skips multiples of 5, but not 5 itself

                outputNumber = ExtractFactor(numberInQuestion, i);

                if (outputNumber == 1)
                {
                    ListOfPrimes.Add(i);
                    return ListOfPrimes;
                    // if the resulting output number is 1,
                    // then greatest prime factor has been found
                }
                if (outputNumber != numberInQuestion)
                    ListOfPrimes.Add(i);

                numberInQuestion = outputNumber;

                if (j == 2)
                    j = 4;
                else
                    j = 2;

                // corrects 'i' as needed, so that 2, 3, and 5 are examined
                switch (i)
                {
                    case 2:
                        j = 1;
                        break;
                    case 3:
                        j = 2;
                        break;
                    case 5:
                        j = 2;
                        break;
                }
            }

            // if ListOfPrimes is still empty, then we started with a prime number
            ListOfPrimes.Add(numberInQuestion);
            return ListOfPrimes; 
        }

        public ulong ExtractFactor(ulong inputNumber, ulong factorToFactorOut)
        {
            ulong outputNumber = inputNumber;

            while (inputNumber % factorToFactorOut == 0)
            {
                inputNumber = inputNumber / factorToFactorOut;
                outputNumber = inputNumber;
            }
    
            return outputNumber;
        }

        public void PrintPrimeFactorsList(ulong number)
        {
            int count = ListOfPrimes.Count;
            Console.WriteLine($"The list of prime factors for {number} is:");
            foreach (ulong primeNumber in ListOfPrimes)
            {
                if (--count > 0)
                    Console.Write($"{primeNumber}, ");
                else
                    Console.Write($"{primeNumber}");
            }
            Console.WriteLine();
        }
    }
}
