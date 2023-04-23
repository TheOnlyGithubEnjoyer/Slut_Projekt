using System;

public class Stage
{
    // public Obi obi;
    public static string GetInformationStage () {
    return " [Main Objective: Find the hidden shuttle back to earth.]";
    return " (Location): In a hidden capsule with a Door (Right) and a Door (Infront)";
    }
    public static string GetInformationStage2 () {
    return " [Main Objective: Find the hidden shuttle back to earth.]";
    return " (Location): You're in a tube. You can see a weird creature at the end of it.";
    return " Will you try to (Attack) it or will you try to (Run) straight through it?";
    }
    public static string GetInformationstage3 (){
    return " [Main Objective: Find the hidden shuttle back to earth.]";
    return " (Location): You are in a big room where you can see an (Entrance) towards the shuttle.";
    return " You can also see a Door (Left) which leads into something interesting";
    return " What will you do? Go to the (Entrance) or will you investigate the Door to the (Left)?";
    }
    public Stage(){
        // RestClient shipClient = new("https://swapi.py4e.com/api/");
        // RestRequest request = new("starships/10/");
        // RestResponse response = shipClient.GetAsync(request).Result;

        // if (response.StatusCode == HttpStatusCode.OK)
        // {
        //     obi = JsonSerializer.Deserialize<Obi>(response.Content);
        //     Console.WriteLine(Obi.name);
        // }
    }
}
