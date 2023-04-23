public class Skywalker
{
    public static string name { get; set; } = "Luke Skywalker";
    public static string weapon { get; set; } = "Green Lightsaber";
    public static int HP { get; set; } = 150;
    public static int damage = 100;

    public static string GetInformationSkywalker () {
    return " Here Are Your Stats: \n Name: " + Skywalker.name + "  \n [HP] = " + Skywalker.HP + " \n [Weapon] = " + Skywalker.weapon;
    }

}


