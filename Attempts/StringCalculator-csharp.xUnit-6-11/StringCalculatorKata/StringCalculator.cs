namespace StringCalculatorAttempt6_11;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        if (numbers.EndsWith(',') || numbers.EndsWith('\n'))
        {
            throw new Exception("Number expected but EOF found.");
        }
        
        if (numbers.Contains('-'))
        {
            var listOfNegativeNumbers = numbers.Split(',')
                .Select(int.Parse)
                .Where(x => x < 0);
            var delimiter = ",";
            var stringOfNegativeNumbers = string.Join(delimiter, listOfNegativeNumbers);
        
            throw new Exception($"Negative Numbers Not Allowed: {stringOfNegativeNumbers}");
        }

        if (numbers.Contains(','))
        {
            var total = numbers.Split(',')
                .Select(int.Parse)
                .Sum();
            return total;
        }

        if (numbers.Contains('\n'))
        {
            var total = numbers.Split('\n')
                .Select(int.Parse)
                .Sum();
            return total;
        }
        
        return (int.Parse(numbers));
    }
}