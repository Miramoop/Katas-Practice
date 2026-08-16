namespace StringCalculatorKata;

public class MSG
{
    public string Message { get; set; }
    public int Value { get; set; }
}

public class StringCalculator
{
    public MSG Add(string numbers)
    {
        var msg = new MSG();
        if (string.IsNullOrEmpty(numbers))
        {
            msg.Value = 0;
        }
        ValidateEndingSeparator(numbers);
        
        msg.Message = ValidateIfNegativeNumbers(numbers);
        
        return msg;
        //return CalculateSum(numbers);
    }

    private static int CalculateSum(string numbers)
    {
        var total = ParseNumbers(numbers)
            .Sum();
        return total;
    }

    private static IEnumerable<int> ParseNumbers(string numbers)
    {
        return numbers.Split(',', '\n')
            .Select(int.Parse);
    }

    private string ValidateIfNegativeNumbers(string numbers)
    {
        // How to have it return an int and message, not as an exception
        // Add a property on StringCalculator of message and return that instead of the numbers

        var negativeNumbers = ParseNumbers(numbers)
            .Where(x => x < 0)
            .ToList();

        if (negativeNumbers.Any())
        {
            return $"Negative Numbers not allowed: {string.Join(",", negativeNumbers)}";
            //throw new Exception($"Negative Numbers not allowed: {string.Join(",",negativeNumbers)}");
        }

        return String.Empty;
    }

    private static void ValidateEndingSeparator(string numbers)
    {
        if (numbers.EndsWith(','))
        {
            throw new Exception("Number expected but EOF found");
        }
    }
}


