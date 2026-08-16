namespace StringRetrievalKata;

public class StringModifier
{
    public int ReverseString(string str)
    {
        int result = 0;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            if ("aeiouAEIOU".Contains(str[i]))
            {
                result++;
            }
            //result += str[i]
        }
        return result;
    }
}