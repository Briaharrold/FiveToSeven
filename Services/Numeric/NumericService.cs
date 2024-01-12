
namespace FiveToSeven.Services.Numeric;

public class NumericService : INumericService
{
    public string ReverseIt(string number)
    {
        double number2;
       if (Double.TryParse(number, out number2))
    {
        string result = "";
        for (int i = number.Length - 1; i > -1; i--)
        {
            result += number[i];
        }
        return result;
    }
     return number + " is an invalid input";
    }
}

