
public class Obi
{
    public Obi obi;
    public static string name { get; set; }   
    public static string weapon { get; set; } = "Blue Lightsaber";
    public static int HP { get; set; } = 100;
    public static int damage = 100;
public Obi(){
        
        RestClient shipClient = new("//https://swapi.py4e.com/api/");   
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

