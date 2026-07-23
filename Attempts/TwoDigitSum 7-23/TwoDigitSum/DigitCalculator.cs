namespace TwoDigitSum;

public class DigitCalculator
{
    public int InputtedInt { get; set; }

    public int TensPlace { get; set; }
    public int OnesPlace { get; set; }
    public int DigitsSum { get; set; }
    
    public void Add(int n)
    {
        InputtedInt = n;
        TensPlace = n / 10;
        OnesPlace = n % 10;
        DigitsSum = TensPlace + OnesPlace;
    }
}