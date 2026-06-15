using System.Security.Cryptography.X509Certificates;

namespace StringCalculatorKata;

public class StringCalculator
{
    public int Add(string numbers)
    {
        var separators = new char[] { ',', '\n' };
        
        if (numbers.EndsWith(',') || numbers.EndsWith('\n'))
        {
            throw new Exception("Number expected but EOF found.");
        }
        
        if (numbers.Contains('-'))
        {
            var negativeNumbers = numbers.Split(separators)
                .Select(int.Parse)
                .Where(x => x < 0);
            var stringOfNegativeNumbers = string.Join(',', negativeNumbers);

            throw new Exception($"Negative Numbers Not Allowed: {stringOfNegativeNumbers}");
        }
        
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }
        
        if (numbers.Contains(',') || numbers.Contains('\n'))
        {
            var total = numbers.Split(separators)
                .Select(int.Parse)
                .Sum();
            return total;
        }
      
        return int.Parse(numbers);
    }
}
