
public class Obi
{
    public static string name { get; set;}
    public static string weapon { get; set; }
    public static int HP { get; set; } = 100;

public Obi(){
        
        
        RestClient shipClient = new("https://swapi.dev/api/");     
        RestRequest request = new("people/10/");
        RestResponse response = shipClient.GetAsync(request).Result;

        if (response.StatusCode == HttpStatusCode.OK)                             // API Anrop for player
        {
            Obi = JsonSerializer.Deserialize<Obi>(response.Content);
            Console.WriteLine(Obi.name);
            Console.WriteLine(response.Content);
        }
}

}

