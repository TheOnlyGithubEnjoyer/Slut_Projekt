
public class Obi
{
    public Obi obi;
    public static string name { get; set; }   
    public static string weapon  = "Blue Lightsaber";
    public static int HP  = 100;
    public static int damage = 100;
    public static string GetInformation () {
    Console.WriteLine("Your Chosen Character Is " + Obi.name + "!");
    return " Here Are Your Stats: ";
    return " Name: " + Obi.name + "   [HP] = " + Obi.HP + "   [Weapon] = " + Obi.weapon;
    }

public Obi(){
        
        RestClient shipClient = new("//https://swapi.com/api/");   
        RestRequest request = new("people/10/");
        RestResponse response = shipClient.GetAsync(request).Result;

        if (response.StatusCode == HttpStatusCode.OK)                             //API for name of character
        {
            obi = JsonSerializer.Deserialize<Obi>(response.Content);
            
            Console.WriteLine(Obi.name);
            Console.WriteLine(response.Content);
            
        }
}

}

