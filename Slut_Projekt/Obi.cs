
public class Obi
{
    // public Obi obi;
    public static string? name { get; set; } = "Obi-Wan Kenobi";
    public static string weapon  = "Blue Lightsaber";
    public static int HP  = 100;
    public static int damage = 100;
    public static string GetInformationObi () {
    return " Here Are Your Stats: \n Name: " + name + "  \n [HP] = " + Obi.HP + " \n [Weapon] = " + Obi.weapon;
    }
public Obi(){
        
        // RestClient playerClient = new("https://swapi.py4e.com/api/");      //https://swapi.py4e.com/api/
        // RestRequest request = new("people/10/");
        // RestResponse response = playerClient.GetAsync(request).Result;

        // if (response.StatusCode == HttpStatusCode.OK)                             //API for name of character
        // {
        //     obi = JsonSerializer.Deserialize<Obi>(response.Content);
        //     Console.WriteLine(obi.name);
        //     Console.WriteLine(response.Content);

        // }
}
}

