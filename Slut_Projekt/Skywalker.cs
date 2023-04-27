public class Skywalker : Character
{
    public static string name { get; set; } = "Luke Skywalker";
    public static string weapon = "Green Lightsaber";               // Information about this character
    public static int damage = 150;

    public static string GetInformationSkywalker () {
    return " Here Are Your Stats: \n [Name]: " + Skywalker.name + "  \n [HP] = " + Skywalker.HP + " \n [Weapon] = " + Skywalker.weapon + "\n [Damage] = " + Skywalker.damage;
    }

}


