using System;

public class Stage
{
    // public Obi obi;
    public static string GetInformationStage () {
    return " [Main Objective: Find the hidden shuttle back to earth.] \n \n (Location): In a hidden capsule with a Door (Right) and a Door (Infront).";
    }
    public static string GetInformationStage2 () {
    return " (Location): You're in a tube. You can see a weird creature at the end of it. \n The creature has a HP of 180! \n Will you try to (Attack) it or will you try to (Run) straight through it?";
    }
    public static string GetInformationstage3 (){
    return " (Location): You are in a big room where you can see an (Entrance) towards the shuttle. \n You can also see a Door (Left) which leads into something interesting.";
    }
    public static string GetInformationstage4(){
    return " (Location): You stumbled into a TRAP! \n There is loads of gunfire and you run into a small passage way where theres a functioning door that can (Close). \n There is also a square device that is ticking pretty loudly in that passage way. \n Use the (Device) as a weapon or (Close) the door?";
    }
    public static string GetInformationstage5 (){
    return " (Location:) You're in a small chamber. \n You then find a compass in a small storage locker. \n You have a small (Hatch) that goes under you, and a (Ladder) at the end of the room that goes up \n Your compass says that the way forward is down under you. \n Will you trust it and go into the (Hatch) or up the (Ladder)";
    }
        public static string GetInformationstage6Vader (){
        return " You attack the creature with your lightsaber and do (" + Vader.damage + ") Damage . The creature dies and you find a (Hole) in the wall! ";
    }
        public static string GetInformationstage6Skywalker (){
        return " You attack the creature with your lightsaber and do (" + Skywalker.damage + ") Damage . The creature kills you and you have failed the mission! \n You're a Disgrace! ";
    }
        public static string GetInformationstage6Obi (){
        return " You attack the creature with your lightsaber and do (" + Obi.damage + ") Damage. \n You get thrown into the wall and you break your neck. \n It's Over! You failed :/ ";
    }
    public static string GetInformationstage7 (){
        return " ";
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
