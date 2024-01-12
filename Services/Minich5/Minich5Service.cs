
namespace FiveToSeven.Services.Minich5;

    public class Minich5Service :  IMinich5Service
    {
    public string MadLib(string noun1, string noun2,string noun3, string verb1, string verb2)
    {
        return $"You have to show them that you're really not {verb1} You're playin' with your {noun1}, this ain't no truth {noun2},or dare They'll {verb2} you, then they'll {verb2} you Then they'll tell you it's fair  {noun3} So";
    }
}
