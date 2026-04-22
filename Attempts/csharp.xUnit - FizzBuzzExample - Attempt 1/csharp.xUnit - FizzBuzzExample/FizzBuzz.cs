namespace csharp.xUnit___FizzBuzzExample;

public class FizzBuzz
{
    public static string Stringify(int num)
    {
        if (IsDivisibleBy3And5(num))
        {
            return "FizzBuzz";
        }

        if (IsDivisibleBy3(num))
        {
            return "Fizz";
        }

        if (IsDivisibleBy5(num))
        {
            return "Buzz";
        }

        return num.ToString();

    }

    private static bool IsDivisibleBy5(int num)
    {
        return num % 5 == 0;
    }

    private static bool IsDivisibleBy3(int num)
    {
        return num % 3 == 0;
    }

    private static bool IsDivisibleBy3And5(int num)
    {
        return num % 3 == 0 && num % 5 == 0;
    }
}