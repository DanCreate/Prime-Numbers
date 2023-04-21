

class PrimeNumbers
{

    static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter a number");
        number = int.Parse(Console.ReadLine());
        
        var primenumber = PrimeEvaluation(number);

        if (primenumber == true)
        {

            Console.WriteLine(number + " is a prime number");

        }
        else
        {
            Console.WriteLine(number + " is not a prime number");
        }

    }

    public static bool PrimeEvaluation(int number)
    {

        for (int i = 2; i < number; i++)
        {

            if (number % i == 0)
            {
                return false;

            }

        }

        return true;

    }

}