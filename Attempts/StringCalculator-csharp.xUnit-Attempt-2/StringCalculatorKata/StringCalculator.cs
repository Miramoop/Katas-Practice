using System;
using System.Linq;

namespace StringCalculatorKata;

public class StringCalcualtor
{
    public int Add(string numbers)
    {
        if (string.IsNullOrWhiteSpace(numbers))
        {
            return 0;
        }

        if (numbers.Contains('-'))
        {
            var listOfNegativeNumbers = numbers.Split(',')
                .Select(int.Parse)
                .Where(x => x < 0);
            var delimiter = ",";
            var stringOfNumberNumbers = string.Join(delimiter, listOfNegativeNumbers);

            throw new Exception($"Negative Numbers Not Allowed: {stringOfNumberNumbers}");
        }

        if (numbers.Contains(','))
        {
            var total = numbers.Split(',')
                .Select(int.Parse)
                .Sum();
            return total;
        }
    }
}
