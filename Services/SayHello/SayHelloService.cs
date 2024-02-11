namespace FiveToSeven.Services.SayHello;

public class SayHelloService : ISayHelloService
{
    public string SayHello2(string name)
    {
        
         if(!string.IsNullOrWhiteSpace(name))
         {
             return "Hello, " + name;
         } else{
 return "Cannot Be Empty!!!";

         }
      
           
    }
}
