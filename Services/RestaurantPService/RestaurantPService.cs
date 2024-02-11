namespace FiveToSeven.Services.RestaurantPService{
    public class RestaurantPService : IRestaurantPService{
  public string Breakfast(string userInput){
 
    Random outCome = new Random();
    int number = outCome.Next(10);
    switch (number)
    {
        case 0:
            return "Denny's";
        case 1:
            return "Chuck's";
        case 2:
            return "Ihop";
        case 3:
            return "Lumberjack's";
        case 4:
            return "Omelet House";
        case 5:
            return "jeffery's";
        case 6:
            return "American Waffle's";
        case 7:
            return "Maria's cafe";
        case 8:
            return "Black Bear";
        default:
            return "Feds";
    }
}


public string Mexican(string userInput){
    Random outCome = new Random();
    int number = outCome.Next(10);
    switch (number)
    {
        case 0:
            return "Casa Flores";
        case 1:
            return "Tacos champala";
        case 2:
            return "El Grulito";
        case 3:
            return "Don rafas";
        case 4:
            return "El dorado Market";
        case 5:
            return "El Mayita";
        case 6:
            return "Gallos Tacos";
        case 7:
            return "Tepa Taqueria";
        case 8:
            return "Miguels Mexcian Restaurant";
        default:
            return "Tequileros Taqueria";
    }
}

public string Pizza(string userInput){
    Random outCome = new Random();
    int number = outCome.Next(10);
    switch (number)
    {
        case 0:
            return "Litte Ceasers";
        case 1:
            return "Davids Pizza";
        case 2:
            return "Pizza My Heart";
        case 3:
            return "Pizza Hut";
        case 4:
            return "Mountain Mike's";
        case 5:
            return "Round Table";
        case 6:
            return "Dominos";
        case 7:
            return "VIP Pizza";
        case 8:
            return "Blaze Pizza";
        default:
            return "Pieology";
    }
}

    }
}