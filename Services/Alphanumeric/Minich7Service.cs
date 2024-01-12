
namespace FiveToSeven.Services.Alphanumeric;

    public class Minich7Service : IMinich7Service
    {
          public string ReverseItAlpha(string word)
    {
        string result = "";
        for (int i = word.Length - 1; i > -1; i--)
        {
            result += word[i];
        }
        return result;
    }
    }
